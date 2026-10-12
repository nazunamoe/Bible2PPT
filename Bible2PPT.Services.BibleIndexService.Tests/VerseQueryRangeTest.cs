using System.Globalization;

namespace Bible2PPT.Services.BibleIndexService.Tests;

public class VerseQueryRangeTest
{
    [Theory]
    [InlineData("4", 4, 1, 4, null)]
    [InlineData("4-9", 4, 1, 9, null)]
    [InlineData("4-9:8", 4, 1, 9, 8)]
    [InlineData("4:3", 4, 3, 4, 3)]
    [InlineData("4:3-8", 4, 3, 4, 8)]
    [InlineData("4:3-9:8", 4, 3, 9, 8)]
    public void Parse_Success(string s, int startChapter, int startVerse, int? endChapter, int? endVerse)
    {
        VerseQueryRange.TryParse(s, CultureInfo.InvariantCulture, out var result).ShouldBeTrue();

        result.StartChapterNumber.ShouldBe(startChapter);
        result.StartVerseNumber.ShouldBe(startVerse);
        result.EndChapterNumber.ShouldBe(endChapter);
        result.EndVerseNumber.ShouldBe(endVerse);
    }

    [Theory]
    [InlineData("")]
    [InlineData("GEN")]
    [InlineData("1SAM")]
    public void Parse_BookAbbr_Fail(string s)
    {
        VerseQueryRange.TryParse(s, CultureInfo.InvariantCulture, out _).ShouldBeFalse();
    }

    [Theory]
    // int 범위를 넘는 숫자
    [InlineData("99999999999")]
    [InlineData("1:99999999999")]
    // ASCII가 아닌 숫자 (전각, 아랍-인도 숫자)
    [InlineData("１")]
    [InlineData("1:１")]
    [InlineData("١")]
    // 0장, 0절
    [InlineData("0")]
    [InlineData("1:0")]
    [InlineData("1-3:0")]
    // 끝이 시작보다 앞서는 범위
    [InlineData("3-1")]
    [InlineData("1:5-3")]
    [InlineData("2:5-1:9")]
    public void Parse_InvalidRange_Fail(string s)
    {
        VerseQueryRange.TryParse(s, CultureInfo.InvariantCulture, out _).ShouldBeFalse();
    }

    [Theory]
    [InlineData("1:5-5", 1, 5, 1, 5)]
    [InlineData("1:5-2:1", 1, 5, 2, 1)]
    [InlineData("3-3", 3, 1, 3, null)]
    public void Parse_Boundary_Success(string s, int startChapter, int startVerse, int? endChapter, int? endVerse)
    {
        VerseQueryRange.TryParse(s, CultureInfo.InvariantCulture, out var result).ShouldBeTrue();

        result.StartChapterNumber.ShouldBe(startChapter);
        result.StartVerseNumber.ShouldBe(startVerse);
        result.EndChapterNumber.ShouldBe(endChapter);
        result.EndVerseNumber.ShouldBe(endVerse);
    }
}
