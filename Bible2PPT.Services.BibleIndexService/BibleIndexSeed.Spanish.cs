namespace Bible2PPT.Services.BibleIndexService;

internal static partial class BibleIndexSeed
{
    public static IEnumerable<BookInfo> SeedSpanish() =>
        new CsvBibleIndexSeedBuilder("es", "Reina-Valera 1960")
            .Build($"""
                {BookKey.Genesis},Génesis,Gn
                {BookKey.Exodus},Éxodo,Ex
                {BookKey.Leviticus},Levítico,Lv
                {BookKey.Numbers},Números,Nm
                {BookKey.Deuteronomy},Deuteronomio,Dt
                {BookKey.Joshua},Josué,Jos
                {BookKey.Judges},Jueces,Jue
                {BookKey.Ruth},Rut,Rt
                {BookKey.ISamuel},1 Samuel,1S
                {BookKey.IISamuel},2 Samuel,2S
                {BookKey.IKings},1 Reyes,1R
                {BookKey.IIKings},2 Reyes,2R
                {BookKey.IChronicles},1 Crónicas,1Cr
                {BookKey.IIChronicles},2 Crónicas,2Cr
                {BookKey.Ezra},Esdras,Esd
                {BookKey.Nehemiah},Nehemías,Neh
                {BookKey.Esther},Ester,Est
                {BookKey.Job},Job,Job
                {BookKey.Psalms},Salmos,Sal
                {BookKey.Proverbs},Proverbios,Pr
                {BookKey.Ecclesiastes},Eclesiastés,Ec
                {BookKey.SongOfSolomon},Cantares,Cnt
                {BookKey.Isaiah},Isaías,Is
                {BookKey.Jeremiah},Jeremías,Jer
                {BookKey.Lamentations},Lamentaciones,Lm
                {BookKey.Ezekiel},Ezequiel,Ez
                {BookKey.Daniel},Daniel,Dn
                {BookKey.Hosea},Oseas,Os
                {BookKey.Joel},Joel,Jl
                {BookKey.Amos},Amós,Am
                {BookKey.Obadiah},Abdías,Abd
                {BookKey.Jonah},Jonás,Jon
                {BookKey.Micah},Miqueas,Mi
                {BookKey.Nahum},Nahúm,Nah
                {BookKey.Habakkuk},Habacuc,Hab
                {BookKey.Zephaniah},Sofonías,Sof
                {BookKey.Haggai},Hageo,Hag
                {BookKey.Zechariah},Zacarías,Zac
                {BookKey.Malachi},Malaquías,Mal
                {BookKey.Matthew},Mateo,Mt
                {BookKey.Mark},Marcos,Mr
                {BookKey.Luke},Lucas,Lc
                {BookKey.John},Juan,Jn
                {BookKey.Acts},Hechos,Hch
                {BookKey.Romans},Romanos,Ro
                {BookKey.ICorinthians},1 Corintios,1Co
                {BookKey.IICorinthians},2 Corintios,2Co
                {BookKey.Galatians},Gálatas,Gá
                {BookKey.Ephesians},Efesios,Ef
                {BookKey.Philippians},Filipenses,Fil
                {BookKey.Colossians},Colosenses,Col
                {BookKey.IThessalonians},1 Tesalonicenses,1Ts
                {BookKey.IIThessalonians},2 Tesalonicenses,2Ts
                {BookKey.ITimothy},1 Timoteo,1Ti
                {BookKey.IITimothy},2 Timoteo,2Ti
                {BookKey.Titus},Tito,Tit
                {BookKey.Philemon},Filemón,Flm
                {BookKey.Hebrews},Hebreos,He
                {BookKey.James},Santiago,Stg
                {BookKey.IPeter},1 Pedro,1P
                {BookKey.IIPeter},2 Pedro,2P
                {BookKey.IJohn},1 Juan,1Jn
                {BookKey.IIJohn},2 Juan,2Jn
                {BookKey.IIIJohn},3 Juan,3Jn
                {BookKey.Jude},Judas,Jud
                {BookKey.Revelation},Apocalipsis,Ap
                """);
}
