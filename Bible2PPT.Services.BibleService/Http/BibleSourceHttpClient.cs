using System.Net;

namespace Bible2PPT.Services.BibleService.Http;

/// <summary>
/// 성경 소스 서버에 부담을 덜 주도록 설정한 HttpClient를 만든다.
/// </summary>
public static class BibleSourceHttpClient
{
    /// <summary>한 성경 소스에 보내는 요청 사이의 최소 간격</summary>
    public static readonly TimeSpan MinRequestInterval = TimeSpan.FromMilliseconds(500);

    public static HttpClient Create(string baseAddress) => new(CreateHandler())
    {
        BaseAddress = new Uri(baseAddress),
        // 요청마다의 시간 제한은 RetryHandler가 처리하므로 재시도와 대기를 모두 포함한 전체 시간 제한만 둠
        Timeout = TimeSpan.FromMinutes(3),
        // GOODTV는 User-Agent 헤더가 없으면 403 Forbidden으로 응답함
        DefaultRequestHeaders = { { "User-Agent", "Bible2PPT" } },
    };

    /// <summary>
    /// 재시도 → 소스별 요청 간격 제한 → 압축 응답을 받는 연결 순서로 처리하는 핸들러를 만든다.
    /// </summary>
    /// <remarks>
    /// 재시도가 간격 제한 바깥에 있어야 재시도한 요청도 간격 제한을 받는다.
    /// </remarks>
    public static HttpMessageHandler CreateHandler() => new RetryHandler
    {
        InnerHandler = new RateLimitHandler(MinRequestInterval)
        {
            // gzip, brotli 압축 응답을 받아서 서버가 보내는 데이터 양을 줄임
            InnerHandler = new SocketsHttpHandler { AutomaticDecompression = DecompressionMethods.All },
        },
    };
}
