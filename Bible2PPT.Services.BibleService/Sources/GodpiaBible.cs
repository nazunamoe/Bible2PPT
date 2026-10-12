using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;
using Bible2PPT.Bibles;
using Bible2PPT.Services.BibleIndexService;
using Bible2PPT.Services.BibleService.Http;

namespace Bible2PPT.Sources;

public class GodpiaBible : BibleSource
{
    private const string BASE_URL = "https://www.godpia.com";

    private static readonly HttpClient client = BibleSourceHttpClient.Create(BASE_URL);

    public GodpiaBible()
    {
        Name = "갓피아 성경";
    }

    // 성경 목록과 책 목록이 같은 페이지에 있으므로 한 번 받은 페이지를 잠시 재사용
    private static readonly TimeSpan ReadingPageLifetime = TimeSpan.FromMinutes(10);
    private static readonly object ReadingPageLock = new();
    private static Task<string>? readingPage;
    private static DateTime readingPageExpiresAt;

    private static Task<string> GetReadingPageAsync()
    {
        lock (ReadingPageLock)
        {
            // 실패한 요청은 재사용하지 않고 다시 요청
            if (readingPage is null || readingPage.IsFaulted || readingPage.IsCanceled || DateTime.UtcNow >= readingPageExpiresAt)
            {
                readingPage = client.GetStringAsync("/read/reading.asp");
                readingPageExpiresAt = DateTime.UtcNow + ReadingPageLifetime;
            }
            return readingPage;
        }
    }

    private static async Task<string> PostFormAsync(string requestUri, Dictionary<string, string> form)
    {
        using var response = await client.PostAsync(requestUri, new FormUrlEncodedContent(form)).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
    }

    public override async Task<List<Bible>> GetBiblesOnlineAsync()
    {
        // 성경 읽기 페이지의 번역본 선택 버튼 (1번 화면 기준, 빈 값은 '미선택')
        var data = await GetReadingPageAsync().ConfigureAwait(false);
        var matches = Regex.Matches(data, @"for=""btn-check-1-(\w+)"">(.+?)</");
        return matches.Select(i => new Bible
        {
            OnlineId = i.Groups[1].Value,
            Name = i.Groups[2].Value.Trim(),
        }).Select(x => x with { LanguageCode = GetLanguageCode(x) }).ToList();
    }

    public override async Task<List<Book>> GetBooksOnlineAsync(Bible bible)
    {
        // 책 목록은 번역본과 관계없이 같은 66권이 표시됨
        var data = await GetReadingPageAsync().ConfigureAwait(false);
        var matches = Regex.Matches(data, @"for=""btn-check-([0-9a-z]{3})"">(.+?)</");
        return matches.Select(i => new Book
        {
            OnlineId = i.Groups[1].Value,
            Name = i.Groups[2].Value.Trim(),
        })
            .Select(x => x with { Key = GetBookKey(x) })
            .Where(x => x.Key != BookKey.Unknown)
            // 원어 성경은 구약(히브리어) 또는 신약(헬라어)만 본문이 있음
            .Where(x => bible.OnlineId switch
            {
                "hebrew" => x.Key < BookKey.Matthew,
                "greek" => x.Key >= BookKey.Matthew,
                _ => true,
            })
            .ToList();
    }

    public override async Task<List<Chapter>> GetChaptersOnlineAsync(Book book)
    {
        var data = await PostFormAsync("/include/asp/chapinfo.asp", new()
        {
            ["vercode"] = book.Bible.OnlineId,
            ["volcode"] = book.OnlineId,
            ["chap"] = "1",
        }).ConfigureAwait(false);
        var matches = Regex.Matches(data, @"name=""chapname""[^>]*value=""(\d+)""");
        return matches.Select(i => new Chapter
        {
            OnlineId = i.Groups[1].Value,
            Number = int.Parse(i.Groups[1].Value, CultureInfo.InvariantCulture),
        }).ToList();
    }

    private static string StripHtmlTags(string s) => Regex.Replace(s, @"<.+?>", "", RegexOptions.Singleline);

