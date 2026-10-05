using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using Bible2PPT.Bibles;
using Bible2PPT.Services.BibleIndexService;

namespace Bible2PPT.Sources;

public class GoodtvBible : BibleSource
{
    private const string BASE_URL = "https://api.goodtv.co.kr";

    private static readonly HttpClient client = new()
    {
        BaseAddress = new Uri(BASE_URL),
        Timeout = TimeSpan.FromSeconds(10),
        // User-Agent 헤더가 없으면 403 Forbidden으로 응답함
        DefaultRequestHeaders = { { "User-Agent", "Bible2PPT" } },
    };

    public GoodtvBible()
    {
        Name = "GOODTV 성경";
    }

    // https://goodtvbible.goodtv.co.kr/onbibleread 페이지가 사용하는 JSON API의 응답 형식
    private record ApiResponse<T>([property: JsonPropertyName("data")] T Data);
    private record ApiVersion([property: JsonPropertyName("version")] int Version, [property: JsonPropertyName("name")] string Name);
    private record ApiVolume([property: JsonPropertyName("bible_code")] int BibleCode, [property: JsonPropertyName("bookname")] string BookName, [property: JsonPropertyName("max_jang")] int MaxJang);
    private record ApiReadAll([property: JsonPropertyName("data")] ApiReadAllData Data);
    private record ApiReadAllData([property: JsonPropertyName("version1")] ApiReadAllVersion Version1);
    private record ApiReadAllVersion([property: JsonPropertyName("content")] List<ApiVerse>? Content);
    private record ApiVerse([property: JsonPropertyName("jul")] int Jul, [property: JsonPropertyName("text")] string? Text);

    private static async Task<T> GetDataAsync<T>(string requestUri)
    {
        var response = await client.GetFromJsonAsync<ApiResponse<T>>(requestUri).ConfigureAwait(false);
        return response!.Data;
    }

    public override async Task<List<Bible>> GetBiblesOnlineAsync()
    {
        var versions = await GetDataAsync<List<ApiVersion>>("/onlinebible/bibleread/versions").ConfigureAwait(false);
        return versions.Select(i => new Bible
        {
            OnlineId = $"{i.Version}",
            Name = i.Name,
        }).Select(x => x with { LanguageCode = GetLanguageCode(x) }).ToList();
    }

    public override async Task<List<Book>> GetBooksOnlineAsync(Bible bible)
    {
        var volumes = await GetDataAsync<List<ApiVolume>>($"/onlinebible/bibleread/volumes/all?version={bible.OnlineId}").ConfigureAwait(false);
        return volumes.Select(i => new Book
        {
            OnlineId = $"{i.BibleCode}",
            Name = i.BookName,
            ChapterCount = i.MaxJang,
        }).Select(x => x with { Key = GetBookKey(x) }).ToList();
    }

    public override Task<List<Chapter>> GetChaptersOnlineAsync(Book book) =>
        Task.FromResult(Enumerable.Range(1, book.ChapterCount)
            .Select(i => new Chapter
            {
                OnlineId = $"{i}",
                Number = i,
            }).ToList());

    private static string StripHtmlTags(string s) => Regex.Replace(s, @"<.+?>", "", RegexOptions.Singleline);

    public override async Task<List<Verse>> GetVersesOnlineAsync(Chapter chapter)
    {
        var data = await GetDataAsync<ApiReadAll>($"/onlinebible/bibleread/read-all?version1={chapter.Book.Bible.OnlineId}&bible_code={chapter.Book.OnlineId}&jang={chapter.OnlineId}").ConfigureAwait(false);
        return (data.Data.Version1.Content ?? new List<ApiVerse>()).Select(i => new Verse
        {
            Number = i.Jul,
            // 시가서 등의 본문에 포함된 줄바꿈은 슬라이드에서 공백으로 표시
            Text = Regex.Replace(StripHtmlTags(i.Text ?? ""), @"\s*\n\s*", " ").Trim(),
        }).ToList();
    }

    private static string GetLanguageCode(Bible bible) => bible.OnlineId switch
    {
        "0" or "1" or "2" or "3" or "4" or "7" or "16" or "20" => "ko",
        "5" or "6" or "13" or "14" => "en",
        "10" or "15" => "ja",
        "11" => "zh-tw",
        "12" => "zh-cn",
        "8" => "he",
        "9" => "el",
        "19" => "es",
        // 새로 추가된 번역본 때문에 성경 목록 전체를 못 불러오는 일이 없도록 기본값 사용
        _ => "ko",
    };

    private static BookKey GetBookKey(Book book) => book.OnlineId switch
    {
        "1" => BookKey.Genesis,
        "2" => BookKey.Exodus,
        "3" => BookKey.Leviticus,
        "4" => BookKey.Numbers,
        "5" => BookKey.Deuteronomy,
        "6" => BookKey.Joshua,
        "7" => BookKey.Judges,
        "8" => BookKey.Ruth,
        "9" => BookKey.ISamuel,
        "10" => BookKey.IISamuel,
        "11" => BookKey.IKings,
        "12" => BookKey.IIKings,
        "13" => BookKey.IChronicles,
        "14" => BookKey.IIChronicles,
        "15" => BookKey.Ezra,
        "16" => BookKey.Nehemiah,
        "17" => BookKey.Esther,
        "18" => BookKey.Job,
        "19" => BookKey.Psalms,
        "20" => BookKey.Proverbs,
        "21" => BookKey.Ecclesiastes,
        "22" => BookKey.SongOfSolomon,
        "23" => BookKey.Isaiah,
        "24" => BookKey.Jeremiah,
        "25" => BookKey.Lamentations,
        "26" => BookKey.Ezekiel,
        "27" => BookKey.Daniel,
        "28" => BookKey.Hosea,
        "29" => BookKey.Joel,
        "30" => BookKey.Amos,
        "31" => BookKey.Obadiah,
        "32" => BookKey.Jonah,
        "33" => BookKey.Micah,
        "34" => BookKey.Nahum,
        "35" => BookKey.Habakkuk,
        "36" => BookKey.Zephaniah,
        "37" => BookKey.Haggai,
        "38" => BookKey.Zechariah,
        "39" => BookKey.Malachi,
        "40" => BookKey.Matthew,
        "41" => BookKey.Mark,
        "42" => BookKey.Luke,
        "43" => BookKey.John,
        "44" => BookKey.Acts,
        "45" => BookKey.Romans,
        "46" => BookKey.ICorinthians,
        "47" => BookKey.IICorinthians,
        "48" => BookKey.Galatians,
        "49" => BookKey.Ephesians,
        "50" => BookKey.Philippians,
        "51" => BookKey.Colossians,
        "52" => BookKey.IThessalonians,
        "53" => BookKey.IIThessalonians,
        "54" => BookKey.ITimothy,
        "55" => BookKey.IITimothy,
        "56" => BookKey.Titus,
        "57" => BookKey.Philemon,
        "58" => BookKey.Hebrews,
        "59" => BookKey.James,
        "60" => BookKey.IPeter,
        "61" => BookKey.IIPeter,
        "62" => BookKey.IJohn,
        "63" => BookKey.IIJohn,
        "64" => BookKey.IIIJohn,
        "65" => BookKey.Jude,
        "66" => BookKey.Revelation,
        _ => throw new NotImplementedException(),
    };
}
