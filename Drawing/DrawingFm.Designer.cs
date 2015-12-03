namespace Drawing
{
    partial class DrawingFm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingFm));
            this.commandBarMs = new System.Windows.Forms.MenuStrip();
            this.fileTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.newTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.openTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.rewriteTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.printSubTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.printTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.quitTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.optionTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.diagramTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.rectTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.ovalTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.lineTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pd = new System.Drawing.Printing.PrintDocument();
            this.pp = new System.Windows.Forms.PrintPreviewDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.commandBarMs.SuspendLayout();
            this.SuspendLayout();
            // 
            // commandBarMs
            // 
            this.commandBarMs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTsmi,
            this.optionTsmi,
            this.ヘルプToolStripMenuItem});
            this.commandBarMs.Location = new System.Drawing.Point(0, 0);
            this.commandBarMs.Name = "commandBarMs";
            this.commandBarMs.Size = new System.Drawing.Size(484, 26);
            this.commandBarMs.TabIndex = 0;
            this.commandBarMs.Text = "menuStrip1";
            // 
            // fileTsmi
            // 
            this.fileTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTsmi,
            this.openTsmi,
            this.rewriteTsmi,
            this.saveTsmi,
            this.printSubTsmi,
            this.quitTsmi});
            this.fileTsmi.Name = "fileTsmi";
            this.fileTsmi.Size = new System.Drawing.Size(68, 22);
            this.fileTsmi.Text = "ファイル";
            // 
            // newTsmi
            // 
            this.newTsmi.Name = "newTsmi";
            this.newTsmi.ShortcutKeyDisplayString = "";
            this.newTsmi.Size = new System.Drawing.Size(184, 22);
            this.newTsmi.Text = "新規作成";
            // 
            // openTsmi
            // 
            this.openTsmi.Name = "openTsmi";
            this.openTsmi.Size = new System.Drawing.Size(184, 22);
            this.openTsmi.Text = "開く";
            this.openTsmi.Click += new System.EventHandler(this.openTsmi_Click);
            // 
            // rewriteTsmi
            // 
            this.rewriteTsmi.Name = "rewriteTsmi";
            this.rewriteTsmi.ShortcutKeyDisplayString = "Ctrl + S";
            this.rewriteTsmi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.rewriteTsmi.Size = new System.Drawing.Size(184, 22);
            this.rewriteTsmi.Text = "保存";
            // 
            // saveTsmi
            // 
            this.saveTsmi.Name = "saveTsmi";
            this.saveTsmi.Size = new System.Drawing.Size(184, 22);
            this.saveTsmi.Text = "名前をつけて保存...";
            this.saveTsmi.Click += new System.EventHandler(this.saveTsmi_Click);
            // 
            // printSubTsmi
            // 
            this.printSubTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printTsmi,
            this.printPreviewTsmi});
            this.printSubTsmi.Name = "printSubTsmi";
            this.printSubTsmi.ShortcutKeyDisplayString = "";
            this.printSubTsmi.Size = new System.Drawing.Size(184, 22);
            this.printSubTsmi.Text = "印刷";
            // 
            // printTsmi
            // 
            this.printTsmi.Name = "printTsmi";
            this.printTsmi.ShortcutKeyDisplayString = "Ctrl + P";
            this.printTsmi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printTsmi.Size = new System.Drawing.Size(166, 22);
            this.printTsmi.Text = "印刷...";
            this.printTsmi.Click += new System.EventHandler(this.printTsmi_Click);
            // 
            // printPreviewTsmi
            // 
            this.printPreviewTsmi.Name = "printPreviewTsmi";
            this.printPreviewTsmi.Size = new System.Drawing.Size(166, 22);
            this.printPreviewTsmi.Text = "印刷プレビュー";
            this.printPreviewTsmi.Click += new System.EventHandler(this.printPreviewTsmi_Click);
            // 
            // quitTsmi
            // 
            this.quitTsmi.Name = "quitTsmi";
            this.quitTsmi.Size = new System.Drawing.Size(184, 22);
            this.quitTsmi.Text = "終了";
            // 
            // optionTsmi
            // 
            this.optionTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diagramTsmi,
            this.colorTsmi});
            this.optionTsmi.Name = "optionTsmi";
            this.optionTsmi.Size = new System.Drawing.Size(44, 22);
            this.optionTsmi.Text = "設定";
            // 
            // diagramTsmi
            // 
            this.diagramTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectTsmi,
            this.ovalTsmi,
            this.lineTsmi});
            this.diagramTsmi.Name = "diagramTsmi";
            this.diagramTsmi.Size = new System.Drawing.Size(100, 22);
            this.diagramTsmi.Text = "図形";
            // 
            // rectTsmi
            // 
            this.rectTsmi.Name = "rectTsmi";
            this.rectTsmi.Size = new System.Drawing.Size(112, 22);
            this.rectTsmi.Text = "四角形";
            this.rectTsmi.Click += new System.EventHandler(this.rectTsmi_Click);
            // 
            // ovalTsmi
            // 
            this.ovalTsmi.Name = "ovalTsmi";
            this.ovalTsmi.Size = new System.Drawing.Size(112, 22);
            this.ovalTsmi.Text = "楕円";
            this.ovalTsmi.Click += new System.EventHandler(this.ovalTsmi_Click);
            // 
            // lineTsmi
            // 
            this.lineTsmi.Name = "lineTsmi";
            this.lineTsmi.Size = new System.Drawing.Size(112, 22);
            this.lineTsmi.Text = "直線";
            this.lineTsmi.Click += new System.EventHandler(this.lineTsmi_Click);
            // 
            // colorTsmi
            // 
            this.colorTsmi.Name = "colorTsmi";
            this.colorTsmi.Size = new System.Drawing.Size(100, 22);
            this.colorTsmi.Text = "色";
            this.colorTsmi.Click += new System.EventHandler(this.colorTsmi_Click);
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョン情報ToolStripMenuItem});
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.ヘルプToolStripMenuItem.Text = "ヘルプ";
            // 
            // バージョン情報ToolStripMenuItem
            // 
            this.バージョン情報ToolStripMenuItem.Name = "バージョン情報ToolStripMenuItem";
            this.バージョン情報ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.バージョン情報ToolStripMenuItem.Text = "バージョン情報";
            // 
            // pp
            // 
            this.pp.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pp.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pp.ClientSize = new System.Drawing.Size(400, 300);
            this.pp.Enabled = true;
            this.pp.Icon = ((System.Drawing.Icon)(resources.GetObject("pp.Icon")));
            this.pp.Name = "pp";
            this.pp.Visible = false;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // DrawingFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 358);
            this.Controls.Add(this.commandBarMs);
            this.MainMenuStrip = this.commandBarMs;
            this.Name = "DrawingFm";
            this.Text = "HiyowaDraw";
            this.Load += new System.EventHandler(this.DrawingFm_Load);
            this.commandBarMs.ResumeLayout(false);
            this.commandBarMs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip commandBarMs;
        private System.Windows.Forms.ToolStripMenuItem fileTsmi;
        private System.Windows.Forms.ToolStripMenuItem openTsmi;
        private System.Windows.Forms.ToolStripMenuItem saveTsmi;
        private System.Windows.Forms.ToolStripMenuItem optionTsmi;
        private System.Windows.Forms.ToolStripMenuItem diagramTsmi;
        private System.Windows.Forms.ToolStripMenuItem rectTsmi;
        private System.Windows.Forms.ToolStripMenuItem ovalTsmi;
        private System.Windows.Forms.ToolStripMenuItem lineTsmi;
        private System.Windows.Forms.ToolStripMenuItem colorTsmi;
        private System.Drawing.Printing.PrintDocument pd;
        private System.Windows.Forms.PrintPreviewDialog pp;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.ToolStripMenuItem newTsmi;
        private System.Windows.Forms.ToolStripMenuItem rewriteTsmi;
        private System.Windows.Forms.ToolStripMenuItem printSubTsmi;
        private System.Windows.Forms.ToolStripMenuItem printTsmi;
        private System.Windows.Forms.ToolStripMenuItem printPreviewTsmi;
        private System.Windows.Forms.ToolStripMenuItem quitTsmi;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報ToolStripMenuItem;
    }
}

