using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bible2PPT.Bibles;
using Bible2PPT.PPT;
using Bible2PPT.Services.BibleIndexService;
using Bible2PPT.Services.BibleService;
using Bible2PPT.Services.TemplateService;
using Bible2PPT.Sources;
using Microsoft.Extensions.DependencyInjection;
using Windows.Win32;
using Windows.Win32.System.Console;

namespace Bible2PPT
{
    /// <summary>
    /// 화면 없이 명령줄 인자로 PPT를 만든다.
    /// 다른 프로그램에서 호출할 수 있도록 결과 경로는 표준 출력으로, 오류는 표준 오류와 종료 코드로 알린다.
    /// </summary>
    internal static class CommandLine
    {
        private const int ExitSuccess = 0;
        private const int ExitInvalidArguments = 1;
        private const int ExitBuildFailed = 2;
        private const int ExitPowerPointUnavailable = 3;

        private const string Usage = @"사용법: Bible2PPT.exe <성경 구절...> [옵션]
       Bible2PPT.exe --list-bibles

성경 구절은 프로그램의 구절 입력 칸과 같은 형식입니다. 예) 요3:16 롬8:28-39

옵션:
  -o, --output <경로>    PPT를 저장할 경로 (--split이면 폴더)
                         생략하면 임시 파일로 만들고 파워포인트로 엽니다.
  -b, --bible <성경>     사용할 성경의 ID 또는 이름 (여러 번 지정하면 나란히 배치)
                         생략하면 프로그램에서 마지막으로 고른 성경을 사용합니다.
  -t, --template <경로>  사용할 템플릿 .pptx (생략하면 프로그램 템플릿)
  -l, --lines <0-9>      슬라이드당 성경 구절 줄 수 (0: 제한 없음)
  -s, --split            장별로 PPT 나누기 (--output 필수)
      --open             완료 후 PPT 열기 (--output을 생략하면 항상 엶)
      --list-bibles      사용할 수 있는 성경의 ID와 이름 출력
  -h, --help             도움말 출력

종료 코드: 0 성공, 1 잘못된 인자, 2 PPT 만들기 실패, 3 파워포인트 초기화 실패";

        private class Options
        {
            public List<string> Verses { get; } = new List<string>();
            public List<string> Bibles { get; } = new List<string>();
            public string Output { get; set; }
            public string Template { get; set; }
            public int? NumberOfVerseLinesPerSlide { get; set; }
            public bool SplitChaptersIntoFiles { get; set; }
            public bool Open { get; set; }
            public bool ListBibles { get; set; }
            public bool Help { get; set; }
        }

        private class CommandLineException : Exception
        {
            public CommandLineException(string message) : base(message)
            {
            }
        }

        public static int Run(string[] args)
        {
            AttachParentConsole();

            Options options;
            try
            {
                options = Parse(args);
            }
            catch (CommandLineException ex)
            {
                Console.Error.WriteLine(ex.Message);
                Console.Error.WriteLine("도움말: Bible2PPT.exe --help");
                return ExitInvalidArguments;
            }

            if (options.Help)
            {
                Console.WriteLine(Usage);
                return ExitSuccess;
            }

            // DB 파일 경로가 상대 경로이므로 다른 폴더에서 호출해도 프로그램 폴더의 DB를 사용하도록 맞춤
            // (사용자가 입력한 경로는 Parse에서 이미 절대 경로로 바꿈)
            Environment.CurrentDirectory = Path.GetDirectoryName(Application.ExecutablePath);

            // 파워포인트 COM 개체를 MTA 스레드에서 만들어서
            // 메시지 루프가 없는 STA 주 스레드로 호출이 마샬링되지 않게 함
            return Task.Run(() => RunAsync(options)).GetAwaiter().GetResult();
        }

