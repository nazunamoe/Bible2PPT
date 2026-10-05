using Bible2PPT.Bibles;

namespace Bible2PPT.Sources;

public abstract class BibleSource
{
    public static BibleSource[] AvailableSources = new BibleSource[]
    {
        // 0: 갓피플 성경, 1: 갓피아 성경(구 사이트)은 서비스 종료로 제거함
        // 캐시와 작업 기록이 Id를 참조하므로 기존 Id는 재사용하지 않음
        new GoodtvBible { Id = 2 },
        new YouVersionBible { Id = 3 },
        // 갓피아 성경은 사이트 개편 후 새 페이지 구조로 다시 추가함
        new GodpiaBible { Id = 4 },
    };

    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public abstract Task<List<Bible>> GetBiblesOnlineAsync();
    public abstract Task<List<Book>> GetBooksOnlineAsync(Bible bible);
    public abstract Task<List<Chapter>> GetChaptersOnlineAsync(Book book);
    public abstract Task<List<Verse>> GetVersesOnlineAsync(Chapter chapter);

    public override string ToString() => Name;
}
