using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;
using Bible2PPT.Bibles;
using Bible2PPT.Extensions;
using Bible2PPT.Services.BibleIndexService;

namespace Bible2PPT.Sources;

public class GoodtvBible : BibleSource
{
    private const string BASE_URL = "https://goodtvbible.goodtv.co.kr";

    private static readonly HttpClient client = new()
    {
        BaseAddress = new Uri(BASE_URL),
        Timeout = TimeSpan.FromSeconds(5),
    };

    public GoodtvBible()
    {
        Name = "GOODTV 성경";
    }

    public override async Task<List<Bible>> GetBiblesOnlineAsync()
    {
        var data = await client.GetStringAsync("/api/onlinebible/bibleread/versions").ConfigureAwait(false);
        var matches = Regex.Matches(data, @"{""version"":(\d+),""name"":""(.+?)""}");

        return matches.Cast<Match>().Select(i => new Bible
        {
            OnlineId = i.Groups[1].Value,
            Name = i.Groups[2].Value,
        }).Select(x => x with { LanguageCode = GetLanguageCode(x) }).ToList();
    }

    public override async Task<List<Book>> GetBooksOnlineAsync(Bible bible)
    {
        var data = await client.GetStringAsync($"api/onlinebible/bibleread/volumes/all?version=0").ConfigureAwait(false);
        Console.WriteLine(data);
        var matches = Regex.Matches(data, @"{""bible_code"":(\d+),""bookname"":""(.+?)"",""max_jang"":(\d+),""eng_abb"":""(.+?)"",""testament"":""(.+?)""}");
        return matches.Cast<Match>().Select(i => new Book
        {
            OnlineId = i.Groups[1].Value,
            Name = i.Groups[2].Value,
            ChapterCount = int.Parse(i.Groups[3].Value, CultureInfo.InvariantCulture),
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
        var data = await client.GetStringAsync($"api/onlinebible/bibleread/read-all?version1={chapter.Book.Bible.OnlineId}&bible_code={chapter.Book.OnlineId}&jang={chapter.Number}").ConfigureAwait(false);
        var matches = Regex.Matches(data, @"{""jul"":(\d+),""text"":""(.*?)"".*?}");
        return matches.Cast<Match>().Select(i => new Verse
        {
            Number = int.Parse(i.Groups[1].Value, CultureInfo.InvariantCulture),
            Text = i.Groups[2].Value,
        }).ToList();
    }

    private static string GetLanguageCode(Bible bible) => bible.OnlineId switch
    {
        "0" or "1" or "2" or "3" or "4" or "5" or "7" or "16" => "ko",
        "6" or "13" or "14" => "en",
        "10" or "15" => "ja",
        "12" => "zh-tw",
        "11" => "zh-cn",
        "8" => "he",
        "9" => "el",
        "19" => "es",
        _ => throw new NotImplementedException(),
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
