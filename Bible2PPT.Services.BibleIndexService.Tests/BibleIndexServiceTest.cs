using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Bible2PPT.Services.BibleIndexService.Tests;

public class BibleIndexServiceTest : IDisposable
{
    private static readonly string[] LanguageCodes = { "ko", "en", "ja", "zh-cn", "zh-tw", "es" };

    private readonly SqliteConnection _keepAlive;
    private readonly IServiceProvider _serviceProvider;

    public BibleIndexServiceTest()
    {
        var connectionString = $"Data Source=file:index{Guid.NewGuid():N}?mode=memory&cache=shared";
        // 마지막 연결이 닫히면 메모리 DB가 사라지므로 테스트가 끝날 때까지 연결을 유지
        _keepAlive = new SqliteConnection(connectionString);
        _keepAlive.Open();

        var services = new ServiceCollection();
        services.AddBibleIndexService(options => options.UseSqlite(connectionString));
        _serviceProvider = services.BuildServiceProvider();
        _serviceProvider.UseBibleIndexService();
    }

    public void Dispose() => _keepAlive.Dispose();

    private BibleIndexService Service => _serviceProvider.GetRequiredService<BibleIndexService>();
    private VerseQueryParser Parser => _serviceProvider.GetRequiredService<VerseQueryParser>();

    private List<BookInfo> AllBookInfos()
    {
        using var db = _serviceProvider.GetRequiredService<IDbContextFactory<BibleIndexContext>>().CreateDbContext();
        return db.BookInfos.ToList();
    }

    [Theory]
    [InlineData("en")]
    [InlineData("ja")]
    [InlineData("zh-cn")]
    [InlineData("zh-tw")]
    [InlineData("es")]
    public void Seed_HasNameAndAbbreviation_ForAll66Books(string languageCode)
    {
        var infos = AllBookInfos().Where(x => x.LanguageCode == languageCode).ToList();

        infos.Count(x => x.Kind == BookInfoKind.Name).ShouldBe(66);
        infos.Count(x => x.Kind == BookInfoKind.Abbreviation).ShouldBe(66);
        infos.Select(x => x.Key).Distinct().Count().ShouldBe(66);
    }

    [Fact]
    public void Seed_Abbreviations_AreUnambiguousAcrossLanguages()
    {
        // 구절 입력 칸의 약자는 언어와 관계없이 찾으므로 같은 약자가 다른 책을 가리키면 해석할 수 없음
        var ambiguous = AllBookInfos()
            .Where(x => x.Kind == BookInfoKind.Abbreviation)
            .GroupBy(x => x.Value.ToLowerInvariant())
            .Where(g => g.Select(x => x.Key).Distinct().Count() > 1)
            .Select(g => $"{g.Key}: {string.Join(", ", g.Select(x => $"{x.LanguageCode} {x.Key}"))}")
            .ToList();

        ambiguous.ShouldBeEmpty();
    }

    [Fact]
    public void Seed_Abbreviations_HaveNoWhitespace()
    {
        // 구절 입력 칸은 공백으로 구절을 구분함
        AllBookInfos()
            .Where(x => x.Kind == BookInfoKind.Abbreviation && x.Value.Any(char.IsWhiteSpace))
            .ShouldBeEmpty();
    }

    [Theory]
    [InlineData("ko", BookKey.John, "요한복음", "요")]
    [InlineData("en", BookKey.John, "John", "John")]
    [InlineData("en", BookKey.SongOfSolomon, "Song of Songs", "Song")]
    [InlineData("ja", BookKey.John, "ヨハネによる福音書", "ヨハ")]
    [InlineData("zh-cn", BookKey.John, "约翰福音", "约")]
    [InlineData("zh-tw", BookKey.John, "約翰福音", "約")]
    [InlineData("es", BookKey.John, "Juan", "Jn")]
    public void Lookup_ByLanguage(string languageCode, BookKey key, string name, string abbreviation)
    {
        Service.FindBookName(key, languageCode).ShouldBe(name);
        Service.GetBookAbbreviation(key, languageCode).ShouldBe(abbreviation);
    }

    [Theory]
    [InlineData("he")]
    [InlineData("el")]
    public void Lookup_LanguageWithoutData(string languageCode)
    {
        // 이름은 성경 소스의 이름을 쓰도록 null, 약자는 구절 입력 칸에서 해석할 수 있는 기본 언어 약자
        Service.FindBookName(BookKey.Genesis, languageCode).ShouldBeNull();
        Service.GetBookAbbreviation(BookKey.Genesis, languageCode).ShouldBe("창");
    }

    [Theory]
    [InlineData("요3:16", BookKey.John)]
    [InlineData("John3:16", BookKey.John)]
    [InlineData("john3:16", BookKey.John)]
    [InlineData("JOHN3:16", BookKey.John)]
    [InlineData("1John1", BookKey.IJohn)]
    [InlineData("Judg1", BookKey.Judges)]
    [InlineData("Jude1", BookKey.Jude)]
    [InlineData("Jonah1", BookKey.Jonah)]
    [InlineData("Ezra1", BookKey.Ezra)]
    [InlineData("ヨハ3:16", BookKey.John)]
    [InlineData("一ヨハ1", BookKey.IJohn)]
    [InlineData("雅歌1", BookKey.SongOfSolomon)]
    [InlineData("约3:16", BookKey.John)]
    [InlineData("约一1", BookKey.IJohn)]
    [InlineData("約3:16", BookKey.John)]
    [InlineData("雅1", BookKey.James)]
    [InlineData("Jn3:16", BookKey.John)]
    [InlineData("1Jn1", BookKey.IJohn)]
    [InlineData("Gá1", BookKey.Galatians)]
    public void Parse_AbbreviationOfEachLanguage(string query, BookKey key)
    {
        Parser.ParseVerseQueries(query).Single().BookKey.ShouldBe(key);
    }
}
