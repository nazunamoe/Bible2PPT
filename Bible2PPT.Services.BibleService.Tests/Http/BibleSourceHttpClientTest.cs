using System.Net;
using Bible2PPT.Services.BibleService.Http;

namespace Bible2PPT.Services.BibleService.Tests.Http;

public class BibleSourceHttpClientTest
{
    [Fact]
    public void Handler_RetriesOutsideRateLimit_AndRequestsCompressedResponses()
    {
        var retry = BibleSourceHttpClient.CreateHandler().ShouldBeOfType<RetryHandler>();
        var rateLimit = retry.InnerHandler.ShouldBeOfType<RateLimitHandler>();
        var connection = rateLimit.InnerHandler.ShouldBeOfType<SocketsHttpHandler>();

        connection.AutomaticDecompression.ShouldBe(DecompressionMethods.All);
    }

    [Fact]
    public void Client_KeepsUserAgent()
    {
        using var client = BibleSourceHttpClient.Create("https://example.com");

        // GOODTV는 User-Agent가 없으면 403으로 응답함
        client.DefaultRequestHeaders.UserAgent.ToString().ShouldBe("Bible2PPT");
        client.BaseAddress.ShouldBe(new Uri("https://example.com"));
    }
}