    public override async Task<List<Verse>> GetVersesOnlineAsync(Chapter chapter)
    {
        var data = await PostFormAsync("/read/reading_body.asp", new()
        {
            ["ver"] = chapter.Book.Bible.OnlineId,
            ["vol"] = chapter.Book.OnlineId,
            ["chap"] = chapter.OnlineId,
        }).ConfigureAwait(false);
        // 본문에 포함된 성경 사전 링크(span) 등의 태그는 제거
        var matches = Regex.Matches(data, @"dataSec=""(\d+)"".*?<span class=""bible-read-cont\s*"">(.*?)</span>\s*</li>", RegexOptions.Singleline);
        return matches.Select(i => new Verse
        {
            Number = int.Parse(i.Groups[1].Value, CultureInfo.InvariantCulture),
            Text = Regex.Replace(WebUtility.HtmlDecode(StripHtmlTags(i.Groups[2].Value)), @"\s+", " ").Trim(),
        }).ToList();
    }

    private static string GetLanguageCode(Bible bible) => bible.OnlineId switch
    {
        "gae" or "han" or "easy" or "hyun" or "saenew" => "ko",
        "niv" => "en",
        "hebrew" => "he",
        "greek" => "el",
        // 새로 추가된 번역본 때문에 성경 목록 전체를 못 불러오는 일이 없도록 기본값 사용
        _ => "ko",
    };

    private static BookKey GetBookKey(Book book) => book.OnlineId switch
    {
        "gen" => BookKey.Genesis,
        "exo" => BookKey.Exodus,
        "lev" => BookKey.Leviticus,
        "num" => BookKey.Numbers,
        "deu" => BookKey.Deuteronomy,
        "jos" => BookKey.Joshua,
        "jdg" => BookKey.Judges,
        "rut" => BookKey.Ruth,
        "1sa" => BookKey.ISamuel,
        "2sa" => BookKey.IISamuel,
        "1ki" => BookKey.IKings,
        "2ki" => BookKey.IIKings,
        "1ch" => BookKey.IChronicles,
        "2ch" => BookKey.IIChronicles,
        "ezr" => BookKey.Ezra,
        "neh" => BookKey.Nehemiah,
        "est" => BookKey.Esther,
        "job" => BookKey.Job,
        "psa" => BookKey.Psalms,
        "pro" => BookKey.Proverbs,
        "ecc" => BookKey.Ecclesiastes,
        "sng" => BookKey.SongOfSolomon,
        "isa" => BookKey.Isaiah,
        "jer" => BookKey.Jeremiah,
        "lam" => BookKey.Lamentations,
        "ezk" => BookKey.Ezekiel,
        "dan" => BookKey.Daniel,
        "hos" => BookKey.Hosea,
        "jol" => BookKey.Joel,
        "amo" => BookKey.Amos,
        "oba" => BookKey.Obadiah,
        "jnh" => BookKey.Jonah,
        "mic" => BookKey.Micah,
        "nam" => BookKey.Nahum,
        "hab" => BookKey.Habakkuk,
        "zep" => BookKey.Zephaniah,
        "hag" => BookKey.Haggai,
        "zec" => BookKey.Zechariah,
        "mal" => BookKey.Malachi,
        "mat" => BookKey.Matthew,
        "mrk" => BookKey.Mark,
        "luk" => BookKey.Luke,
        "jhn" => BookKey.John,
        "act" => BookKey.Acts,
        "rom" => BookKey.Romans,
        "1co" => BookKey.ICorinthians,
        "2co" => BookKey.IICorinthians,
        "gal" => BookKey.Galatians,
        "eph" => BookKey.Ephesians,
        "php" => BookKey.Philippians,
        "col" => BookKey.Colossians,
        "1th" => BookKey.IThessalonians,
        "2th" => BookKey.IIThessalonians,
        "1ti" => BookKey.ITimothy,
        "2ti" => BookKey.IITimothy,
        "tit" => BookKey.Titus,
        "phm" => BookKey.Philemon,
        "heb" => BookKey.Hebrews,
        "jas" => BookKey.James,
        "1pe" => BookKey.IPeter,
        "2pe" => BookKey.IIPeter,
        "1jn" => BookKey.IJohn,
        "2jn" => BookKey.IIJohn,
        "3jn" => BookKey.IIIJohn,
        "jud" => BookKey.Jude,
        "rev" => BookKey.Revelation,
        _ => BookKey.Unknown,
    };
}
