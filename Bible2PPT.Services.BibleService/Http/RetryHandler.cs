using System.Net;

namespace Bible2PPT.Services.BibleService.Http;

/// <summary>
/// 일시적인 오류로 실패한 요청을 점점 더 오래 기다리며 정해진 횟수만큼만 다시 시도한다.
/// </summary>
/// <remarks>
/// 응답이 없거나 서버가 바쁘다고 응답하면 서버가 과부하일 가능성이 높으므로
/// 같은 간격으로 계속 요청하지 않고 대기 시간을 늘리며, 여러 사용자가 동시에 재시도하지 않도록 대기 시간을 조금씩 흩뜨린다.
/// 서버가 Retry-After로 대기 시간을 알려주면 그 시간을 따른다.
/// </remarks>
public class RetryHandler : DelegatingHandler
{
    private readonly Func<TimeSpan, CancellationToken, Task> _delay;

    public RetryHandler(Func<TimeSpan, CancellationToken, Task>? delay = null)
    {
        _delay = delay ?? Task.Delay;
    }

    /// <summary>처음 요청을 포함한 최대 요청 횟수</summary>
    public int MaxAttempts { get; init; } = 4;

    /// <summary>요청 한 번이 응답을 기다리는 시간</summary>
    public TimeSpan AttemptTimeout { get; init; } = TimeSpan.FromSeconds(10);

    /// <summary>첫 재시도 전 대기 시간 (이후 두 배씩 늘어남)</summary>
    public TimeSpan BaseDelay { get; init; } = TimeSpan.FromSeconds(1);

    /// <summary>재시도 전 대기 시간의 상한</summary>
    public TimeSpan MaxDelay { get; init; } = TimeSpan.FromSeconds(30);

    /// <summary>서버가 이보다 오래 기다리라고 하면 재시도하지 않고 실패로 처리</summary>
    public TimeSpan MaxRetryAfter { get; init; } = TimeSpan.FromSeconds(60);

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        for (var attempt = 1; ; attempt++)
        {
            HttpResponseMessage? response = null;
            Exception? error = null;

            using (var attemptCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken))
            {
                attemptCts.CancelAfter(AttemptTimeout);
                try
                {
                    response = await base.SendAsync(request, attemptCts.Token).ConfigureAwait(false);
                }
                // 사용자가 취소하지 않았는데 취소되었으면 응답 시간 초과
                catch (OperationCanceledException) when (!cancellationToken.IsCancellationRequested)
                {
                    error = new TimeoutException($"{AttemptTimeout.TotalSeconds}초 안에 응답이 없습니다.");
                }
                catch (HttpRequestException ex)
                {
                    error = ex;
                }
            }

            if (response is not null && !IsTransient(response.StatusCode))
            {
                return response;
            }

            if (attempt >= MaxAttempts)
            {
                // 오류 응답은 호출한 쪽에서 상태 코드로 처리하도록 그대로 반환
                return response ?? throw ToHttpRequestException(error!, attempt);
            }

            var delay = GetRetryAfter(response) ?? GetBackoff(attempt);
            if (delay > MaxRetryAfter)
            {
                return response!;
            }

            response?.Dispose();
            await _delay(delay, cancellationToken).ConfigureAwait(false);
        }
    }

    private static bool IsTransient(HttpStatusCode statusCode) => statusCode
        is HttpStatusCode.RequestTimeout
        or HttpStatusCode.TooManyRequests
        or HttpStatusCode.InternalServerError
        or HttpStatusCode.BadGateway
        or HttpStatusCode.ServiceUnavailable
        or HttpStatusCode.GatewayTimeout;

    private static TimeSpan? GetRetryAfter(HttpResponseMessage? response)
    {
        var retryAfter = response?.Headers.RetryAfter;
        if (retryAfter?.Delta is TimeSpan delta)
        {
            return delta;
        }
        if (retryAfter?.Date is DateTimeOffset date)
        {
            var delay = date - DateTimeOffset.UtcNow;
            return delay > TimeSpan.Zero ? delay : TimeSpan.Zero;
        }
        return null;
    }

    private TimeSpan GetBackoff(int attempt)
    {
        // 1, 2, 4, 8...배로 늘리고 최대 50%까지 무작위로 더해서 재시도 시점을 흩뜨림
        var exponential = BaseDelay.TotalMilliseconds * Math.Pow(2, attempt - 1);
        var jittered = exponential * (1 + (Random.Shared.NextDouble() * 0.5));
        return TimeSpan.FromMilliseconds(Math.Min(jittered, MaxDelay.TotalMilliseconds));
    }

    private static HttpRequestException ToHttpRequestException(Exception error, int attempts) =>
        error as HttpRequestException
        ?? new HttpRequestException($"{attempts}번 시도했지만 성경 소스가 응답하지 않습니다. {error.Message}", error);
}