        private static async Task<int> RunAsync(Options options)
        {
            var serviceProvider = Program.ConfigureServices(ex =>
            {
                Console.Error.WriteLine($"파워포인트를 초기화하지 못했습니다. 마이크로소프트 파워포인트가 설치되어 있나요?\n\n자세한 오류: {ex}");
                Environment.Exit(ExitPowerPointUnavailable);
            });

            try
            {
                if (options.ListBibles)
                {
                    await ListBiblesAsync(serviceProvider.GetRequiredService<BibleService>()).ConfigureAwait(false);
                    return ExitSuccess;
                }

                return await BuildAsync(serviceProvider, options).ConfigureAwait(false);
            }
            catch (CommandLineException ex)
            {
                Console.Error.WriteLine(ex.Message);
                return ExitInvalidArguments;
            }
            finally
            {
                // 숨겨진 파워포인트를 종료하고 작업 관리자를 정리
                if (serviceProvider is IAsyncDisposable disposable)
                {
                    await disposable.DisposeAsync().ConfigureAwait(false);
                }

                // 파워포인트는 COM 참조가 남아 있으면 Quit 후에도 종료되지 않으므로
                // 프로그램이 끝나기 전에 남은 COM 개체를 해제
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private static Options Parse(string[] args)
        {
            var options = new Options();

            for (var i = 0; i < args.Length; i++)
            {
                var arg = args[i];
                switch (arg)
                {
                    case "-o":
                    case "--output":
                        options.Output = Path.GetFullPath(NextValue());
                        break;
                    case "-b":
                    case "--bible":
                        options.Bibles.Add(NextValue());
                        break;
                    case "-t":
                    case "--template":
                        options.Template = Path.GetFullPath(NextValue());
                        if (!File.Exists(options.Template))
                        {
                            throw new CommandLineException($"템플릿 파일이 없습니다: {options.Template}");
                        }
                        break;
                    case "-l":
                    case "--lines":
                        if (!int.TryParse(NextValue(), out var lines) || lines < 0 || lines > 9)
                        {
                            throw new CommandLineException($"{arg}에는 0부터 9까지의 숫자를 입력하세요.");
                        }
                        options.NumberOfVerseLinesPerSlide = lines;
                        break;
                    case "-s":
                    case "--split":
                        options.SplitChaptersIntoFiles = true;
                        break;
                    case "--open":
                        options.Open = true;
                        break;
                    case "--list-bibles":
                        options.ListBibles = true;
                        break;
                    case "-h":
                    case "--help":
                    case "/?":
                        options.Help = true;
                        break;
                    default:
                        if (arg.StartsWith("--"))
                        {
                            throw new CommandLineException($"알 수 없는 옵션입니다: {arg}");
                        }
                        options.Verses.Add(arg);
                        break;
                }

                string NextValue()
                {
                    if (i + 1 >= args.Length)
                    {
                        throw new CommandLineException($"{arg} 뒤에 값을 입력하세요.");
                    }
                    return args[++i];
                }
            }

            if (options.Help || options.ListBibles)
            {
                return options;
            }

            if (!options.Verses.Any())
            {
                throw new CommandLineException("PPT로 만들 성경 구절을 입력하세요.");
            }

            if (options.SplitChaptersIntoFiles && options.Output == null)
            {
                throw new CommandLineException("장별로 PPT를 나누려면 --output으로 저장할 폴더를 지정하세요.");
            }

            return options;
        }

        private static async Task ListBiblesAsync(BibleService bibleService)
        {
            Console.WriteLine("ID\t소스\t성경");
            foreach (var source in BibleSource.AvailableSources)
            {
                List<Bible> bibles;
                try
                {
                    bibles = await bibleService.GetBiblesAsync(source).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine($"{source.Name}의 성경 목록을 가져오지 못했습니다: {ex.Message}");
                    continue;
                }

                foreach (var bible in bibles)
                {
                    Console.WriteLine($"{bible.Id}\t{source.Name}\t{bible.Name}");
                }
            }
        }

        private static async Task<int> BuildAsync(IServiceProvider serviceProvider, Options options)
        {
            var queryString = Regex.Replace(string.Join(" ", options.Verses).Trim(), @"\s+", " ");
            try
            {
                serviceProvider.GetRequiredService<VerseQueryParser>().ParseVerseQueries(queryString);
            }
            catch (InvalidOperationException)
            {
                throw new CommandLineException($"성경 구절을 해석할 수 없습니다: {queryString}");
            }

            var bibles = await FindBiblesAsync(serviceProvider.GetRequiredService<BibleService>(), options.Bibles).ConfigureAwait(false);

            if (options.Template == null)
            {
                MainForm.ExtractDefaultTemplate();
            }

            var job = new Job
            {
                Bibles = bibles,
                CreatedAt = DateTime.Now,
                SplitChaptersIntoFiles = options.SplitChaptersIntoFiles,
                OutputDestination = options.Output ?? $"{Path.GetTempFileName()}.pptx",
                QueryString = queryString,
                Template = new Template
                {
                    FileName = options.Template ?? AppConfig.TemplatePath,
                    BookNameVisible = AppConfig.Context.ShowLongTitle,
                    BookAbbrVisible = AppConfig.Context.ShowShortTitle,
                    ChapterNumberVisible = AppConfig.Context.ShowChapterNumber,
                    NumberOfVerseLinesPerSlide = options.NumberOfVerseLinesPerSlide ?? AppConfig.Context.NumberOfVerseLinesPerSlide,
                },
            };

            var builder = serviceProvider.GetRequiredService<Builder>();
            var completion = new TaskCompletionSource<JobCompletedEventArgs>(TaskCreationOptions.RunContinuationsAsynchronously);
            builder.SubscribeJob(new Progress<EventArgs>(e =>
            {
                if (e is JobCompletedEventArgs completed && completed.Job == job)
                {
                    completion.TrySetResult(completed);
                }
            }));

            // PPT 만들기
            builder.Queue(job);
            var result = await completion.Task.ConfigureAwait(false);

            if (result.IsFaulted)
            {
                Console.Error.WriteLine($"PPT를 만들지 못했습니다.\n\n자세한 오류: {result.Exception}");
                return ExitBuildFailed;
            }

            // 다른 프로그램에서 결과를 이어서 쓸 수 있도록 저장 경로를 출력
            Console.WriteLine(job.OutputDestination);

            if (options.Open || options.Output == null)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = job.OutputDestination,
                    UseShellExecute = true,
                });
            }

