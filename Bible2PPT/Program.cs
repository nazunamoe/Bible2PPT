using System;
using System.Configuration;
using System.Text;
using System.Windows.Forms;
using Bible2PPT.PPT;
using Bible2PPT.Services;
using Bible2PPT.Services.BibleIndexService;
using Bible2PPT.Services.BibleService;
using Bible2PPT.Services.BuildService;
using Bible2PPT.Services.TemplateService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;

namespace Bible2PPT
{
    static class Program
    {
        static IServiceProvider ServiceProvider { get; set; }

        [STAThread]
        static int Main(string[] args)
        {
            // 인자가 있으면 화면 없이 명령줄로 PPT를 만듦
            if (args.Length > 0)
            {
                return CommandLine.Run(args);
            }

            // GDI+는 처음 초기화될 때의 DPI를 기억하므로 글꼴을 만들기 전에 DPI 모드를 먼저 설정해야 함
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetDefaultFont(new System.Drawing.Font("Gulim", 9));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices(ex =>
            {
                MessageBox.Show(
                    $"마이크로소프트 파워포인트가 설치되어 있나요?\n\n자세한 오류: {ex}",
                    @"프로그램 초기화 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // TODO: GitHub로 오류 포스팅하도록 안내하기 (전역 예외 처리기 사용)
                Environment.Exit(0);
            });
            new Startup().Run(args);
            return 0;
        }

        internal static IServiceProvider ConfigureServices(Action<Exception> interopInitializeErrorAction)
        {
            var services = new ServiceCollection();

            services.AddTransient<SplashForm>();
            services.AddTransient<MainForm>();
            services.AddBibleIndexService(options => options.UseSqlite("Data Source=bindex-v3.db"));
            services.AddBibleService(
                dbContextOptionsAction: options =>
                    options.UseSqlite(ConfigurationManager.ConnectionStrings["BibleContext"].ConnectionString));
            services.AddBuildService(
                dbContextOptionsAction: options => options.UseSqlite("Data Source=build-v3.db"),
                interopInitializeErrorAction: interopInitializeErrorAction);
            services.AddTemplateService();

            ServiceProvider = services.BuildServiceProvider();

            ServiceProvider.UseBibleIndexService();
            ServiceProvider.UseBibleService();
            ServiceProvider.UseBuildService();

            return ServiceProvider;
        }

        class Startup : WindowsFormsApplicationBase
        {
            protected override void OnCreateSplashScreen()
            {
                SplashScreen = ServiceProvider.GetService<SplashForm>();
            }

            protected override void OnCreateMainForm()
            {
                MainForm = ServiceProvider.GetRequiredService<MainForm>();
            }
        }
    }
}
