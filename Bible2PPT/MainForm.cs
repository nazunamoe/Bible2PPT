using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Bible2PPT.Controls;
using Bible2PPT.PPT;
using Bible2PPT.Services.BibleService;
using Bible2PPT.Services.TemplateService;
using FontAwesome.Sharp;

namespace Bible2PPT
{
    internal partial class MainForm : AssemblyIconForm
    {
        private readonly Builder _builder;
        private readonly BibleService _bibleService;
        private readonly TemplateService _templateService;

        private readonly Dictionary<int, CancellationTokenSource> workCts = new Dictionary<int, CancellationTokenSource>();

        public MainForm(Builder builder, BibleService bibleService, TemplateService templateService)
        {
            _builder = builder;
            _bibleService = bibleService;
            _templateService = templateService;

            InitializeComponent();
            InitializeBuildComponent();
            InitializeHistoryComponent();
            InitializeTemplatesComponent();
            InitializeSettingsComponent();
            ScaleIconSizes(this);

            // TODO: 마지막 페이지 기억하기
            mainMultiPanel.SelectedPage = buildMultiPanelPage;
        }

        // IconButton의 아이콘 크기는 픽셀 단위라 자동 스케일링되지 않으므로 DPI에 맞게 직접 키움
        // (IconPictureBox는 컨트롤 크기에 맞춰 아이콘을 다시 그리므로 제외)
        private void ScaleIconSizes(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is IconButton button)
                {
                    button.IconSize = LogicalToDeviceUnits(button.IconSize);
                }
                ScaleIconSizes(control);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AppConfig.Context.Save();
        }

        private Button[] Navs => new[]
        {
            buildNavButton,
            historyNavButton,
            templatesNavButton,
            settingsNavButton,
        };

        private void MainMultiPanel_SelectedPanelChanged(object sender, EventArgs e)
        {
            // 제목 표시줄에 페이지 제목 추가
            Text = $"{mainMultiPanel.SelectedPage.Text} - 성경2PPT";
            var targetButton = mainMultiPanel.SelectedPage.Name switch
            {
                nameof(buildMultiPanelPage) => buildNavButton,
                nameof(historyMultiPanelPage) => historyNavButton,
                nameof(templatesMultiPanelPage) => templatesNavButton,
                nameof(settingsMultiPanelPage) => settingsNavButton,
                _ => throw new NotImplementedException(mainMultiPanel.SelectedPage.Name),
            };
            // 연결된 Nav만 비활성화
            foreach (var nav in Navs)
            {
                nav.Enabled = true;
            }
            targetButton.Enabled = false;
        }

        private void Nav_Click(object sender, EventArgs e)
        {
            var targetPage = (sender as Control).Name switch
            {
                nameof(buildNavButton) => buildMultiPanelPage,
                nameof(historyNavButton) => historyMultiPanelPage,
                nameof(templatesNavButton) => templatesMultiPanelPage,
                nameof(settingsNavButton) => settingsMultiPanelPage,
                _ => throw new NotImplementedException((sender as Control).Name),
            };
            // 연결된 페이지 활성화
            mainMultiPanel.SelectedPage = targetPage;
        }
    }
}