            return ExitSuccess;
        }

        private static async Task<List<Bible>> FindBiblesAsync(BibleService bibleService, List<string> names)
        {
            // 지정하지 않으면 프로그램에서 마지막으로 고른 성경을 사용
            if (!names.Any())
            {
                var lastBibles = AppConfig.Context.BibleToBuild
                    .Select(bibleService.FindBible)
                    .Where(bible => bible is { Source: not null })
                    .ToList();
                if (!lastBibles.Any())
                {
                    throw new CommandLineException("사용할 성경을 --bible로 지정하세요. 성경 목록: Bible2PPT.exe --list-bibles");
                }
                return lastBibles;
            }

            var bibles = new List<Bible>();
            List<Bible> allBibles = null;
            foreach (var name in names)
            {
                // 숫자이면 ID로 찾기
                if (int.TryParse(name, out var id))
                {
                    var bible = bibleService.FindBible(id);
                    if (bible is not { Source: not null })
                    {
                        throw new CommandLineException($"ID가 {id}인 성경이 없습니다. 성경 목록: Bible2PPT.exe --list-bibles");
                    }
                    bibles.Add(bible);
                    continue;
                }

                // 이름으로 찾되, 같은 이름이 여러 소스에 있으면 프로그램에서 마지막으로 고른 소스를 우선
                allBibles ??= await GetAllBiblesAsync(bibleService).ConfigureAwait(false);
                var matched = allBibles
                    .Where(bible => bible.Name == name)
                    .OrderBy(bible => bible.SourceId == AppConfig.Context.BibleSourceId ? 0 : 1)
                    .FirstOrDefault();
                if (matched == null)
                {
                    throw new CommandLineException($"이름이 {name}인 성경이 없습니다. 성경 목록: Bible2PPT.exe --list-bibles");
                }
                bibles.Add(matched);
            }
            return bibles;
        }

        private static async Task<List<Bible>> GetAllBiblesAsync(BibleService bibleService)
        {
            var bibles = new List<Bible>();
            foreach (var source in BibleSource.AvailableSources)
            {
                try
                {
                    bibles.AddRange(await bibleService.GetBiblesAsync(source).ConfigureAwait(false));
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine($"{source.Name}의 성경 목록을 가져오지 못했습니다: {ex.Message}");
                }
            }
            return bibles;
        }

        /// <summary>
        /// 이 프로그램은 창 프로그램이라 콘솔이 없으므로, 명령 프롬프트에서 실행하면 그 콘솔에 출력하도록 연결한다.
        /// 다른 프로그램이 출력을 파이프나 파일로 받는 중이면 시스템 코드 페이지 대신 UTF-8로 출력한다.
        /// </summary>
        private static void AttachParentConsole()
        {
            if (PInvoke.GetStdHandle(STD_HANDLE.STD_OUTPUT_HANDLE) == IntPtr.Zero)
            {
                PInvoke.AttachConsole(PInvoke.ATTACH_PARENT_PROCESS);
                return;
            }

            var utf8 = new UTF8Encoding(false);
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput(), utf8) { AutoFlush = true });
            Console.SetError(new StreamWriter(Console.OpenStandardError(), utf8) { AutoFlush = true });
        }
    }
}
