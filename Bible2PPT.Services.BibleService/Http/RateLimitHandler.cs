using System.Diagnostics;

namespace Bible2PPT.Services.BibleService.Http;

/// <summary>
/// 한 성경 소스에 요청을 하나씩만 보내고, 요청이 끝난 뒤 다음 요청까지 최소 간격을 둔다.
/// </summary>
/// <remarks>
/// 책 한 권을 만들 때 장마다 요청하므로 간격 없이 보내면 짧은 시간에 요청이 몰린다.
/// 받은 본문은 캐시하므로 처음 받을 때만 느려진다.
/// </remarks>
public class RateLimitHandler : DelegatingHandler
{
    private readonly SemaphoreSlim _gate = new(1, 1);
    private readonly TimeSpan _minInterval;
    private readonly Func<TimeSpan, CancellationToken, Task> _delay;
    private readonly Stopwatch _clock = Stopwatch.StartNew();
    private TimeSpan _nextRequestAt = TimeSpan.Zero;

    public RateLimitHandler(TimeSpan minInterval, Func<TimeSpan, CancellationToken, Task>? delay = null)
    {
        _minInterval = minInterval;
        _delay = delay ?? Task.Delay;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        await _gate.WaitAsync(cancellationToken).ConfigureAwait(false);
        try
        {
            var wait = _nextRequestAt - _clock.Elapsed;
            if (wait > TimeSpan.Zero)
            {
                await _delay(wait, cancellationToken).ConfigureAwait(false);
            }

            try
            {
                return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
            }
            finally
            {
                _nextRequestAt = _clock.Elapsed + _minInterval;
            }
        }
        finally
        {
            _gate.Release();
        }
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _gate.Dispose();
        }
        base.Dispose(disposing);
    }
}
