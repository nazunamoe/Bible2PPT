using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bible2PPT.Services.BibleIndexService.Migrations
{
    /// <inheritdoc />
    public partial class AddMultilingualBookInfos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BookInfos",
                columns: new[] { "Key", "Kind", "LanguageCode", "Version", "IsPrimary", "Value" },
                values: new object[,]
                {
                    { 1, 0, "en", "NIV", false, "Genesis" },
                    { 1, 0, "es", "Reina-Valera 1960", false, "Génesis" },
                    { 1, 0, "ja", "新共同訳", false, "創世記" },
                    { 1, 0, "zh-cn", "和合本", false, "创世记" },
                    { 1, 0, "zh-tw", "和合本", false, "創世記" },
                    { 1, 1, "en", "NIV", false, "Gen" },
                    { 1, 1, "es", "Reina-Valera 1960", false, "Gn" },
                    { 1, 1, "ja", "新共同訳", false, "創" },
                    { 1, 1, "zh-cn", "和合本", false, "创" },
                    { 1, 1, "zh-tw", "和合本", false, "創" },
                    { 2, 0, "en", "NIV", false, "Exodus" },
                    { 2, 0, "es", "Reina-Valera 1960", false, "Éxodo" },
                    { 2, 0, "ja", "新共同訳", false, "出エジプト記" },
                    { 2, 0, "zh-cn", "和合本", false, "出埃及记" },
                    { 2, 0, "zh-tw", "和合本", false, "出埃及記" },
                    { 2, 1, "en", "NIV", false, "Exod" },
                    { 2, 1, "es", "Reina-Valera 1960", false, "Ex" },
                    { 2, 1, "ja", "新共同訳", false, "出" },
                    { 2, 1, "zh-cn", "和合本", false, "出" },
                    { 2, 1, "zh-tw", "和合本", false, "出" },
                    { 3, 0, "en", "NIV", false, "Leviticus" },
                    { 3, 0, "es", "Reina-Valera 1960", false, "Levítico" },
                    { 3, 0, "ja", "新共同訳", false, "レビ記" },
                    { 3, 0, "zh-cn", "和合本", false, "利未记" },
                    { 3, 0, "zh-tw", "和合本", false, "利未記" },
                    { 3, 1, "en", "NIV", false, "Lev" },
                    { 3, 1, "es", "Reina-Valera 1960", false, "Lv" },
                    { 3, 1, "ja", "新共同訳", false, "レビ" },
                    { 3, 1, "zh-cn", "和合本", false, "利" },
                    { 3, 1, "zh-tw", "和合本", false, "利" },
                    { 4, 0, "en", "NIV", false, "Numbers" },
                    { 4, 0, "es", "Reina-Valera 1960", false, "Números" },
                    { 4, 0, "ja", "新共同訳", false, "民数記" },
                    { 4, 0, "zh-cn", "和合本", false, "民数记" },
                    { 4, 0, "zh-tw", "和合本", false, "民數記" },
                    { 4, 1, "en", "NIV", false, "Num" },
                    { 4, 1, "es", "Reina-Valera 1960", false, "Nm" },
                    { 4, 1, "ja", "新共同訳", false, "民" },
                    { 4, 1, "zh-cn", "和合本", false, "民" },
                    { 4, 1, "zh-tw", "和合本", false, "民" },
                    { 5, 0, "en", "NIV", false, "Deuteronomy" },
                    { 5, 0, "es", "Reina-Valera 1960", false, "Deuteronomio" },
                    { 5, 0, "ja", "新共同訳", false, "申命記" },
                    { 5, 0, "zh-cn", "和合本", false, "申命记" },
                    { 5, 0, "zh-tw", "和合本", false, "申命記" },
                    { 5, 1, "en", "NIV", false, "Deut" },
                    { 5, 1, "es", "Reina-Valera 1960", false, "Dt" },
                    { 5, 1, "ja", "新共同訳", false, "申" },
                    { 5, 1, "zh-cn", "和合本", false, "申" },
                    { 5, 1, "zh-tw", "和合本", false, "申" },
                    { 6, 0, "en", "NIV", false, "Joshua" },
                    { 6, 0, "es", "Reina-Valera 1960", false, "Josué" },
                    { 6, 0, "ja", "新共同訳", false, "ヨシュア記" },
                    { 6, 0, "zh-cn", "和合本", false, "约书亚记" },
                    { 6, 0, "zh-tw", "和合本", false, "約書亞記" },
                    { 6, 1, "en", "NIV", false, "Josh" },
                    { 6, 1, "es", "Reina-Valera 1960", false, "Jos" },
                    { 6, 1, "ja", "新共同訳", false, "ヨシュ" },
                    { 6, 1, "zh-cn", "和合本", false, "书" },
                    { 6, 1, "zh-tw", "和合本", false, "書" },
                    { 7, 0, "en", "NIV", false, "Judges" },
                    { 7, 0, "es", "Reina-Valera 1960", false, "Jueces" },
                    { 7, 0, "ja", "新共同訳", false, "士師記" },
                    { 7, 0, "zh-cn", "和合本", false, "士师记" },
                    { 7, 0, "zh-tw", "和合本", false, "士師記" },
                    { 7, 1, "en", "NIV", false, "Judg" },
                    { 7, 1, "es", "Reina-Valera 1960", false, "Jue" },
                    { 7, 1, "ja", "新共同訳", false, "士" },
                    { 7, 1, "zh-cn", "和合本", false, "士" },
                    { 7, 1, "zh-tw", "和合本", false, "士" },
                    { 8, 0, "en", "NIV", false, "Ruth" },
                    { 8, 0, "es", "Reina-Valera 1960", false, "Rut" },
                    { 8, 0, "ja", "新共同訳", false, "ルツ記" },
                    { 8, 0, "zh-cn", "和合本", false, "路得记" },
                    { 8, 0, "zh-tw", "和合本", false, "路得記" },
                    { 8, 1, "en", "NIV", false, "Ruth" },
                    { 8, 1, "es", "Reina-Valera 1960", false, "Rt" },
                    { 8, 1, "ja", "新共同訳", false, "ルツ" },
                    { 8, 1, "zh-cn", "和合本", false, "得" },
                    { 8, 1, "zh-tw", "和合本", false, "得" },
                    { 9, 0, "en", "NIV", false, "1 Samuel" },
                    { 9, 0, "es", "Reina-Valera 1960", false, "1 Samuel" },
                    { 9, 0, "ja", "新共同訳", false, "サムエル記上" },
                    { 9, 0, "zh-cn", "和合本", false, "撒母耳记上" },
                    { 9, 0, "zh-tw", "和合本", false, "撒母耳記上" },
                    { 9, 1, "en", "NIV", false, "1Sam" },
                    { 9, 1, "es", "Reina-Valera 1960", false, "1S" },
                    { 9, 1, "ja", "新共同訳", false, "サム上" },
                    { 9, 1, "zh-cn", "和合本", false, "撒上" },
                    { 9, 1, "zh-tw", "和合本", false, "撒上" },
                    { 10, 0, "en", "NIV", false, "2 Samuel" },
                    { 10, 0, "es", "Reina-Valera 1960", false, "2 Samuel" },
                    { 10, 0, "ja", "新共同訳", false, "サムエル記下" },
                    { 10, 0, "zh-cn", "和合本", false, "撒母耳记下" },
                    { 10, 0, "zh-tw", "和合本", false, "撒母耳記下" },
                    { 10, 1, "en", "NIV", false, "2Sam" },
                    { 10, 1, "es", "Reina-Valera 1960", false, "2S" },
                    { 10, 1, "ja", "新共同訳", false, "サム下" },
                    { 10, 1, "zh-cn", "和合本", false, "撒下" },
                    { 10, 1, "zh-tw", "和合本", false, "撒下" },
                    { 11, 0, "en", "NIV", false, "1 Kings" },
                    { 11, 0, "es", "Reina-Valera 1960", false, "1 Reyes" },
                    { 11, 0, "ja", "新共同訳", false, "列王記上" },
                    { 11, 0, "zh-cn", "和合本", false, "列王纪上" },
                    { 11, 0, "zh-tw", "和合本", false, "列王紀上" },
                    { 11, 1, "en", "NIV", false, "1Kgs" },
                    { 11, 1, "es", "Reina-Valera 1960", false, "1R" },
                    { 11, 1, "ja", "新共同訳", false, "王上" },
                    { 11, 1, "zh-cn", "和合本", false, "王上" },
                    { 11, 1, "zh-tw", "和合本", false, "王上" },
                    { 12, 0, "en", "NIV", false, "2 Kings" },
                    { 12, 0, "es", "Reina-Valera 1960", false, "2 Reyes" },
                    { 12, 0, "ja", "新共同訳", false, "列王記下" },
                    { 12, 0, "zh-cn", "和合本", false, "列王纪下" },
                    { 12, 0, "zh-tw", "和合本", false, "列王紀下" },
                    { 12, 1, "en", "NIV", false, "2Kgs" },
                    { 12, 1, "es", "Reina-Valera 1960", false, "2R" },
                    { 12, 1, "ja", "新共同訳", false, "王下" },
                    { 12, 1, "zh-cn", "和合本", false, "王下" },
                    { 12, 1, "zh-tw", "和合本", false, "王下" },
                    { 13, 0, "en", "NIV", false, "1 Chronicles" },
                    { 13, 0, "es", "Reina-Valera 1960", false, "1 Crónicas" },
                    { 13, 0, "ja", "新共同訳", false, "歴代誌上" },
                    { 13, 0, "zh-cn", "和合本", false, "历代志上" },
                    { 13, 0, "zh-tw", "和合本", false, "歷代志上" },
                    { 13, 1, "en", "NIV", false, "1Chr" },
                    { 13, 1, "es", "Reina-Valera 1960", false, "1Cr" },
                    { 13, 1, "ja", "新共同訳", false, "代上" },
                    { 13, 1, "zh-cn", "和合本", false, "代上" },
                    { 13, 1, "zh-tw", "和合本", false, "代上" },
                    { 14, 0, "en", "NIV", false, "2 Chronicles" },
                    { 14, 0, "es", "Reina-Valera 1960", false, "2 Crónicas" },
                    { 14, 0, "ja", "新共同訳", false, "歴代誌下" },
                    { 14, 0, "zh-cn", "和合本", false, "历代志下" },
                    { 14, 0, "zh-tw", "和合本", false, "歷代志下" },
                    { 14, 1, "en", "NIV", false, "2Chr" },
                    { 14, 1, "es", "Reina-Valera 1960", false, "2Cr" },
                    { 14, 1, "ja", "新共同訳", false, "代下" },
                    { 14, 1, "zh-cn", "和合本", false, "代下" },
                    { 14, 1, "zh-tw", "和合本", false, "代下" },
                    { 15, 0, "en", "NIV", false, "Ezra" },
                    { 15, 0, "es", "Reina-Valera 1960", false, "Esdras" },
                    { 15, 0, "ja", "新共同訳", false, "エズラ記" },
                    { 15, 0, "zh-cn", "和合本", false, "以斯拉记" },
                    { 15, 0, "zh-tw", "和合本", false, "以斯拉記" },
                    { 15, 1, "en", "NIV", false, "Ezra" },
                    { 15, 1, "es", "Reina-Valera 1960", false, "Esd" },
                    { 15, 1, "ja", "新共同訳", false, "エズ" },
                    { 15, 1, "zh-cn", "和合本", false, "拉" },
                    { 15, 1, "zh-tw", "和合本", false, "拉" },
                    { 16, 0, "en", "NIV", false, "Nehemiah" },
                    { 16, 0, "es", "Reina-Valera 1960", false, "Nehemías" },
                    { 16, 0, "ja", "新共同訳", false, "ネヘミヤ記" },
                    { 16, 0, "zh-cn", "和合本", false, "尼希米记" },
                    { 16, 0, "zh-tw", "和合本", false, "尼希米記" },
                    { 16, 1, "en", "NIV", false, "Neh" },
                    { 16, 1, "es", "Reina-Valera 1960", false, "Neh" },
                    { 16, 1, "ja", "新共同訳", false, "ネヘ" },
                    { 16, 1, "zh-cn", "和合本", false, "尼" },
                    { 16, 1, "zh-tw", "和合本", false, "尼" },
                    { 17, 0, "en", "NIV", false, "Esther" },
                    { 17, 0, "es", "Reina-Valera 1960", false, "Ester" },
                    { 17, 0, "ja", "新共同訳", false, "エステル記" },
                    { 17, 0, "zh-cn", "和合本", false, "以斯帖记" },
                    { 17, 0, "zh-tw", "和合本", false, "以斯帖記" },
                    { 17, 1, "en", "NIV", false, "Esth" },
                    { 17, 1, "es", "Reina-Valera 1960", false, "Est" },
                    { 17, 1, "ja", "新共同訳", false, "エス" },
                    { 17, 1, "zh-cn", "和合本", false, "斯" },
                    { 17, 1, "zh-tw", "和合本", false, "斯" },
                    { 18, 0, "en", "NIV", false, "Job" },
                    { 18, 0, "es", "Reina-Valera 1960", false, "Job" },
                    { 18, 0, "ja", "新共同訳", false, "ヨブ記" },
                    { 18, 0, "zh-cn", "和合本", false, "约伯记" },
                    { 18, 0, "zh-tw", "和合本", false, "約伯記" },
                    { 18, 1, "en", "NIV", false, "Job" },
                    { 18, 1, "es", "Reina-Valera 1960", false, "Job" },
                    { 18, 1, "ja", "新共同訳", false, "ヨブ" },
                    { 18, 1, "zh-cn", "和合本", false, "伯" },
                    { 18, 1, "zh-tw", "和合本", false, "伯" },
                    { 19, 0, "en", "NIV", false, "Psalms" },
                    { 19, 0, "es", "Reina-Valera 1960", false, "Salmos" },
                    { 19, 0, "ja", "新共同訳", false, "詩編" },
                    { 19, 0, "zh-cn", "和合本", false, "诗篇" },
                    { 19, 0, "zh-tw", "和合本", false, "詩篇" },
                    { 19, 1, "en", "NIV", false, "Ps" },
                    { 19, 1, "es", "Reina-Valera 1960", false, "Sal" },
                    { 19, 1, "ja", "新共同訳", false, "詩" },
                    { 19, 1, "zh-cn", "和合本", false, "诗" },
                    { 19, 1, "zh-tw", "和合本", false, "詩" },
                    { 20, 0, "en", "NIV", false, "Proverbs" },
                    { 20, 0, "es", "Reina-Valera 1960", false, "Proverbios" },
                    { 20, 0, "ja", "新共同訳", false, "箴言" },
                    { 20, 0, "zh-cn", "和合本", false, "箴言" },
                    { 20, 0, "zh-tw", "和合本", false, "箴言" },
                    { 20, 1, "en", "NIV", false, "Prov" },
                    { 20, 1, "es", "Reina-Valera 1960", false, "Pr" },
                    { 20, 1, "ja", "新共同訳", false, "箴" },
                    { 20, 1, "zh-cn", "和合本", false, "箴" },
                    { 20, 1, "zh-tw", "和合本", false, "箴" },
                    { 21, 0, "en", "NIV", false, "Ecclesiastes" },
                    { 21, 0, "es", "Reina-Valera 1960", false, "Eclesiastés" },
                    { 21, 0, "ja", "新共同訳", false, "コヘレトの言葉" },
                    { 21, 0, "zh-cn", "和合本", false, "传道书" },
                    { 21, 0, "zh-tw", "和合本", false, "傳道書" },
                    { 21, 1, "en", "NIV", false, "Eccl" },
                    { 21, 1, "es", "Reina-Valera 1960", false, "Ec" },
                    { 21, 1, "ja", "新共同訳", false, "コヘ" },
                    { 21, 1, "zh-cn", "和合本", false, "传" },
                    { 21, 1, "zh-tw", "和合本", false, "傳" },
                    { 22, 0, "en", "NIV", false, "Song of Songs" },
                    { 22, 0, "es", "Reina-Valera 1960", false, "Cantares" },
                    { 22, 0, "ja", "新共同訳", false, "雅歌" },
                    { 22, 0, "zh-cn", "和合本", false, "雅歌" },
                    { 22, 0, "zh-tw", "和合本", false, "雅歌" },
                    { 22, 1, "en", "NIV", false, "Song" },
                    { 22, 1, "es", "Reina-Valera 1960", false, "Cnt" },
                    { 22, 1, "ja", "新共同訳", false, "雅歌" },
                    { 22, 1, "zh-cn", "和合本", false, "歌" },
                    { 22, 1, "zh-tw", "和合本", false, "歌" },
                    { 23, 0, "en", "NIV", false, "Isaiah" },
                    { 23, 0, "es", "Reina-Valera 1960", false, "Isaías" },
                    { 23, 0, "ja", "新共同訳", false, "イザヤ書" },
                    { 23, 0, "zh-cn", "和合本", false, "以赛亚书" },
                    { 23, 0, "zh-tw", "和合本", false, "以賽亞書" },
                    { 23, 1, "en", "NIV", false, "Isa" },
                    { 23, 1, "es", "Reina-Valera 1960", false, "Is" },
                    { 23, 1, "ja", "新共同訳", false, "イザ" },
                    { 23, 1, "zh-cn", "和合本", false, "赛" },
                    { 23, 1, "zh-tw", "和合本", false, "賽" },
                    { 24, 0, "en", "NIV", false, "Jeremiah" },
                    { 24, 0, "es", "Reina-Valera 1960", false, "Jeremías" },
                    { 24, 0, "ja", "新共同訳", false, "エレミヤ書" },
                    { 24, 0, "zh-cn", "和合本", false, "耶利米书" },
                    { 24, 0, "zh-tw", "和合本", false, "耶利米書" },
                    { 24, 1, "en", "NIV", false, "Jer" },
                    { 24, 1, "es", "Reina-Valera 1960", false, "Jer" },
                    { 24, 1, "ja", "新共同訳", false, "エレ" },
                    { 24, 1, "zh-cn", "和合本", false, "耶" },
                    { 24, 1, "zh-tw", "和合本", false, "耶" },
                    { 25, 0, "en", "NIV", false, "Lamentations" },
                    { 25, 0, "es", "Reina-Valera 1960", false, "Lamentaciones" },
                    { 25, 0, "ja", "新共同訳", false, "哀歌" },
                    { 25, 0, "zh-cn", "和合本", false, "耶利米哀歌" },
                    { 25, 0, "zh-tw", "和合本", false, "耶利米哀歌" },
                    { 25, 1, "en", "NIV", false, "Lam" },
                    { 25, 1, "es", "Reina-Valera 1960", false, "Lm" },
                    { 25, 1, "ja", "新共同訳", false, "哀" },
                    { 25, 1, "zh-cn", "和合本", false, "哀" },
                    { 25, 1, "zh-tw", "和合本", false, "哀" },
                    { 26, 0, "en", "NIV", false, "Ezekiel" },
                    { 26, 0, "es", "Reina-Valera 1960", false, "Ezequiel" },
                    { 26, 0, "ja", "新共同訳", false, "エゼキエル書" },
                    { 26, 0, "zh-cn", "和合本", false, "以西结书" },
                    { 26, 0, "zh-tw", "和合本", false, "以西結書" },
                    { 26, 1, "en", "NIV", false, "Ezek" },
                    { 26, 1, "es", "Reina-Valera 1960", false, "Ez" },
                    { 26, 1, "ja", "新共同訳", false, "エゼ" },
                    { 26, 1, "zh-cn", "和合本", false, "结" },
                    { 26, 1, "zh-tw", "和合本", false, "結" },
                    { 27, 0, "en", "NIV", false, "Daniel" },
                    { 27, 0, "es", "Reina-Valera 1960", false, "Daniel" },
                    { 27, 0, "ja", "新共同訳", false, "ダニエル書" },
                    { 27, 0, "zh-cn", "和合本", false, "但以理书" },
                    { 27, 0, "zh-tw", "和合本", false, "但以理書" },
                    { 27, 1, "en", "NIV", false, "Dan" },
                    { 27, 1, "es", "Reina-Valera 1960", false, "Dn" },
                    { 27, 1, "ja", "新共同訳", false, "ダニ" },
                    { 27, 1, "zh-cn", "和合本", false, "但" },
                    { 27, 1, "zh-tw", "和合本", false, "但" },
                    { 28, 0, "en", "NIV", false, "Hosea" },
                    { 28, 0, "es", "Reina-Valera 1960", false, "Oseas" },
                    { 28, 0, "ja", "新共同訳", false, "ホセア書" },
                    { 28, 0, "zh-cn", "和合本", false, "何西阿书" },
                    { 28, 0, "zh-tw", "和合本", false, "何西阿書" },
                    { 28, 1, "en", "NIV", false, "Hos" },
                    { 28, 1, "es", "Reina-Valera 1960", false, "Os" },
                    { 28, 1, "ja", "新共同訳", false, "ホセ" },
                    { 28, 1, "zh-cn", "和合本", false, "何" },
                    { 28, 1, "zh-tw", "和合本", false, "何" },
                    { 29, 0, "en", "NIV", false, "Joel" },
                    { 29, 0, "es", "Reina-Valera 1960", false, "Joel" },
                    { 29, 0, "ja", "新共同訳", false, "ヨエル書" },
                    { 29, 0, "zh-cn", "和合本", false, "约珥书" },
                    { 29, 0, "zh-tw", "和合本", false, "約珥書" },
                    { 29, 1, "en", "NIV", false, "Joel" },
                    { 29, 1, "es", "Reina-Valera 1960", false, "Jl" },
                    { 29, 1, "ja", "新共同訳", false, "ヨエ" },
                    { 29, 1, "zh-cn", "和合本", false, "珥" },
                    { 29, 1, "zh-tw", "和合本", false, "珥" },
                    { 30, 0, "en", "NIV", false, "Amos" },
                    { 30, 0, "es", "Reina-Valera 1960", false, "Amós" },
                    { 30, 0, "ja", "新共同訳", false, "アモス書" },
                    { 30, 0, "zh-cn", "和合本", false, "阿摩司书" },
                    { 30, 0, "zh-tw", "和合本", false, "阿摩司書" },
                    { 30, 1, "en", "NIV", false, "Amos" },
                    { 30, 1, "es", "Reina-Valera 1960", false, "Am" },
                    { 30, 1, "ja", "新共同訳", false, "アモ" },
                    { 30, 1, "zh-cn", "和合本", false, "摩" },
                    { 30, 1, "zh-tw", "和合本", false, "摩" },
                    { 31, 0, "en", "NIV", false, "Obadiah" },
                    { 31, 0, "es", "Reina-Valera 1960", false, "Abdías" },
                    { 31, 0, "ja", "新共同訳", false, "オバデヤ書" },
                    { 31, 0, "zh-cn", "和合本", false, "俄巴底亚书" },
                    { 31, 0, "zh-tw", "和合本", false, "俄巴底亞書" },
                    { 31, 1, "en", "NIV", false, "Obad" },
                    { 31, 1, "es", "Reina-Valera 1960", false, "Abd" },
                    { 31, 1, "ja", "新共同訳", false, "オバ" },
                    { 31, 1, "zh-cn", "和合本", false, "俄" },
                    { 31, 1, "zh-tw", "和合本", false, "俄" },
                    { 32, 0, "en", "NIV", false, "Jonah" },
                    { 32, 0, "es", "Reina-Valera 1960", false, "Jonás" },
                    { 32, 0, "ja", "新共同訳", false, "ヨナ書" },
                    { 32, 0, "zh-cn", "和合本", false, "约拿书" },
                    { 32, 0, "zh-tw", "和合本", false, "約拿書" },
                    { 32, 1, "en", "NIV", false, "Jonah" },
                    { 32, 1, "es", "Reina-Valera 1960", false, "Jon" },
                    { 32, 1, "ja", "新共同訳", false, "ヨナ" },
                    { 32, 1, "zh-cn", "和合本", false, "拿" },
                    { 32, 1, "zh-tw", "和合本", false, "拿" },
                    { 33, 0, "en", "NIV", false, "Micah" },
                    { 33, 0, "es", "Reina-Valera 1960", false, "Miqueas" },
                    { 33, 0, "ja", "新共同訳", false, "ミカ書" },
                    { 33, 0, "zh-cn", "和合本", false, "弥迦书" },
                    { 33, 0, "zh-tw", "和合本", false, "彌迦書" },
                    { 33, 1, "en", "NIV", false, "Mic" },
                    { 33, 1, "es", "Reina-Valera 1960", false, "Mi" },
                    { 33, 1, "ja", "新共同訳", false, "ミカ" },
                    { 33, 1, "zh-cn", "和合本", false, "弥" },
                    { 33, 1, "zh-tw", "和合本", false, "彌" },
                    { 34, 0, "en", "NIV", false, "Nahum" },
                    { 34, 0, "es", "Reina-Valera 1960", false, "Nahúm" },
                    { 34, 0, "ja", "新共同訳", false, "ナホム書" },
                    { 34, 0, "zh-cn", "和合本", false, "那鸿书" },
                    { 34, 0, "zh-tw", "和合本", false, "那鴻書" },
                    { 34, 1, "en", "NIV", false, "Nah" },
                    { 34, 1, "es", "Reina-Valera 1960", false, "Nah" },
                    { 34, 1, "ja", "新共同訳", false, "ナホ" },
                    { 34, 1, "zh-cn", "和合本", false, "鸿" },
                    { 34, 1, "zh-tw", "和合本", false, "鴻" },
                    { 35, 0, "en", "NIV", false, "Habakkuk" },
                    { 35, 0, "es", "Reina-Valera 1960", false, "Habacuc" },
                    { 35, 0, "ja", "新共同訳", false, "ハバクク書" },
                    { 35, 0, "zh-cn", "和合本", false, "哈巴谷书" },
                    { 35, 0, "zh-tw", "和合本", false, "哈巴谷書" },
                    { 35, 1, "en", "NIV", false, "Hab" },
                    { 35, 1, "es", "Reina-Valera 1960", false, "Hab" },
                    { 35, 1, "ja", "新共同訳", false, "ハバ" },
                    { 35, 1, "zh-cn", "和合本", false, "哈" },
                    { 35, 1, "zh-tw", "和合本", false, "哈" },
                    { 36, 0, "en", "NIV", false, "Zephaniah" },
                    { 36, 0, "es", "Reina-Valera 1960", false, "Sofonías" },
                    { 36, 0, "ja", "新共同訳", false, "ゼファニヤ書" },
                    { 36, 0, "zh-cn", "和合本", false, "西番雅书" },
                    { 36, 0, "zh-tw", "和合本", false, "西番雅書" },
                    { 36, 1, "en", "NIV", false, "Zeph" },
                    { 36, 1, "es", "Reina-Valera 1960", false, "Sof" },
                    { 36, 1, "ja", "新共同訳", false, "ゼファ" },
                    { 36, 1, "zh-cn", "和合本", false, "番" },
                    { 36, 1, "zh-tw", "和合本", false, "番" },
                    { 37, 0, "en", "NIV", false, "Haggai" },
                    { 37, 0, "es", "Reina-Valera 1960", false, "Hageo" },
                    { 37, 0, "ja", "新共同訳", false, "ハガイ書" },
                    { 37, 0, "zh-cn", "和合本", false, "哈该书" },
                    { 37, 0, "zh-tw", "和合本", false, "哈該書" },
                    { 37, 1, "en", "NIV", false, "Hag" },
                    { 37, 1, "es", "Reina-Valera 1960", false, "Hag" },
                    { 37, 1, "ja", "新共同訳", false, "ハガ" },
                    { 37, 1, "zh-cn", "和合本", false, "该" },
                    { 37, 1, "zh-tw", "和合本", false, "該" },
                    { 38, 0, "en", "NIV", false, "Zechariah" },
                    { 38, 0, "es", "Reina-Valera 1960", false, "Zacarías" },
                    { 38, 0, "ja", "新共同訳", false, "ゼカリヤ書" },
                    { 38, 0, "zh-cn", "和合本", false, "撒迦利亚书" },
                    { 38, 0, "zh-tw", "和合本", false, "撒迦利亞書" },
                    { 38, 1, "en", "NIV", false, "Zech" },
                    { 38, 1, "es", "Reina-Valera 1960", false, "Zac" },
                    { 38, 1, "ja", "新共同訳", false, "ゼカ" },
                    { 38, 1, "zh-cn", "和合本", false, "亚" },
                    { 38, 1, "zh-tw", "和合本", false, "亞" },
                    { 39, 0, "en", "NIV", false, "Malachi" },
                    { 39, 0, "es", "Reina-Valera 1960", false, "Malaquías" },
                    { 39, 0, "ja", "新共同訳", false, "マラキ書" },
                    { 39, 0, "zh-cn", "和合本", false, "玛拉基书" },
                    { 39, 0, "zh-tw", "和合本", false, "瑪拉基書" },
                    { 39, 1, "en", "NIV", false, "Mal" },
                    { 39, 1, "es", "Reina-Valera 1960", false, "Mal" },
                    { 39, 1, "ja", "新共同訳", false, "マラ" },
                    { 39, 1, "zh-cn", "和合本", false, "玛" },
                    { 39, 1, "zh-tw", "和合本", false, "瑪" },
                    { 55, 0, "en", "NIV", false, "Matthew" },
                    { 55, 0, "es", "Reina-Valera 1960", false, "Mateo" },
                    { 55, 0, "ja", "新共同訳", false, "マタイによる福音書" },
                    { 55, 0, "zh-cn", "和合本", false, "马太福音" },
                    { 55, 0, "zh-tw", "和合本", false, "馬太福音" },
                    { 55, 1, "en", "NIV", false, "Matt" },
                    { 55, 1, "es", "Reina-Valera 1960", false, "Mt" },
                    { 55, 1, "ja", "新共同訳", false, "マタ" },
                    { 55, 1, "zh-cn", "和合本", false, "太" },
                    { 55, 1, "zh-tw", "和合本", false, "太" },
                    { 56, 0, "en", "NIV", false, "Mark" },
                    { 56, 0, "es", "Reina-Valera 1960", false, "Marcos" },
                    { 56, 0, "ja", "新共同訳", false, "マルコによる福音書" },
                    { 56, 0, "zh-cn", "和合本", false, "马可福音" },
                    { 56, 0, "zh-tw", "和合本", false, "馬可福音" },
                    { 56, 1, "en", "NIV", false, "Mark" },
                    { 56, 1, "es", "Reina-Valera 1960", false, "Mr" },
                    { 56, 1, "ja", "新共同訳", false, "マコ" },
                    { 56, 1, "zh-cn", "和合本", false, "可" },
                    { 56, 1, "zh-tw", "和合本", false, "可" },
                    { 57, 0, "en", "NIV", false, "Luke" },
                    { 57, 0, "es", "Reina-Valera 1960", false, "Lucas" },
                    { 57, 0, "ja", "新共同訳", false, "ルカによる福音書" },
                    { 57, 0, "zh-cn", "和合本", false, "路加福音" },
                    { 57, 0, "zh-tw", "和合本", false, "路加福音" },
                    { 57, 1, "en", "NIV", false, "Luke" },
                    { 57, 1, "es", "Reina-Valera 1960", false, "Lc" },
                    { 57, 1, "ja", "新共同訳", false, "ルカ" },
                    { 57, 1, "zh-cn", "和合本", false, "路" },
                    { 57, 1, "zh-tw", "和合本", false, "路" },
                    { 58, 0, "en", "NIV", false, "John" },
                    { 58, 0, "es", "Reina-Valera 1960", false, "Juan" },
                    { 58, 0, "ja", "新共同訳", false, "ヨハネによる福音書" },
                    { 58, 0, "zh-cn", "和合本", false, "约翰福音" },
                    { 58, 0, "zh-tw", "和合本", false, "約翰福音" },
                    { 58, 1, "en", "NIV", false, "John" },
                    { 58, 1, "es", "Reina-Valera 1960", false, "Jn" },
                    { 58, 1, "ja", "新共同訳", false, "ヨハ" },
                    { 58, 1, "zh-cn", "和合本", false, "约" },
                    { 58, 1, "zh-tw", "和合本", false, "約" },
                    { 59, 0, "en", "NIV", false, "Acts" },
                    { 59, 0, "es", "Reina-Valera 1960", false, "Hechos" },
                    { 59, 0, "ja", "新共同訳", false, "使徒言行録" },
                    { 59, 0, "zh-cn", "和合本", false, "使徒行传" },
                    { 59, 0, "zh-tw", "和合本", false, "使徒行傳" },
                    { 59, 1, "en", "NIV", false, "Acts" },
                    { 59, 1, "es", "Reina-Valera 1960", false, "Hch" },
                    { 59, 1, "ja", "新共同訳", false, "使" },
                    { 59, 1, "zh-cn", "和合本", false, "徒" },
                    { 59, 1, "zh-tw", "和合本", false, "徒" },
                    { 60, 0, "en", "NIV", false, "Romans" },
                    { 60, 0, "es", "Reina-Valera 1960", false, "Romanos" },
                    { 60, 0, "ja", "新共同訳", false, "ローマの信徒への手紙" },
                    { 60, 0, "zh-cn", "和合本", false, "罗马书" },
                    { 60, 0, "zh-tw", "和合本", false, "羅馬書" },
                    { 60, 1, "en", "NIV", false, "Rom" },
                    { 60, 1, "es", "Reina-Valera 1960", false, "Ro" },
                    { 60, 1, "ja", "新共同訳", false, "ロマ" },
                    { 60, 1, "zh-cn", "和合本", false, "罗" },
                    { 60, 1, "zh-tw", "和合本", false, "羅" },
                    { 61, 0, "en", "NIV", false, "1 Corinthians" },
                    { 61, 0, "es", "Reina-Valera 1960", false, "1 Corintios" },
                    { 61, 0, "ja", "新共同訳", false, "コリントの信徒への手紙一" },
                    { 61, 0, "zh-cn", "和合本", false, "哥林多前书" },
                    { 61, 0, "zh-tw", "和合本", false, "哥林多前書" },
                    { 61, 1, "en", "NIV", false, "1Cor" },
                    { 61, 1, "es", "Reina-Valera 1960", false, "1Co" },
                    { 61, 1, "ja", "新共同訳", false, "一コリ" },
                    { 61, 1, "zh-cn", "和合本", false, "林前" },
                    { 61, 1, "zh-tw", "和合本", false, "林前" },
                    { 62, 0, "en", "NIV", false, "2 Corinthians" },
                    { 62, 0, "es", "Reina-Valera 1960", false, "2 Corintios" },
                    { 62, 0, "ja", "新共同訳", false, "コリントの信徒への手紙二" },
                    { 62, 0, "zh-cn", "和合本", false, "哥林多后书" },
                    { 62, 0, "zh-tw", "和合本", false, "哥林多後書" },
                    { 62, 1, "en", "NIV", false, "2Cor" },
                    { 62, 1, "es", "Reina-Valera 1960", false, "2Co" },
                    { 62, 1, "ja", "新共同訳", false, "二コリ" },
                    { 62, 1, "zh-cn", "和合本", false, "林后" },
                    { 62, 1, "zh-tw", "和合本", false, "林後" },
                    { 63, 0, "en", "NIV", false, "Galatians" },
                    { 63, 0, "es", "Reina-Valera 1960", false, "Gálatas" },
                    { 63, 0, "ja", "新共同訳", false, "ガラテヤの信徒への手紙" },
                    { 63, 0, "zh-cn", "和合本", false, "加拉太书" },
                    { 63, 0, "zh-tw", "和合本", false, "加拉太書" },
                    { 63, 1, "en", "NIV", false, "Gal" },
                    { 63, 1, "es", "Reina-Valera 1960", false, "Gá" },
                    { 63, 1, "ja", "新共同訳", false, "ガラ" },
                    { 63, 1, "zh-cn", "和合本", false, "加" },
                    { 63, 1, "zh-tw", "和合本", false, "加" },
                    { 64, 0, "en", "NIV", false, "Ephesians" },
                    { 64, 0, "es", "Reina-Valera 1960", false, "Efesios" },
                    { 64, 0, "ja", "新共同訳", false, "エフェソの信徒への手紙" },
                    { 64, 0, "zh-cn", "和合本", false, "以弗所书" },
                    { 64, 0, "zh-tw", "和合本", false, "以弗所書" },
                    { 64, 1, "en", "NIV", false, "Eph" },
                    { 64, 1, "es", "Reina-Valera 1960", false, "Ef" },
                    { 64, 1, "ja", "新共同訳", false, "エフェ" },
                    { 64, 1, "zh-cn", "和合本", false, "弗" },
                    { 64, 1, "zh-tw", "和合本", false, "弗" },
                    { 65, 0, "en", "NIV", false, "Philippians" },
                    { 65, 0, "es", "Reina-Valera 1960", false, "Filipenses" },
                    { 65, 0, "ja", "新共同訳", false, "フィリピの信徒への手紙" },
                    { 65, 0, "zh-cn", "和合本", false, "腓立比书" },
                    { 65, 0, "zh-tw", "和合本", false, "腓立比書" },
                    { 65, 1, "en", "NIV", false, "Phil" },
                    { 65, 1, "es", "Reina-Valera 1960", false, "Fil" },
                    { 65, 1, "ja", "新共同訳", false, "フィリ" },
                    { 65, 1, "zh-cn", "和合本", false, "腓" },
                    { 65, 1, "zh-tw", "和合本", false, "腓" },
                    { 66, 0, "en", "NIV", false, "Colossians" },
                    { 66, 0, "es", "Reina-Valera 1960", false, "Colosenses" },
                    { 66, 0, "ja", "新共同訳", false, "コロサイの信徒への手紙" },
                    { 66, 0, "zh-cn", "和合本", false, "歌罗西书" },
                    { 66, 0, "zh-tw", "和合本", false, "歌羅西書" },
                    { 66, 1, "en", "NIV", false, "Col" },
                    { 66, 1, "es", "Reina-Valera 1960", false, "Col" },
                    { 66, 1, "ja", "新共同訳", false, "コロ" },
                    { 66, 1, "zh-cn", "和合本", false, "西" },
                    { 66, 1, "zh-tw", "和合本", false, "西" },
                    { 67, 0, "en", "NIV", false, "1 Thessalonians" },
                    { 67, 0, "es", "Reina-Valera 1960", false, "1 Tesalonicenses" },
                    { 67, 0, "ja", "新共同訳", false, "テサロニケの信徒への手紙一" },
                    { 67, 0, "zh-cn", "和合本", false, "帖撒罗尼迦前书" },
                    { 67, 0, "zh-tw", "和合本", false, "帖撒羅尼迦前書" },
                    { 67, 1, "en", "NIV", false, "1Thess" },
                    { 67, 1, "es", "Reina-Valera 1960", false, "1Ts" },
                    { 67, 1, "ja", "新共同訳", false, "一テサ" },
                    { 67, 1, "zh-cn", "和合本", false, "帖前" },
                    { 67, 1, "zh-tw", "和合本", false, "帖前" },
                    { 68, 0, "en", "NIV", false, "2 Thessalonians" },
                    { 68, 0, "es", "Reina-Valera 1960", false, "2 Tesalonicenses" },
                    { 68, 0, "ja", "新共同訳", false, "テサロニケの信徒への手紙二" },
                    { 68, 0, "zh-cn", "和合本", false, "帖撒罗尼迦后书" },
                    { 68, 0, "zh-tw", "和合本", false, "帖撒羅尼迦後書" },
                    { 68, 1, "en", "NIV", false, "2Thess" },
                    { 68, 1, "es", "Reina-Valera 1960", false, "2Ts" },
                    { 68, 1, "ja", "新共同訳", false, "二テサ" },
                    { 68, 1, "zh-cn", "和合本", false, "帖后" },
                    { 68, 1, "zh-tw", "和合本", false, "帖後" },
                    { 69, 0, "en", "NIV", false, "1 Timothy" },
                    { 69, 0, "es", "Reina-Valera 1960", false, "1 Timoteo" },
                    { 69, 0, "ja", "新共同訳", false, "テモテへの手紙一" },
                    { 69, 0, "zh-cn", "和合本", false, "提摩太前书" },
                    { 69, 0, "zh-tw", "和合本", false, "提摩太前書" },
                    { 69, 1, "en", "NIV", false, "1Tim" },
                    { 69, 1, "es", "Reina-Valera 1960", false, "1Ti" },
                    { 69, 1, "ja", "新共同訳", false, "一テモ" },
                    { 69, 1, "zh-cn", "和合本", false, "提前" },
                    { 69, 1, "zh-tw", "和合本", false, "提前" },
                    { 70, 0, "en", "NIV", false, "2 Timothy" },
                    { 70, 0, "es", "Reina-Valera 1960", false, "2 Timoteo" },
                    { 70, 0, "ja", "新共同訳", false, "テモテへの手紙二" },
                    { 70, 0, "zh-cn", "和合本", false, "提摩太后书" },
                    { 70, 0, "zh-tw", "和合本", false, "提摩太後書" },
                    { 70, 1, "en", "NIV", false, "2Tim" },
                    { 70, 1, "es", "Reina-Valera 1960", false, "2Ti" },
                    { 70, 1, "ja", "新共同訳", false, "二テモ" },
                    { 70, 1, "zh-cn", "和合本", false, "提后" },
                    { 70, 1, "zh-tw", "和合本", false, "提後" },
                    { 71, 0, "en", "NIV", false, "Titus" },
                    { 71, 0, "es", "Reina-Valera 1960", false, "Tito" },
                    { 71, 0, "ja", "新共同訳", false, "テトスへの手紙" },
                    { 71, 0, "zh-cn", "和合本", false, "提多书" },
                    { 71, 0, "zh-tw", "和合本", false, "提多書" },
                    { 71, 1, "en", "NIV", false, "Titus" },
                    { 71, 1, "es", "Reina-Valera 1960", false, "Tit" },
                    { 71, 1, "ja", "新共同訳", false, "テト" },
                    { 71, 1, "zh-cn", "和合本", false, "多" },
                    { 71, 1, "zh-tw", "和合本", false, "多" },
                    { 72, 0, "en", "NIV", false, "Philemon" },
                    { 72, 0, "es", "Reina-Valera 1960", false, "Filemón" },
                    { 72, 0, "ja", "新共同訳", false, "フィレモンへの手紙" },
                    { 72, 0, "zh-cn", "和合本", false, "腓利门书" },
                    { 72, 0, "zh-tw", "和合本", false, "腓利門書" },
                    { 72, 1, "en", "NIV", false, "Phlm" },
                    { 72, 1, "es", "Reina-Valera 1960", false, "Flm" },
                    { 72, 1, "ja", "新共同訳", false, "フィレ" },
                    { 72, 1, "zh-cn", "和合本", false, "门" },
                    { 72, 1, "zh-tw", "和合本", false, "門" },
                    { 73, 0, "en", "NIV", false, "Hebrews" },
                    { 73, 0, "es", "Reina-Valera 1960", false, "Hebreos" },
                    { 73, 0, "ja", "新共同訳", false, "ヘブライ人への手紙" },
                    { 73, 0, "zh-cn", "和合本", false, "希伯来书" },
                    { 73, 0, "zh-tw", "和合本", false, "希伯來書" },
                    { 73, 1, "en", "NIV", false, "Heb" },
                    { 73, 1, "es", "Reina-Valera 1960", false, "He" },
                    { 73, 1, "ja", "新共同訳", false, "ヘブ" },
                    { 73, 1, "zh-cn", "和合本", false, "来" },
                    { 73, 1, "zh-tw", "和合本", false, "來" },
                    { 74, 0, "en", "NIV", false, "James" },
                    { 74, 0, "es", "Reina-Valera 1960", false, "Santiago" },
                    { 74, 0, "ja", "新共同訳", false, "ヤコブの手紙" },
                    { 74, 0, "zh-cn", "和合本", false, "雅各书" },
                    { 74, 0, "zh-tw", "和合本", false, "雅各書" },
                    { 74, 1, "en", "NIV", false, "Jas" },
                    { 74, 1, "es", "Reina-Valera 1960", false, "Stg" },
                    { 74, 1, "ja", "新共同訳", false, "ヤコ" },
                    { 74, 1, "zh-cn", "和合本", false, "雅" },
                    { 74, 1, "zh-tw", "和合本", false, "雅" },
                    { 75, 0, "en", "NIV", false, "1 Peter" },
                    { 75, 0, "es", "Reina-Valera 1960", false, "1 Pedro" },
                    { 75, 0, "ja", "新共同訳", false, "ペトロの手紙一" },
                    { 75, 0, "zh-cn", "和合本", false, "彼得前书" },
                    { 75, 0, "zh-tw", "和合本", false, "彼得前書" },
                    { 75, 1, "en", "NIV", false, "1Pet" },
                    { 75, 1, "es", "Reina-Valera 1960", false, "1P" },
                    { 75, 1, "ja", "新共同訳", false, "一ペト" },
                    { 75, 1, "zh-cn", "和合本", false, "彼前" },
                    { 75, 1, "zh-tw", "和合本", false, "彼前" },
                    { 76, 0, "en", "NIV", false, "2 Peter" },
                    { 76, 0, "es", "Reina-Valera 1960", false, "2 Pedro" },
                    { 76, 0, "ja", "新共同訳", false, "ペトロの手紙二" },
                    { 76, 0, "zh-cn", "和合本", false, "彼得后书" },
                    { 76, 0, "zh-tw", "和合本", false, "彼得後書" },
                    { 76, 1, "en", "NIV", false, "2Pet" },
                    { 76, 1, "es", "Reina-Valera 1960", false, "2P" },
                    { 76, 1, "ja", "新共同訳", false, "二ペト" },
                    { 76, 1, "zh-cn", "和合本", false, "彼后" },
                    { 76, 1, "zh-tw", "和合本", false, "彼後" },
                    { 77, 0, "en", "NIV", false, "1 John" },
                    { 77, 0, "es", "Reina-Valera 1960", false, "1 Juan" },
                    { 77, 0, "ja", "新共同訳", false, "ヨハネの手紙一" },
                    { 77, 0, "zh-cn", "和合本", false, "约翰一书" },
                    { 77, 0, "zh-tw", "和合本", false, "約翰一書" },
                    { 77, 1, "en", "NIV", false, "1John" },
                    { 77, 1, "es", "Reina-Valera 1960", false, "1Jn" },
                    { 77, 1, "ja", "新共同訳", false, "一ヨハ" },
                    { 77, 1, "zh-cn", "和合本", false, "约一" },
                    { 77, 1, "zh-tw", "和合本", false, "約壹" },
                    { 78, 0, "en", "NIV", false, "2 John" },
                    { 78, 0, "es", "Reina-Valera 1960", false, "2 Juan" },
                    { 78, 0, "ja", "新共同訳", false, "ヨハネの手紙二" },
                    { 78, 0, "zh-cn", "和合本", false, "约翰二书" },
                    { 78, 0, "zh-tw", "和合本", false, "約翰二書" },
                    { 78, 1, "en", "NIV", false, "2John" },
                    { 78, 1, "es", "Reina-Valera 1960", false, "2Jn" },
                    { 78, 1, "ja", "新共同訳", false, "二ヨハ" },
                    { 78, 1, "zh-cn", "和合本", false, "约二" },
                    { 78, 1, "zh-tw", "和合本", false, "約貳" },
                    { 79, 0, "en", "NIV", false, "3 John" },
                    { 79, 0, "es", "Reina-Valera 1960", false, "3 Juan" },
                    { 79, 0, "ja", "新共同訳", false, "ヨハネの手紙三" },
                    { 79, 0, "zh-cn", "和合本", false, "约翰三书" },
                    { 79, 0, "zh-tw", "和合本", false, "約翰三書" },
                    { 79, 1, "en", "NIV", false, "3John" },
                    { 79, 1, "es", "Reina-Valera 1960", false, "3Jn" },
                    { 79, 1, "ja", "新共同訳", false, "三ヨハ" },
                    { 79, 1, "zh-cn", "和合本", false, "约三" },
                    { 79, 1, "zh-tw", "和合本", false, "約參" },
                    { 80, 0, "en", "NIV", false, "Jude" },
                    { 80, 0, "es", "Reina-Valera 1960", false, "Judas" },
                    { 80, 0, "ja", "新共同訳", false, "ユダの手紙" },
                    { 80, 0, "zh-cn", "和合本", false, "犹大书" },
                    { 80, 0, "zh-tw", "和合本", false, "猶大書" },
                    { 80, 1, "en", "NIV", false, "Jude" },
                    { 80, 1, "es", "Reina-Valera 1960", false, "Jud" },
                    { 80, 1, "ja", "新共同訳", false, "ユダ" },
                    { 80, 1, "zh-cn", "和合本", false, "犹" },
                    { 80, 1, "zh-tw", "和合本", false, "猶" },
                    { 81, 0, "en", "NIV", false, "Revelation" },
                    { 81, 0, "es", "Reina-Valera 1960", false, "Apocalipsis" },
                    { 81, 0, "ja", "新共同訳", false, "ヨハネの黙示録" },
                    { 81, 0, "zh-cn", "和合本", false, "启示录" },
                    { 81, 0, "zh-tw", "和合本", false, "啟示錄" },
                    { 81, 1, "en", "NIV", false, "Rev" },
                    { 81, 1, "es", "Reina-Valera 1960", false, "Ap" },
                    { 81, 1, "ja", "新共同訳", false, "黙" },
                    { 81, 1, "zh-cn", "和合本", false, "启" },
                    { 81, 1, "zh-tw", "和合本", false, "啟" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 1, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 1, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 1, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 1, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 1, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 1, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 1, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 1, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 1, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 1, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 2, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 2, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 2, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 2, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 2, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 2, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 2, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 2, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 2, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 2, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 3, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 3, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 3, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 3, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 3, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 3, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 3, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 3, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 3, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 3, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 4, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 4, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 4, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 4, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 4, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 4, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 4, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 4, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 4, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 4, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 5, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 5, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 5, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 5, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 5, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 5, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 5, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 5, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 5, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 5, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 6, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 6, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 6, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 6, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 6, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 6, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 6, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 6, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 6, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 6, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 7, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 7, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 7, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 7, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 7, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 7, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 7, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 7, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 7, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 7, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 8, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 8, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 8, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 8, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 8, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 8, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 8, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 8, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 8, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 8, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 9, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 9, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 9, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 9, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 9, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 9, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 9, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 9, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 9, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 9, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 10, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 10, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 10, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 10, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 10, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 10, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 10, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 10, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 10, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 10, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 11, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 11, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 11, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 11, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 11, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 11, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 11, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 11, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 11, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 11, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 12, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 12, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 12, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 12, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 12, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 12, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 12, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 12, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 12, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 12, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 13, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 13, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 13, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 13, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 13, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 13, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 13, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 13, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 13, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 13, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 14, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 14, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 14, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 14, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 14, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 14, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 14, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 14, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 14, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 14, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 15, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 15, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 15, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 15, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 15, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 15, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 15, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 15, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 15, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 15, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 16, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 16, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 16, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 16, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 16, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 16, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 16, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 16, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 16, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 16, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 17, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 17, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 17, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 17, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 17, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 17, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 17, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 17, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 17, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 17, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 18, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 18, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 18, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 18, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 18, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 18, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 18, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 18, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 18, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 18, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 19, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 19, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 19, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 19, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 19, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 19, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 19, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 19, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 19, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 19, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 20, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 20, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 20, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 20, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 20, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 20, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 20, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 20, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 20, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 20, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 21, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 21, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 21, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 21, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 21, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 21, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 21, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 21, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 21, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 21, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 22, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 22, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 22, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 22, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 22, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 22, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 22, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 22, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 22, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 22, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 23, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 23, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 23, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 23, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 23, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 23, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 23, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 23, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 23, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 23, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 24, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 24, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 24, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 24, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 24, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 24, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 24, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 24, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 24, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 24, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 25, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 25, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 25, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 25, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 25, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 25, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 25, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 25, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 25, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 25, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 26, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 26, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 26, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 26, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 26, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 26, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 26, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 26, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 26, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 26, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 27, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 27, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 27, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 27, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 27, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 27, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 27, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 27, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 27, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 27, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 28, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 28, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 28, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 28, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 28, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 28, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 28, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 28, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 28, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 28, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 29, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 29, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 29, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 29, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 29, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 29, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 29, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 29, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 29, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 29, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 30, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 30, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 30, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 30, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 30, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 30, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 30, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 30, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 30, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 30, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 31, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 31, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 31, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 31, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 31, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 31, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 31, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 31, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 31, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 31, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 32, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 32, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 32, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 32, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 32, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 32, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 32, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 32, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 32, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 32, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 33, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 33, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 33, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 33, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 33, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 33, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 33, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 33, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 33, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 33, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 34, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 34, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 34, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 34, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 34, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 34, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 34, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 34, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 34, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 34, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 35, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 35, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 35, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 35, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 35, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 35, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 35, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 35, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 35, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 35, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 36, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 36, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 36, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 36, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 36, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 36, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 36, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 36, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 36, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 36, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 37, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 37, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 37, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 37, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 37, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 37, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 37, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 37, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 37, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 37, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 38, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 38, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 38, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 38, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 38, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 38, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 38, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 38, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 38, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 38, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 39, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 39, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 39, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 39, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 39, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 39, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 39, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 39, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 39, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 39, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 55, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 55, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 55, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 55, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 55, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 55, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 55, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 55, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 55, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 55, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 56, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 56, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 56, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 56, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 56, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 56, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 56, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 56, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 56, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 56, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 57, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 57, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 57, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 57, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 57, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 57, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 57, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 57, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 57, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 57, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 58, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 58, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 58, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 58, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 58, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 58, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 58, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 58, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 58, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 58, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 59, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 59, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 59, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 59, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 59, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 59, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 59, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 59, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 59, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 59, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 60, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 60, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 60, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 60, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 60, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 60, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 60, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 60, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 60, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 60, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 61, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 61, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 61, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 61, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 61, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 61, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 61, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 61, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 61, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 61, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 62, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 62, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 62, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 62, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 62, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 62, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 62, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 62, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 62, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 62, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 63, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 63, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 63, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 63, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 63, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 63, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 63, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 63, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 63, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 63, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 64, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 64, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 64, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 64, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 64, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 64, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 64, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 64, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 64, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 64, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 65, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 65, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 65, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 65, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 65, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 65, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 65, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 65, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 65, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 65, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 66, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 66, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 66, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 66, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 66, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 66, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 66, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 66, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 66, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 66, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 67, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 67, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 67, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 67, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 67, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 67, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 67, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 67, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 67, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 67, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 68, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 68, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 68, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 68, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 68, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 68, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 68, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 68, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 68, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 68, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 69, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 69, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 69, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 69, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 69, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 69, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 69, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 69, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 69, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 69, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 70, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 70, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 70, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 70, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 70, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 70, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 70, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 70, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 70, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 70, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 71, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 71, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 71, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 71, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 71, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 71, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 71, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 71, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 71, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 71, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 72, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 72, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 72, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 72, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 72, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 72, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 72, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 72, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 72, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 72, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 73, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 73, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 73, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 73, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 73, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 73, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 73, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 73, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 73, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 73, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 74, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 74, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 74, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 74, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 74, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 74, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 74, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 74, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 74, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 74, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 75, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 75, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 75, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 75, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 75, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 75, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 75, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 75, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 75, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 75, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 76, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 76, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 76, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 76, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 76, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 76, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 76, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 76, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 76, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 76, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 77, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 77, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 77, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 77, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 77, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 77, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 77, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 77, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 77, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 77, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 78, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 78, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 78, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 78, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 78, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 78, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 78, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 78, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 78, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 78, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 79, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 79, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 79, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 79, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 79, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 79, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 79, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 79, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 79, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 79, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 80, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 80, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 80, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 80, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 80, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 80, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 80, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 80, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 80, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 80, 1, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 81, 0, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 81, 0, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 81, 0, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 81, 0, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 81, 0, "zh-tw", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 81, 1, "en", "NIV" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 81, 1, "es", "Reina-Valera 1960" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 81, 1, "ja", "新共同訳" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 81, 1, "zh-cn", "和合本" });

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumns: new[] { "Key", "Kind", "LanguageCode", "Version" },
                keyValues: new object[] { 81, 1, "zh-tw", "和合本" });
        }
    }
}
