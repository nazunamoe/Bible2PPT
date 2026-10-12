namespace Bible2PPT.Services.BibleIndexService;

internal static partial class BibleIndexSeed
{
    public static IEnumerable<BookInfo> SeedEnglish() =>
        new CsvBibleIndexSeedBuilder("en", "NIV")
            .Build($"""
                {BookKey.Genesis},Genesis,Gen
                {BookKey.Exodus},Exodus,Exod
                {BookKey.Leviticus},Leviticus,Lev
                {BookKey.Numbers},Numbers,Num
                {BookKey.Deuteronomy},Deuteronomy,Deut
                {BookKey.Joshua},Joshua,Josh
                {BookKey.Judges},Judges,Judg
                {BookKey.Ruth},Ruth,Ruth
                {BookKey.ISamuel},1 Samuel,1Sam
                {BookKey.IISamuel},2 Samuel,2Sam
                {BookKey.IKings},1 Kings,1Kgs
                {BookKey.IIKings},2 Kings,2Kgs
                {BookKey.IChronicles},1 Chronicles,1Chr
                {BookKey.IIChronicles},2 Chronicles,2Chr
                {BookKey.Ezra},Ezra,Ezra
                {BookKey.Nehemiah},Nehemiah,Neh
                {BookKey.Esther},Esther,Esth
                {BookKey.Job},Job,Job
                {BookKey.Psalms},Psalms,Ps
                {BookKey.Proverbs},Proverbs,Prov
                {BookKey.Ecclesiastes},Ecclesiastes,Eccl
                {BookKey.SongOfSolomon},Song of Songs,Song
                {BookKey.Isaiah},Isaiah,Isa
                {BookKey.Jeremiah},Jeremiah,Jer
                {BookKey.Lamentations},Lamentations,Lam
                {BookKey.Ezekiel},Ezekiel,Ezek
                {BookKey.Daniel},Daniel,Dan
                {BookKey.Hosea},Hosea,Hos
                {BookKey.Joel},Joel,Joel
                {BookKey.Amos},Amos,Amos
                {BookKey.Obadiah},Obadiah,Obad
                {BookKey.Jonah},Jonah,Jonah
                {BookKey.Micah},Micah,Mic
                {BookKey.Nahum},Nahum,Nah
                {BookKey.Habakkuk},Habakkuk,Hab
                {BookKey.Zephaniah},Zephaniah,Zeph
                {BookKey.Haggai},Haggai,Hag
                {BookKey.Zechariah},Zechariah,Zech
                {BookKey.Malachi},Malachi,Mal
                {BookKey.Matthew},Matthew,Matt
                {BookKey.Mark},Mark,Mark
                {BookKey.Luke},Luke,Luke
                {BookKey.John},John,John
                {BookKey.Acts},Acts,Acts
                {BookKey.Romans},Romans,Rom
                {BookKey.ICorinthians},1 Corinthians,1Cor
                {BookKey.IICorinthians},2 Corinthians,2Cor
                {BookKey.Galatians},Galatians,Gal
                {BookKey.Ephesians},Ephesians,Eph
                {BookKey.Philippians},Philippians,Phil
                {BookKey.Colossians},Colossians,Col
                {BookKey.IThessalonians},1 Thessalonians,1Thess
                {BookKey.IIThessalonians},2 Thessalonians,2Thess
                {BookKey.ITimothy},1 Timothy,1Tim
                {BookKey.IITimothy},2 Timothy,2Tim
                {BookKey.Titus},Titus,Titus
                {BookKey.Philemon},Philemon,Phlm
                {BookKey.Hebrews},Hebrews,Heb
                {BookKey.James},James,Jas
                {BookKey.IPeter},1 Peter,1Pet
                {BookKey.IIPeter},2 Peter,2Pet
                {BookKey.IJohn},1 John,1John
                {BookKey.IIJohn},2 John,2John
                {BookKey.IIIJohn},3 John,3John
                {BookKey.Jude},Jude,Jude
                {BookKey.Revelation},Revelation,Rev
                """);
}
