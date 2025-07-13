using System.Globalization;
using System.Text.RegularExpressions;
using Bible2PPT.Bibles;
using Bible2PPT.Services.BibleIndexService;

namespace Bible2PPT.Sources;

public class GodpiaBible : BibleSource
{
    private const string BASE_URL = "https://www.godpia.com";

    private static readonly HttpClient client = new()
    {
        BaseAddress = new Uri(BASE_URL),
        Timeout = TimeSpan.FromSeconds(5),
    };

    public GodpiaBible()
    {
        Name = "갓피아 성경";
    }

    public override async Task<List<Bible>> GetBiblesOnlineAsync()
    {
        var data = await client.GetStringAsync($"/read/reading.asp").ConfigureAwait(false);
        Console.WriteLine(data);
        var matches = Regex.Matches(data, @"<label class=""btn btn-outline-primary mod"" for=""btn-check-1-[a-zA-Z][^""]*"">.*?</label>");
        return matches.Cast<Match>().Select(i => new Bible
        {
            OnlineId = Regex.Match(i.Value, @"btn-check-1-([a-zA-Z]+)").Groups[1].Value,
            Name = StripHtmlTags(Regex.Match(i.Value, @">([^<]+)<").Groups[1].Value),
        }).Select(x => x with { LanguageCode = GetLanguageCode(x) }).ToList();
    }

    public override async Task<List<Book>> GetBooksOnlineAsync(Bible bible)
    {
        var data = await client.GetStringAsync($"/read/reading.asp").ConfigureAwait(false);
        var matches = Regex.Matches(data, @"<label class=""btn btn-outline-primary mod"" for=""btn-check-[0-9a-zA-Z]{3}"">.*?</label>");
        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }
        var result = matches.Cast<Match>().Select(i => new Book
        {
            OnlineId = Regex.Match(i.Value, @"btn-check-([0-9a-zA-Z]+)").Groups[1].Value,
            Name = StripHtmlTags(Regex.Match(i.Value, @">([^<]+)<").Groups[1].Value),
        }).Select(x => x with { Key = GetBookKey(x) }).ToList();
        return result;
    }

    public override async Task<List<Chapter>> GetChaptersOnlineAsync(Book book)
    {
        var data = await client.GetStringAsync($"/include/asp/chapinfo.asp?vercode={book.Bible.OnlineId}&volcode={book.OnlineId}").ConfigureAwait(false);
        var matches = Regex.Matches(data, @"id-btn-chap-(\d+)");
        return matches.Cast<Match>().Select(i => new Chapter
        {
            OnlineId = book.OnlineId,
            Number = int.Parse(Regex.Match(i.Value, @"id-btn-chap-(\d+)").Groups[1].Value, CultureInfo.InvariantCulture),
        }).ToList();
    }

    private static string StripHtmlTags(string s) => Regex.Replace(s, @"<.+?>", "", RegexOptions.Singleline);

    public override async Task<List<Verse>> GetVersesOnlineAsync(Chapter chapter)
    {
        var data = await client.GetStringAsync($"/read/reading_body.asp?ver={chapter.Book.Bible.OnlineId}&vol={chapter.Book.OnlineId}&chap={chapter.Number}").ConfigureAwait(false);
        var matches = Regex.Matches(data, @"<li.*?dataSec=""(\d+)"">.*?<span class=""bible-read-cont "".*?>(.*?)</li>");
        return matches.Cast<Match>().Select(i => new Verse
        {
            Number = int.Parse(i.Groups[1].Value, CultureInfo.InvariantCulture),
            Text = StripHtmlTags(i.Groups[2].Value),
        }).ToList();
    }

    private static string GetLanguageCode(Bible bible) => bible.OnlineId switch
    {
        "gae" or "han" or "easy" or "cognew" or "hyun" or "saenew" => "ko",
        "niv" => "en",
        "hebrew" => "he",
        "greek" => "el",
        _ => throw new NotImplementedException(),
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
        _ => throw new NotImplementedException(),
    };
}
