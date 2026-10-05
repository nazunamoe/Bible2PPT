using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using Bible2PPT.Bibles;
using Bible2PPT.Services.BibleIndexService;

namespace Bible2PPT.Sources;

public class YouVersionBible : BibleSource
{
    private const string BASE_URL = "https://nodejs.bible.com";

    private static readonly HttpClient client = new()
    {
        BaseAddress = new Uri(BASE_URL),
        Timeout = TimeSpan.FromSeconds(10),
        DefaultRequestHeaders = { { "User-Agent", "Bible2PPT" } },
    };

    // YouVersion 언어 태그 -> 앱에서 사용하는 언어 코드 (GOODTV 성경이 제공하는 언어와 같은 범위)
    private static readonly (string Tag, string LanguageCode)[] Languages =
    {
        ("kor", "ko"),
        ("eng", "en"),
        ("jpn", "ja"),
        ("zho_tw", "zh-tw"),
        ("zho", "zh-cn"),
        ("cmn", "zh-cn"),
        ("heb", "he"),
        ("hbo", "he"),
        ("grc", "el"),
        ("spa", "es"),
    };

    public YouVersionBible()
    {
        Name = "YouVersion 성경";
    }

    // https://www.bible.com 페이지가 사용하는 JSON API의 응답 형식
    private record ApiVersions([property: JsonPropertyName("versions")] List<ApiVersion> Versions);
    private record ApiVersion(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("abbreviation")] string Abbreviation,
        [property: JsonPropertyName("local_title")] string LocalTitle,
        [property: JsonPropertyName("text")] bool Text);
    private record ApiVersionDetail([property: JsonPropertyName("books")] List<ApiBook> Books);
    private record ApiBook(
        [property: JsonPropertyName("usfm")] string Usfm,
        [property: JsonPropertyName("human")] string Human,
        [property: JsonPropertyName("chapters")] List<ApiChapter> Chapters);
    private record ApiChapter([property: JsonPropertyName("canonical")] bool Canonical);
    private record ApiChapterContent([property: JsonPropertyName("content")] string Content);

    public override async Task<List<Bible>> GetBiblesOnlineAsync()
    {
        var results = await Task.WhenAll(Languages.Select(async lang =>
        {
            var response = await client.GetFromJsonAsync<ApiVersions>($"/api/bible/versions/3.1?language_tag={lang.Tag}&type=all").ConfigureAwait(false);
            return response!.Versions.Select(v => (Version: v, lang.LanguageCode));
        })).ConfigureAwait(false);

        return results.SelectMany(x => x)
            .Where(x => x.Version.Text)
            // 여러 언어 태그에 같은 번역본이 중복으로 나올 수 있음 (예: heb, hbo의 WLC)
            .DistinctBy(x => x.Version.Id)
            .Select(x => new Bible
            {
                OnlineId = $"{x.Version.Id}",
                Name = $"{x.Version.LocalTitle.Trim()} ({x.Version.Abbreviation})",
                LanguageCode = x.LanguageCode,
            }).ToList();
    }

    public override async Task<List<Book>> GetBooksOnlineAsync(Bible bible)
    {
        var version = await client.GetFromJsonAsync<ApiVersionDetail>($"/api/bible/version/3.1?id={bible.OnlineId}").ConfigureAwait(false);
        return version!.Books
            // 외경 등 BookKey에 없는 책은 제외
            .Where(i => GetBookKey(i.Usfm) != BookKey.Unknown)
            .Select(i => new Book
            {
                OnlineId = i.Usfm,
                Name = i.Human,
                Key = GetBookKey(i.Usfm),
                // 서론(INTRO) 등 정경 장이 아닌 항목은 장 수에서 제외
                ChapterCount = i.Chapters.Count(c => c.Canonical),
            }).ToList();
    }

    public override Task<List<Chapter>> GetChaptersOnlineAsync(Book book) =>
        Task.FromResult(Enumerable.Range(1, book.ChapterCount)
            .Select(i => new Chapter
            {
                OnlineId = $"{book.OnlineId}.{i}",
                Number = i,
            }).ToList());

    private static readonly Regex HtmlTokenPattern = new(@"<(?<close>/)?(?<tag>\w+)(?<attrs>[^>]*?)(?<self>/)?>|(?<text>[^<]+)", RegexOptions.Compiled);
    private static readonly Regex ClassPattern = new(@"class=""(?<value>[^""]*)""", RegexOptions.Compiled);
    private static readonly Regex VerseUsfmPattern = new(@"data-usfm=""[^"".]+\.\d+\.(?<verse>\d+)", RegexOptions.Compiled);

    public override async Task<List<Verse>> GetVersesOnlineAsync(Chapter chapter)
    {
        var data = await client.GetFromJsonAsync<ApiChapterContent>($"/api/bible/chapter/3.1?id={chapter.Book.Bible.OnlineId}&reference={chapter.OnlineId}").ConfigureAwait(false);
        return ParseVerses(data!.Content);
    }

    /// <summary>
    /// 장 본문 HTML에서 절 번호별 본문을 추출한다.
    /// </summary>
    /// <remarks>
    /// 한 절이 문단이나 시가서의 행 경계에서 같은 data-usfm을 가진 여러 span으로 나뉘어 있으므로 절 번호별로 합친다.
    /// 절 안의 각주(note)와 절 번호(label)는 제외하고 content 부분만 사용한다.
    /// </remarks>
    private static List<Verse> ParseVerses(string html)
    {
        var texts = new SortedDictionary<int, StringBuilder>();
        // 열린 span마다 (verse span이면 절 번호, 본문 수집 여부를 끄는 span인지, content span인지)
        var stack = new Stack<(int? Verse, bool Excluded, bool Content)>();

        foreach (Match m in HtmlTokenPattern.Matches(html))
        {
            if (m.Groups["text"].Success)
            {
                var verse = stack.Select(x => x.Verse).FirstOrDefault(x => x is not null);
                if (verse is int number && stack.Any(x => x.Content) && !stack.Any(x => x.Excluded))
                {
                    if (!texts.TryGetValue(number, out var sb))
                    {
                        texts[number] = sb = new StringBuilder();
                    }
                    sb.Append(WebUtility.HtmlDecode(m.Groups["text"].Value));
                }
                continue;
            }

            if (m.Groups["tag"].Value != "span" || m.Groups["self"].Success)
            {
                // 절 span은 div 경계를 넘지 않으므로 span만 추적하면 됨
                continue;
            }

            if (m.Groups["close"].Success)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
                continue;
            }

            var attrs = m.Groups["attrs"].Value;
            var classes = ClassPattern.Match(attrs).Groups["value"].Value.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int? verseNumber = null;
            if (classes.Contains("verse"))
            {
                // 여러 절이 합쳐진 경우(GEN.1.1+GEN.1.2) 첫 절 번호를 사용
                var usfm = VerseUsfmPattern.Match(attrs);
                if (usfm.Success)
                {
                    verseNumber = int.Parse(usfm.Groups["verse"].Value);
                    // 시가서의 행처럼 이어지는 조각은 줄바꿈 대신 공백으로 구분
                    if (texts.TryGetValue(verseNumber.Value, out var sb))
                    {
                        sb.Append(' ');
                    }
                }
            }
            stack.Push((verseNumber, classes.Contains("note") || classes.Contains("label"), classes.Contains("content")));
        }

        return texts
            .Select(x => new Verse
            {
                Number = x.Key,
                Text = Regex.Replace(x.Value.ToString(), @"\s+", " ").Trim(),
            })
            .Where(x => x.Text.Length > 0)
            .ToList();
    }

    private static BookKey GetBookKey(string usfm) => usfm switch
    {
        "GEN" => BookKey.Genesis,
        "EXO" => BookKey.Exodus,
        "LEV" => BookKey.Leviticus,
        "NUM" => BookKey.Numbers,
        "DEU" => BookKey.Deuteronomy,
        "JOS" => BookKey.Joshua,
        "JDG" => BookKey.Judges,
        "RUT" => BookKey.Ruth,
        "1SA" => BookKey.ISamuel,
        "2SA" => BookKey.IISamuel,
        "1KI" => BookKey.IKings,
        "2KI" => BookKey.IIKings,
        "1CH" => BookKey.IChronicles,
        "2CH" => BookKey.IIChronicles,
        "EZR" => BookKey.Ezra,
        "NEH" => BookKey.Nehemiah,
        "EST" => BookKey.Esther,
        "JOB" => BookKey.Job,
        "PSA" => BookKey.Psalms,
        "PRO" => BookKey.Proverbs,
        "ECC" => BookKey.Ecclesiastes,
        "SNG" => BookKey.SongOfSolomon,
        "ISA" => BookKey.Isaiah,
        "JER" => BookKey.Jeremiah,
        "LAM" => BookKey.Lamentations,
        "EZK" => BookKey.Ezekiel,
        "DAN" => BookKey.Daniel,
        "HOS" => BookKey.Hosea,
        "JOL" => BookKey.Joel,
        "AMO" => BookKey.Amos,
        "OBA" => BookKey.Obadiah,
        "JON" => BookKey.Jonah,
        "MIC" => BookKey.Micah,
        "NAM" => BookKey.Nahum,
        "HAB" => BookKey.Habakkuk,
        "ZEP" => BookKey.Zephaniah,
        "HAG" => BookKey.Haggai,
        "ZEC" => BookKey.Zechariah,
        "MAL" => BookKey.Malachi,
        "MAT" => BookKey.Matthew,
        "MRK" => BookKey.Mark,
        "LUK" => BookKey.Luke,
        "JHN" => BookKey.John,
        "ACT" => BookKey.Acts,
        "ROM" => BookKey.Romans,
        "1CO" => BookKey.ICorinthians,
        "2CO" => BookKey.IICorinthians,
        "GAL" => BookKey.Galatians,
        "EPH" => BookKey.Ephesians,
        "PHP" => BookKey.Philippians,
        "COL" => BookKey.Colossians,
        "1TH" => BookKey.IThessalonians,
        "2TH" => BookKey.IIThessalonians,
        "1TI" => BookKey.ITimothy,
        "2TI" => BookKey.IITimothy,
        "TIT" => BookKey.Titus,
        "PHM" => BookKey.Philemon,
        "HEB" => BookKey.Hebrews,
        "JAS" => BookKey.James,
        "1PE" => BookKey.IPeter,
        "2PE" => BookKey.IIPeter,
        "1JN" => BookKey.IJohn,
        "2JN" => BookKey.IIJohn,
        "3JN" => BookKey.IIIJohn,
        "JUD" => BookKey.Jude,
        "REV" => BookKey.Revelation,
        _ => BookKey.Unknown,
    };
}
