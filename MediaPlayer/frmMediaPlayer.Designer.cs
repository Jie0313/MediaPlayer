namespace MediaPlayer
{
    partial class frmMediaPlayer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        private void InitializeComponent()
        {
            // ※ resources 與 wmpVideo.OcxState 不可更動，與 .resx 綁定
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMediaPlayer));
            this.wmpVideo    = new AxWMPLib.AxWindowsMediaPlayer();
            this.palButton   = new System.Windows.Forms.Panel();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnBrowser  = new System.Windows.Forms.Button();
            this.btnPlay     = new System.Windows.Forms.Button();
            this.btnPause    = new System.Windows.Forms.Button();
            this.btnStop     = new System.Windows.Forms.Button();

            this.palButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).BeginInit();
            this.SuspendLayout();

            var fntBtn = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Bold);

            // ── wmpVideo（不可更動）────────────────────────────────
            this.wmpVideo.Dock     = System.Windows.Forms.DockStyle.Fill;
            this.wmpVideo.Enabled  = true;
            this.wmpVideo.Location = new System.Drawing.Point(0, 0);
            this.wmpVideo.Name     = "wmpVideo";
            this.wmpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideo.OcxState")));
            this.wmpVideo.Size     = new System.Drawing.Size(796, 480);
            this.wmpVideo.TabIndex = 0;

            // ── palButton ─────────────────────────────────────────
            this.palButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#16213E");
            this.palButton.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.palButton.Location  = new System.Drawing.Point(0, 366);
            this.palButton.Name      = "palButton";
            this.palButton.Size      = new System.Drawing.Size(796, 114);
            this.palButton.TabIndex  = 1;
            this.palButton.Controls.Add(this.lblFileName);
            this.palButton.Controls.Add(this.btnBrowser);
            this.palButton.Controls.Add(this.btnPlay);
            this.palButton.Controls.Add(this.btnPause);
            this.palButton.Controls.Add(this.btnStop);

            // ── lblFileName ───────────────────────────────────────
            this.lblFileName.AutoSize  = false;
            this.lblFileName.Font      = new System.Drawing.Font("Consolas", 9F);
            this.lblFileName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7B6A9A");
            this.lblFileName.Location  = new System.Drawing.Point(16, 8);
            this.lblFileName.Name      = "lblFileName";
            this.lblFileName.Size      = new System.Drawing.Size(764, 18);
            this.lblFileName.Text      = "📄 尚未選擇檔案...";

            // ── btnBrowser (x=57) ─────────────────────────────────
            this.btnBrowser.BackColor = System.Drawing.ColorTranslator.FromHtml("#A855F7");
            this.btnBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowser.FlatAppearance.BorderSize = 0;
            this.btnBrowser.Font      = fntBtn;
            this.btnBrowser.ForeColor = System.Drawing.Color.White;
            this.btnBrowser.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnBrowser.Location  = new System.Drawing.Point(57, 34);
            this.btnBrowser.Name      = "btnBrowser";
            this.btnBrowser.Size      = new System.Drawing.Size(155, 62);
            this.btnBrowser.TabIndex  = 0;
            this.btnBrowser.Text      = "📁  瀏覽";
            this.btnBrowser.Click    += new System.EventHandler(this.btnBrowser_Click);

            // ── btnPlay (x=226) ───────────────────────────────────
            this.btnPlay.BackColor = System.Drawing.ColorTranslator.FromHtml("#26de81");
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.Enabled   = false;
            this.btnPlay.Font      = fntBtn;
            this.btnPlay.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0A3A1A");
            this.btnPlay.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Location  = new System.Drawing.Point(226, 34);
            this.btnPlay.Name      = "btnPlay";
            this.btnPlay.Size      = new System.Drawing.Size(155, 62);
            this.btnPlay.TabIndex  = 1;
            this.btnPlay.Text      = "▶  播放";
            this.btnPlay.Click    += new System.EventHandler(this.btnPlay_Click);

            // ── btnPause (x=395) ──────────────────────────────────
            this.btnPause.BackColor = System.Drawing.ColorTranslator.FromHtml("#F9CA24");
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.Enabled   = false;
            this.btnPause.Font      = fntBtn;
            this.btnPause.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3A2800");
            this.btnPause.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Location  = new System.Drawing.Point(395, 34);
            this.btnPause.Name      = "btnPause";
            this.btnPause.Size      = new System.Drawing.Size(155, 62);
            this.btnPause.TabIndex  = 2;
            this.btnPause.Text      = "⏸  暫停";
            this.btnPause.Click    += new System.EventHandler(this.btnPause_Click);

            // ── btnStop (x=564) ───────────────────────────────────
            this.btnStop.BackColor = System.Drawing.ColorTranslator.FromHtml("#E94560");
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.Enabled   = false;
            this.btnStop.Font      = fntBtn;
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Location  = new System.Drawing.Point(564, 34);
            this.btnStop.Name      = "btnStop";
            this.btnStop.Size      = new System.Drawing.Size(155, 62);
            this.btnStop.TabIndex  = 3;
            this.btnStop.Text      = "⏹  停止";
            this.btnStop.Click    += new System.EventHandler(this.btnStop_Click);

            // ── frmMediaPlayer ────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(796, 480);
            this.Name                = "frmMediaPlayer";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "多媒體播放器";
            this.Load               += new System.EventHandler(this.frmMediaPlayer_Load);
            this.Controls.Add(this.palButton);
            this.Controls.Add(this.wmpVideo);

            this.palButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpVideo;
        private System.Windows.Forms.Panel    palButton;
        private System.Windows.Forms.Label    lblFileName;
        private System.Windows.Forms.Button   btnBrowser;
        private System.Windows.Forms.Button   btnPlay;
        private System.Windows.Forms.Button   btnPause;
        private System.Windows.Forms.Button   btnStop;
    }
}
