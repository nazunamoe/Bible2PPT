using System.Diagnostics;
using System.Net;
using Bible2PPT.Services.BibleService.Http;

namespace Bible2PPT.Services.BibleService.Tests.Http;

public class RateLimitHandlerTest
{
    [Fact]
    public async Task SendsOneRequestAtATime()
    {
        var stub = new ConcurrencyHandler();
        using var client = new HttpClient(new RateLimitHandler(TimeSpan.Zero) { InnerHandler = stub });

        await Task.WhenAll(Enumerable.Range(0, 5).Select(_ => client.GetAsync("http://test/")));

        stub.Requests.ShouldBe(5);
        stub.MaxConcurrency.ShouldBe(1);
    }

    [Fact]
    public async Task WaitsMinIntervalBetweenRequests()
    {
        var interval = TimeSpan.FromMilliseconds(200);
        using var client = new HttpClient(new RateLimitHandler(interval) { InnerHandler = new ConcurrencyHandler() });

        var sw = Stopwatch.StartNew();
        for (var i = 0; i < 3; i++)
        {
            (await client.GetAsync("http://test/")).Dispose();
        }

        // 첫 요청은 바로 보내고 나머지 두 요청 앞에서 간격만큼 기다림 (타이머 오차 감안)
        sw.Elapsed.ShouldBeGreaterThanOrEqualTo(interval * 2 - TimeSpan.FromMilliseconds(30));
    }

    private class ConcurrencyHandler : HttpMessageHandler
    {
        private int _current;
        public int Requests;
        public int MaxConcurrency;

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Interlocked.Increment(ref Requests);
            var current = Interlocked.Increment(ref _current);
            InterlockedMax(ref MaxConcurrency, current);
            await Task.Delay(20, cancellationToken);
            Interlocked.Decrement(ref _current);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        private static void InterlockedMax(ref int target, int value)
        {
            int snapshot;
            while ((snapshot = target) < value && Interlocked.CompareExchange(ref target, value, snapshot) != snapshot)
            {
            }
        }
    }
}
