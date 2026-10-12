using System.IO;
using Bible2PPT.PPT;
using Xunit;

namespace Bible2PPT.Tests.PPT
{
    public class BuilderTest
    {
        private const string OutputDirectory = @"C:\out";

        [Theory]
        [InlineData("창세기", @"C:\out\창세기\001.pptx")]
        [InlineData("Song of Songs", @"C:\out\Song of Songs\001.pptx")]
        // 경로 구분자, 드라이브 문자, 상위 폴더 참조
        [InlineData(@"..\..\Users\Public", @"C:\out\.._.._Users_Public\001.pptx")]
        [InlineData(@"C:\Windows\Temp", @"C:\out\C__Windows_Temp\001.pptx")]
        [InlineData("a/b", @"C:\out\a_b\001.pptx")]
        [InlineData("..", @"C:\out\_\001.pptx")]
        [InlineData("", @"C:\out\_\001.pptx")]
        // 폴더 이름으로 쓸 수 없는 문자와 이름
        [InlineData("1:2?", @"C:\out\1_2_\001.pptx")]
        [InlineData("name. ", @"C:\out\name\001.pptx")]
        [InlineData("CON", @"C:\out\_CON\001.pptx")]
        [InlineData("nul.txt", @"C:\out\_nul.txt\001.pptx")]
        public void GetSplitOutputPath_StaysInOutputDirectory(string bookName, string expected)
        {
            Assert.Equal(expected, Builder.GetSplitOutputPath(OutputDirectory, bookName, 1));
        }

        [Fact]
        public void GetSplitOutputPath_TrailingSeparator()
        {
            Assert.Equal(@"C:\out\창세기\050.pptx", Builder.GetSplitOutputPath(@"C:\out\", "창세기", 50));
        }

        [Fact]
        public void GetSplitOutputPath_DriveRoot()
        {
            Assert.Equal(Path.Combine(@"C:\", "창세기", "001.pptx"), Builder.GetSplitOutputPath(@"C:\", "창세기", 1));
        }
    }
}
