using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace Bible2PPT.Services.BibleIndexService;

public class VerseQueryRange //: ISpanParsable<VerseQueryRange>
{
    // \d는 전각 숫자 등 유니코드 숫자도 허용해서 int로 변환할 때 예외가 발생하므로 ASCII 숫자만 허용
    private static readonly Regex _regex = new(@"^(?<chapFrom>[0-9]+)(?::(?<versFrom>[0-9]+))?(?:-(?<chapTo>[0-9]+)(?::(?<versTo>[0-9]+))?)?$", RegexOptions.Compiled);

    public int StartChapterNumber { get; set; } = 1;
    public int StartVerseNumber { get; set; } = 1;
    public int? EndChapterNumber { get; set; }
    public int? EndVerseNumber { get; set; }

    public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [NotNullWhen(true)] out VerseQueryRange? result)
    {
        result = new();
        try
        {
            if (!TryParseCore(s, provider, result))
            {
                return false;
            }
        }
        // 장, 절 번호가 int 범위를 넘으면 해석할 수 없는 구절로 취급
        catch (OverflowException)
        {
            return false;
        }

        return IsValid(result);
    }

    /// <summary>
    /// 0장, 0절이나 끝이 시작보다 앞서는 범위는 만들 PPT가 없으므로 잘못된 구절로 취급한다.
    /// </summary>
    private static bool IsValid(VerseQueryRange range)
    {
        if (range.StartChapterNumber < 1 || range.StartVerseNumber < 1)
        {
            return false;
        }

        if (range.EndChapterNumber < range.StartChapterNumber || range.EndVerseNumber < 1)
        {
            return false;
        }

        // 같은 장 안의 범위이면 끝 절이 시작 절보다 앞설 수 없음
        return !(range.EndChapterNumber == range.StartChapterNumber && range.EndVerseNumber < range.StartVerseNumber);
    }

    private static bool TryParseCore(ReadOnlySpan<char> s, IFormatProvider? provider, VerseQueryRange result)
    {
        var match = _regex.Match(s.ToString());
        if (!match.Success)
        {
            return false;
        }

        // PPT 범위를 한 장으로 설정했을 때
        // 예) 창1       = 창세기 1장 전체
        result.StartChapterNumber = int.Parse(match.Groups["chapFrom"].Value, provider);
        result.EndChapterNumber = result.StartChapterNumber;
        if (string.IsNullOrEmpty(match.Groups["versFrom"].Value))
        {
            if (string.IsNullOrEmpty(match.Groups["chapTo"].Value))
            {
                return true;
            }

            // PPT 범위를 여러 장으로 설정했을 때
            // 예) 롬1-3     = 로마서 1장 1절 - 3장 전체
            result.EndChapterNumber = int.Parse(match.Groups["chapTo"].Value, provider);
            if (string.IsNullOrEmpty(match.Groups["versTo"].Value))
            {
                return true;
            }

            // PPT 범위를 여러 장과 여러 절을 설정했을 때
            // 예) 레1-3:9   = 레위기 1장 1절 - 3장 9절
            result.EndVerseNumber = int.Parse(match.Groups["versTo"].Value, provider);
            return true;
        }

        // PPT 범위를 한 절로 설정했을 때
        // 예) 전1:3     = 전도서 1장 3절
        result.StartVerseNumber = int.Parse(match.Groups["versFrom"].Value, provider);
        result.EndVerseNumber = result.StartVerseNumber;
        if (string.IsNullOrEmpty(match.Groups["chapTo"].Value))
        {
            return true;
        }

        // PPT 범위를 한 장에 여러 절로 설정했을 때
        // 예) 스1:3-9   = 에스라 1장 3절 - 1장 9절
        if (string.IsNullOrEmpty(match.Groups["versTo"].Value))
        {
            result.EndVerseNumber = int.Parse(match.Groups["chapTo"].Value, provider);
            return true;
        }

        // PPT 범위를 여러 장에 여러 절로 설정했을 때
        // 예) 사1:3-3:9 = 이사야 1장 3절 - 3장 9절
        result.EndChapterNumber = int.Parse(match.Groups["chapTo"].Value, provider);
        result.EndVerseNumber = int.Parse(match.Groups["versTo"].Value, provider);
        return true;
    }
}
