using Bible2PPT.Bibles;
using Bible2PPT.Services.BibleIndexService;
using Bible2PPT.Sources;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Bible2PPT.Services.BibleService.Tests;

public class BibleServiceTest : IDisposable
{
    private readonly SqliteConnection _keepAlive;
    private readonly BibleService _bibleService;
    private readonly FakeSource _source = new();

    public BibleServiceTest()
    {
        var name = Guid.NewGuid().ToString("N");
        var bibleDb = $"Data Source=file:bible{name}?mode=memory&cache=shared";
        // 마지막 연결이 닫히면 메모리 DB가 사라지므로 테스트가 끝날 때까지 연결을 유지
        _keepAlive = new SqliteConnection(bibleDb);
        _keepAlive.Open();

        var services = new ServiceCollection();
        services.AddBibleIndexService(o => o.UseSqlite($"Data Source=file:index{name}?mode=memory&cache=shared"));
        services.AddBibleService(o => o.UseSqlite(bibleDb));
        var serviceProvider = services.BuildServiceProvider();
        serviceProvider.UseBibleIndexService();
        serviceProvider.UseBibleService();
        _bibleService = serviceProvider.GetRequiredService<BibleService>();
    }

    public void Dispose() => _keepAlive.Dispose();

    private async Task<Chapter> GetChapterAsync()
    {
        var bible = (await _bibleService.GetBiblesAsync(_source)).Single();
        var book = (await _bibleService.GetBooksAsync(bible)).Single();
        return (await _bibleService.GetChaptersAsync(book)).Single();
    }

    [Fact]
    public async Task EmptyVerses_AreNotRequestedAgain()
    {
        var chapter = await GetChapterAsync();

        (await _bibleService.GetVersesAsync(chapter)).ShouldBeEmpty();
        (await _bibleService.GetVersesAsync(chapter)).ShouldBeEmpty();

        _source.VerseRequests.ShouldBe(1);
    }

    [Fact]
    public async Task Verses_AreCached()
    {
        _source.Verses = new() { new Verse { Number = 1, Text = "태초에" } };
        var chapter = await GetChapterAsync();

        (await _bibleService.GetVersesAsync(chapter)).Count.ShouldBe(1);
        (await _bibleService.GetVersesAsync(chapter)).Count.ShouldBe(1);

        _source.VerseRequests.ShouldBe(1);
    }

    [Theory]
    // 책 정보가 있는 언어는 성경 언어의 이름과 약자
    [InlineData("en", "Genesis (source)", "Genesis", "Gen")]
    [InlineData("ja", "創世記 (source)", "創世記", "創")]
    // 책 정보가 없는 언어는 성경 소스의 이름과 구절 입력 칸에서 해석할 수 있는 기본 언어 약자
    [InlineData("he", "בראשית", "בראשית", "창")]
    public async Task BookInfo_FollowsBibleLanguage(string languageCode, string sourceName, string expectedName, string expectedAbbreviation)
    {
        _source.LanguageCode = languageCode;
        _source.BookName = sourceName;
        var bible = (await _bibleService.GetBiblesAsync(_source)).Single();

        var book = (await _bibleService.GetBooksAsync(bible)).Single();

        book.NameInfo.ShouldBe(expectedName);
        book.AbbreviationInfo.ShouldBe(expectedAbbreviation);
    }

    private class FakeSource : BibleSource
    {
        public List<Verse> Verses { get; set; } = new();
        public string LanguageCode { get; set; } = "ko";
        public string BookName { get; set; } = "창세기";
        public int VerseRequests { get; private set; }

        public FakeSource()
        {
            Id = 2;
            Name = "fake";
        }

        public override Task<List<Bible>> GetBiblesOnlineAsync() =>
            Task.FromResult(new List<Bible> { new() { OnlineId = "1", Name = "개역개정", LanguageCode = LanguageCode } });

        public override Task<List<Book>> GetBooksOnlineAsync(Bible bible) =>
            Task.FromResult(new List<Book> { new() { OnlineId = "1", Name = BookName, Key = BookKey.Genesis, ChapterCount = 1 } });

        public override Task<List<Chapter>> GetChaptersOnlineAsync(Book book) =>
            Task.FromResult(new List<Chapter> { new() { OnlineId = "1", Number = 1 } });

        public override Task<List<Verse>> GetVersesOnlineAsync(Chapter chapter)
        {
            VerseRequests++;
            return Task.FromResult(Verses.Select(v => v with { }).ToList());
        }
    }
}
