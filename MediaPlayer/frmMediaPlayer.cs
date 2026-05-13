using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class frmMediaPlayer : Form
    {
        public frmMediaPlayer()
        {
            InitializeComponent();
        }

        private void frmMediaPlayer_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            // 控制列頂端紫色漸層線（Paint 事件）
            palButton.Paint += (s, pe) =>
            {
                using (var b = new LinearGradientBrush(
                    new Rectangle(0, 0, palButton.Width, 3),
                    ColorTranslator.FromHtml("#A855F7"),
                    ColorTranslator.FromHtml("#EC4899"),
                    LinearGradientMode.Horizontal))
                {
                    pe.Graphics.FillRectangle(b, 0, 0, palButton.Width, 3);
                }
            };
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "影片檔案 (*.wmv;*.mp4;*.avi)|*.wmv;*.mp4;*.avi|所有檔案 (*.*)|*.*";
            ofd.Title  = "選擇影片檔案";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                wmpVideo.URL = ofd.FileName;
                wmpVideo.Ctlcontrols.stop();

                // 顯示檔名
                lblFileName.Text      = $"📄 {Path.GetFileName(ofd.FileName)}";
                lblFileName.ForeColor = ColorTranslator.FromHtml("#C4A8E0");

                btnPlay.Enabled  = true;
                btnPause.Enabled = true;
                btnStop.Enabled  = true;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.stop();
        }

        private void frmMediaPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("確定要關閉應用程式嗎？", "關閉確認",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}
