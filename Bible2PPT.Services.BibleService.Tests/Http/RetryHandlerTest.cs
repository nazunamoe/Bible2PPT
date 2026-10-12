using System.Net;
using System.Net.Http.Headers;
using Bible2PPT.Services.BibleService.Http;

namespace Bible2PPT.Services.BibleService.Tests.Http;

public class RetryHandlerTest
{
    private readonly List<TimeSpan> _delays = new();

    private HttpClient CreateClient(StubHandler stub, TimeSpan? attemptTimeout = null) => new(new RetryHandler((delay, _) =>
    {
        _delays.Add(delay);
        return Task.CompletedTask;
    })
    {
        AttemptTimeout = attemptTimeout ?? TimeSpan.FromSeconds(10),
        InnerHandler = stub,
    });

    [Fact]
    public async Task Retries_TransientStatus_UntilSuccess()
    {
        var stub = new StubHandler(HttpStatusCode.ServiceUnavailable, HttpStatusCode.BadGateway, HttpStatusCode.OK);

        using var response = await CreateClient(stub).GetAsync("http://test/");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        stub.Attempts.ShouldBe(3);
        _delays.Count.ShouldBe(2);
    }

    [Fact]
    public async Task Backoff_Grows_WithJitter_AndStopsAtMaxAttempts()
    {
        var stub = new StubHandler(HttpStatusCode.ServiceUnavailable);

        using var response = await CreateClient(stub).GetAsync("http://test/");

        // 마지막 오류 응답은 호출한 쪽에서 처리하도록 그대로 반환
        response.StatusCode.ShouldBe(HttpStatusCode.ServiceUnavailable);
        stub.Attempts.ShouldBe(4);
        _delays.Count.ShouldBe(3);
        // 1초, 2초, 4초에 최대 50%까지 더한 시간
        _delays[0].TotalSeconds.ShouldBeInRange(1, 1.5);
        _delays[1].TotalSeconds.ShouldBeInRange(2, 3);
        _delays[2].TotalSeconds.ShouldBeInRange(4, 6);
    }

    [Theory]
    [InlineData(HttpStatusCode.NotFound)]
    [InlineData(HttpStatusCode.Forbidden)]
    [InlineData(HttpStatusCode.BadRequest)]
    public async Task DoesNotRetry_PermanentStatus(HttpStatusCode statusCode)
    {
        var stub = new StubHandler(statusCode);

        using var response = await CreateClient(stub).GetAsync("http://test/");

        response.StatusCode.ShouldBe(statusCode);
        stub.Attempts.ShouldBe(1);
        _delays.ShouldBeEmpty();
    }

    [Fact]
    public async Task Honors_RetryAfter()
    {
        var stub = new StubHandler(HttpStatusCode.TooManyRequests, HttpStatusCode.OK)
        {
            Configure = r => r.Headers.RetryAfter = new RetryConditionHeaderValue(TimeSpan.FromSeconds(7)),
        };

        using var response = await CreateClient(stub).GetAsync("http://test/");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        _delays.ShouldBe(new[] { TimeSpan.FromSeconds(7) });
    }

    [Fact]
    public async Task GivesUp_WhenRetryAfterTooLong()
    {
        var stub = new StubHandler(HttpStatusCode.TooManyRequests)
        {
            Configure = r => r.Headers.RetryAfter = new RetryConditionHeaderValue(TimeSpan.FromMinutes(10)),
        };

        using var response = await CreateClient(stub).GetAsync("http://test/");

        response.StatusCode.ShouldBe(HttpStatusCode.TooManyRequests);
        stub.Attempts.ShouldBe(1);
        _delays.ShouldBeEmpty();
    }

    [Fact]
    public async Task NetworkError_ThrowsAfterMaxAttempts()
    {
        var stub = new StubHandler { Throw = () => new HttpRequestException("connection refused") };

        await Should.ThrowAsync<HttpRequestException>(() => CreateClient(stub).GetAsync("http://test/"));

        stub.Attempts.ShouldBe(4);
    }

    [Fact]
    public async Task AttemptTimeout_RetriesThenThrowsHttpRequestException()
    {
        var stub = new StubHandler { Hang = true };

        // 시간 초과는 무한 재시도하던 OperationCanceledException이 아니라 HttpRequestException으로 끝나야 함
        var ex = await Should.ThrowAsync<HttpRequestException>(() => CreateClient(stub, TimeSpan.FromMilliseconds(50)).GetAsync("http://test/"));

        ex.InnerException.ShouldBeOfType<TimeoutException>();
        stub.Attempts.ShouldBe(4);
    }

    [Fact]
    public async Task CallerCancellation_IsNotRetried()
    {
        var stub = new StubHandler { Hang = true };
        using var cts = new CancellationTokenSource(TimeSpan.FromMilliseconds(100));

        await Should.ThrowAsync<OperationCanceledException>(() => CreateClient(stub).GetAsync("http://test/", cts.Token));

        stub.Attempts.ShouldBe(1);
    }

    [Fact]
    public async Task PostContent_IsResentOnRetry()
    {
        var stub = new StubHandler(HttpStatusCode.ServiceUnavailable, HttpStatusCode.OK);

        using var response = await CreateClient(stub).PostAsync("http://test/", new FormUrlEncodedContent(new Dictionary<string, string> { ["ver"] = "gae" }));

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        stub.Bodies.ShouldBe(new[] { "ver=gae", "ver=gae" });
    }
}

internal class StubHandler : HttpMessageHandler
{
    private readonly Queue<HttpStatusCode> _statusCodes;
    private readonly HttpStatusCode _last;

    public StubHandler(params HttpStatusCode[] statusCodes)
    {
        _statusCodes = new Queue<HttpStatusCode>(statusCodes);
        _last = statusCodes.LastOrDefault(HttpStatusCode.OK);
    }

    public int Attempts { get; private set; }
    public List<string> Bodies { get; } = new();
    public Action<HttpResponseMessage>? Configure { get; init; }
    public Func<Exception>? Throw { get; init; }
    public bool Hang { get; init; }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        Attempts++;
        if (request.Content is not null)
        {
            Bodies.Add(await request.Content.ReadAsStringAsync(cancellationToken));
        }
        if (Hang)
        {
            await Task.Delay(Timeout.Infinite, cancellationToken);
        }
        if (Throw is not null)
        {
            throw Throw();
        }

        var response = new HttpResponseMessage(_statusCodes.TryDequeue(out var statusCode) ? statusCode : _last);
        Configure?.Invoke(response);
        return response;
    }
}
