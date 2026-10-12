using Microsoft.EntityFrameworkCore;

namespace Bible2PPT.Services.BibleIndexService;

public class BibleIndexService
{
    /// <summary>
    /// 책 정보가 없는 언어의 성경에서 사용할 언어
    /// </summary>
    public const string DefaultLanguageCode = "ko";

    private readonly IDbContextFactory<BibleIndexContext> _dbFactory;

    public BibleIndexService(IDbContextFactory<BibleIndexContext> dbFactory)
    {
        _dbFactory = dbFactory;
    }

    public BookInfo GetBookInfo(BookKey key, string languageCode)
    {
        using var db = _dbFactory.CreateDbContext();
        return db.BookInfos
            .Where(x => (x.Key == key) && (x.LanguageCode == languageCode))
            .OrderByDescending(x => x.IsPrimary)
            .First();
    }

    /// <summary>
    /// 성경 언어의 책 이름을 찾는다. 해당 언어의 책 정보가 없으면 null을 반환한다.
    /// </summary>
    /// <remarks>
    /// 책 이름은 성경 소스가 제공하는 이름으로 대신할 수 있으므로 다른 언어로 대체하지 않는다.
    /// </remarks>
    public string? FindBookName(BookKey key, string languageCode)
    {
        using var db = _dbFactory.CreateDbContext();

        return db.BookInfos
            .Where(x => x.Key == key && x.LanguageCode == languageCode && x.Kind == BookInfoKind.Name)
            .OrderByDescending(x => x.IsPrimary)
            .Select(x => x.Value)
            .FirstOrDefault();
    }

    public string GetBookAbbreviation(BookKey key, string languageCode)
    {
        using var db = _dbFactory.CreateDbContext();

        return GetBookInfoCandidates(db, key, languageCode)
            .Where(x => x.Kind == BookInfoKind.Abbreviation)
            .OrderByDescending(x => x.IsPrimary)
            .First()
            .Value;
    }

    public void AddBookInfos(IEnumerable<BookInfo> bookInfos)
    {
        using var db = _dbFactory.CreateDbContext();
        db.BookInfos.AddRange(bookInfos);
    }

    public BookInfo? FindBookInfoExactAbbreviation(string abbr)
    {
        using var db = _dbFactory.CreateDbContext();

        // 영어, 스페인어 약자는 대소문자를 구분하지 않음 (예: john3:16)
        var lowerAbbr = abbr.ToLowerInvariant();
        var infos = db.BookInfos.Where(x => x.Kind == BookInfoKind.Abbreviation && x.Value.ToLower() == lowerAbbr);
        if (infos.Select(x => x.Key).Distinct().Count() != 1)
        {
            return null;
        }

        return infos.First();
    }

    private static IQueryable<BookInfo> GetBookInfoCandidates(BibleIndexContext db, BookKey key, string languageCode)
    {
        var bookInfo = db.BookInfos.Where(x => x.Key == key);

        var languageMatches = bookInfo.Where(x => x.LanguageCode == languageCode);
        if (!languageMatches.Any())
        {
            // 구절 입력 칸에 넣는 약자는 해석할 수 있어야 하므로 기본 언어의 약자를 사용
            return bookInfo.Where(x => x.LanguageCode == DefaultLanguageCode);
        }

        return languageMatches;
    }
}
