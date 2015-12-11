namespace Drawing
{
    partial class MenuFm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuFm));
            this.drawingGb = new System.Windows.Forms.GroupBox();
            this.lineBtn = new System.Windows.Forms.RadioButton();
            this.ovalBtn = new System.Windows.Forms.RadioButton();
            this.rectBtn = new System.Windows.Forms.RadioButton();
            this.ModeGb = new System.Windows.Forms.GroupBox();
            this.selectBtn = new System.Windows.Forms.RadioButton();
            this.drawBtn = new System.Windows.Forms.RadioButton();
            this.topMostCb = new System.Windows.Forms.CheckBox();
            this.attributeGb = new System.Windows.Forms.GroupBox();
            this.fillBtn = new System.Windows.Forms.CheckBox();
            this.lineWidthLb = new System.Windows.Forms.Label();
            this.lineWidthNud = new System.Windows.Forms.NumericUpDown();
            this.fillColorBtn = new System.Windows.Forms.Button();
            this.refreshTm = new System.Windows.Forms.Timer(this.components);
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.edgeColorBtn = new System.Windows.Forms.Button();
            this.operateGb = new System.Windows.Forms.GroupBox();
            this.redoBtn = new System.Windows.Forms.Button();
            this.undoBtn = new System.Windows.Forms.Button();
            this.colorGb = new System.Windows.Forms.GroupBox();
            this.selectFm = new System.Windows.Forms.GroupBox();
            this.eraseBtn = new System.Windows.Forms.RadioButton();
            this.moveBtn = new System.Windows.Forms.RadioButton();
            this.drawingGb.SuspendLayout();
            this.ModeGb.SuspendLayout();
            this.attributeGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineWidthNud)).BeginInit();
            this.operateGb.SuspendLayout();
            this.colorGb.SuspendLayout();
            this.selectFm.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingGb
            // 
            this.drawingGb.Controls.Add(this.lineBtn);
            this.drawingGb.Controls.Add(this.ovalBtn);
            this.drawingGb.Controls.Add(this.rectBtn);
            this.drawingGb.Location = new System.Drawing.Point(148, 12);
            this.drawingGb.Name = "drawingGb";
            this.drawingGb.Size = new System.Drawing.Size(119, 128);
            this.drawingGb.TabIndex = 0;
            this.drawingGb.TabStop = false;
            this.drawingGb.Text = "図形";
            // 
            // lineBtn
            // 
            this.lineBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.lineBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lineBtn.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lineBtn.Location = new System.Drawing.Point(6, 74);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(50, 50);
            this.lineBtn.TabIndex = 4;
            this.lineBtn.Text = "／";
            this.lineBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tt.SetToolTip(this.lineBtn, "直線を描画します");
            this.lineBtn.UseVisualStyleBackColor = true;
            this.lineBtn.CheckedChanged += new System.EventHandler(this.lineBtn_CheckedChanged);
            // 
            // ovalBtn
            // 
            this.ovalBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.ovalBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ovalBtn.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ovalBtn.Location = new System.Drawing.Point(62, 18);
            this.ovalBtn.Name = "ovalBtn";
            this.ovalBtn.Size = new System.Drawing.Size(50, 50);
            this.ovalBtn.TabIndex = 3;
            this.ovalBtn.Text = "●";
            this.ovalBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tt.SetToolTip(this.ovalBtn, "楕円を描画します");
            this.ovalBtn.UseVisualStyleBackColor = true;
            this.ovalBtn.CheckedChanged += new System.EventHandler(this.ovalBtn_CheckedChanged);
            // 
            // rectBtn
            // 
            this.rectBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.rectBtn.Checked = true;
            this.rectBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rectBtn.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rectBtn.Location = new System.Drawing.Point(6, 18);
            this.rectBtn.Name = "rectBtn";
            this.rectBtn.Size = new System.Drawing.Size(50, 50);
            this.rectBtn.TabIndex = 2;
            this.rectBtn.TabStop = true;
            this.rectBtn.Text = "■";
            this.rectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tt.SetToolTip(this.rectBtn, "四角形を描画します");
            this.rectBtn.UseVisualStyleBackColor = true;
            this.rectBtn.CheckedChanged += new System.EventHandler(this.rectBtn_CheckedChanged);
            // 
            // ModeGb
            // 
            this.ModeGb.Controls.Add(this.selectBtn);
            this.ModeGb.Controls.Add(this.drawBtn);
            this.ModeGb.Location = new System.Drawing.Point(80, 12);
            this.ModeGb.Name = "ModeGb";
            this.ModeGb.Size = new System.Drawing.Size(62, 128);
            this.ModeGb.TabIndex = 1;
            this.ModeGb.TabStop = false;
            this.ModeGb.Text = "モード";
            // 
            // selectBtn
            // 
            this.selectBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.selectBtn.BackgroundImage = global::Drawing.Properties.Resources.select;
            this.selectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectBtn.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.selectBtn.Location = new System.Drawing.Point(6, 18);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(50, 50);
            this.selectBtn.TabIndex = 1;
            this.selectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tt.SetToolTip(this.selectBtn, "消去します");
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // drawBtn
            // 
            this.drawBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.drawBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("drawBtn.BackgroundImage")));
            this.drawBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drawBtn.Checked = true;
            this.drawBtn.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.drawBtn.Location = new System.Drawing.Point(6, 74);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(50, 50);
            this.drawBtn.TabIndex = 0;
            this.drawBtn.TabStop = true;
            this.drawBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.drawBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tt.SetToolTip(this.drawBtn, "描画します");
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // topMostCb
            // 
            this.topMostCb.AutoSize = true;
            this.topMostCb.Checked = true;
            this.topMostCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.topMostCb.Location = new System.Drawing.Point(12, 146);
            this.topMostCb.Name = "topMostCb";
            this.topMostCb.Size = new System.Drawing.Size(102, 16);
            this.topMostCb.TabIndex = 2;
            this.topMostCb.Text = "常に手前に表示";
            this.topMostCb.UseVisualStyleBackColor = true;
            this.topMostCb.CheckedChanged += new System.EventHandler(this.topMostCb_CheckedChanged);
            // 
            // attributeGb
            // 
            this.attributeGb.Controls.Add(this.fillBtn);
            this.attributeGb.Controls.Add(this.lineWidthLb);
            this.attributeGb.Controls.Add(this.lineWidthNud);
            this.attributeGb.Location = new System.Drawing.Point(273, 12);
            this.attributeGb.Name = "attributeGb";
            this.attributeGb.Size = new System.Drawing.Size(62, 128);
            this.attributeGb.TabIndex = 3;
            this.attributeGb.TabStop = false;
            this.attributeGb.Text = "属性";
            // 
            // fillBtn
            // 
            this.fillBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.fillBtn.Checked = true;
            this.fillBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fillBtn.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fillBtn.Location = new System.Drawing.Point(6, 18);
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Size = new System.Drawing.Size(50, 50);
            this.fillBtn.TabIndex = 7;
            this.fillBtn.Text = "■";
            this.fillBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tt.SetToolTip(this.fillBtn, "塗りつぶしの有無を切り替えます");
            this.fillBtn.UseVisualStyleBackColor = true;
            this.fillBtn.CheckedChanged += new System.EventHandler(this.fillBtn_CheckedChanged);
            // 
            // lineWidthLb
            // 
            this.lineWidthLb.AutoSize = true;
            this.lineWidthLb.Location = new System.Drawing.Point(6, 72);
            this.lineWidthLb.Name = "lineWidthLb";
            this.lineWidthLb.Size = new System.Drawing.Size(47, 12);
            this.lineWidthLb.TabIndex = 2;
            this.lineWidthLb.Text = "線の太さ";
            // 
            // lineWidthNud
            // 
            this.lineWidthNud.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.lineWidthNud.Location = new System.Drawing.Point(8, 87);
            this.lineWidthNud.Name = "lineWidthNud";
            this.lineWidthNud.Size = new System.Drawing.Size(50, 19);
            this.lineWidthNud.TabIndex = 6;
            this.lineWidthNud.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.lineWidthNud.ValueChanged += new System.EventHandler(this.lineWidthNud_ValueChanged);
            // 
            // fillColorBtn
            // 
            this.fillColorBtn.Location = new System.Drawing.Point(6, 74);
            this.fillColorBtn.Name = "fillColorBtn";
            this.fillColorBtn.Size = new System.Drawing.Size(50, 50);
            this.fillColorBtn.TabIndex = 5;
            this.tt.SetToolTip(this.fillColorBtn, "塗りつぶしの色を変更します");
            this.fillColorBtn.UseVisualStyleBackColor = true;
            this.fillColorBtn.Click += new System.EventHandler(this.fillColorBtn_Click);
            // 
            // refreshTm
            // 
            this.refreshTm.Enabled = true;
            this.refreshTm.Interval = 1000;
            this.refreshTm.Tick += new System.EventHandler(this.refreshTm_Tick);
            // 
            // edgeColorBtn
            // 
            this.edgeColorBtn.Location = new System.Drawing.Point(6, 18);
            this.edgeColorBtn.Name = "edgeColorBtn";
            this.edgeColorBtn.Size = new System.Drawing.Size(50, 50);
            this.edgeColorBtn.TabIndex = 6;
            this.tt.SetToolTip(this.edgeColorBtn, "輪郭の色を変更します");
            this.edgeColorBtn.UseVisualStyleBackColor = true;
            this.edgeColorBtn.Click += new System.EventHandler(this.edgeColorBtn_Click);
            // 
            // operateGb
            // 
            this.operateGb.Controls.Add(this.redoBtn);
            this.operateGb.Controls.Add(this.undoBtn);
            this.operateGb.Location = new System.Drawing.Point(12, 12);
            this.operateGb.Name = "operateGb";
            this.operateGb.Size = new System.Drawing.Size(62, 128);
            this.operateGb.TabIndex = 4;
            this.operateGb.TabStop = false;
            this.operateGb.Text = "操作";
            // 
            // redoBtn
            // 
            this.redoBtn.BackgroundImage = global::Drawing.Properties.Resources.redoDisabled;
            this.redoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.redoBtn.Enabled = false;
            this.redoBtn.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.redoBtn.ForeColor = System.Drawing.Color.Blue;
            this.redoBtn.Location = new System.Drawing.Point(6, 74);
            this.redoBtn.Name = "redoBtn";
            this.redoBtn.Size = new System.Drawing.Size(50, 50);
            this.redoBtn.TabIndex = 1;
            this.redoBtn.UseVisualStyleBackColor = true;
            this.redoBtn.Click += new System.EventHandler(this.redoBtn_Click);
            // 
            // undoBtn
            // 
            this.undoBtn.BackgroundImage = global::Drawing.Properties.Resources.undoDisabled;
            this.undoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.undoBtn.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.undoBtn.ForeColor = System.Drawing.Color.Blue;
            this.undoBtn.Location = new System.Drawing.Point(6, 18);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(50, 50);
            this.undoBtn.TabIndex = 0;
            this.undoBtn.UseVisualStyleBackColor = true;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // colorGb
            // 
            this.colorGb.Controls.Add(this.edgeColorBtn);
            this.colorGb.Controls.Add(this.fillColorBtn);
            this.colorGb.Location = new System.Drawing.Point(341, 12);
            this.colorGb.Name = "colorGb";
            this.colorGb.Size = new System.Drawing.Size(62, 128);
            this.colorGb.TabIndex = 6;
            this.colorGb.TabStop = false;
            this.colorGb.Text = "色";
            // 
            // selectFm
            // 
            this.selectFm.Controls.Add(this.eraseBtn);
            this.selectFm.Controls.Add(this.moveBtn);
            this.selectFm.Location = new System.Drawing.Point(418, 12);
            this.selectFm.Name = "selectFm";
            this.selectFm.Size = new System.Drawing.Size(119, 128);
            this.selectFm.TabIndex = 7;
            this.selectFm.TabStop = false;
            this.selectFm.Text = "選択";
            // 
            // eraseBtn
            // 
            this.eraseBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.eraseBtn.BackgroundImage = global::Drawing.Properties.Resources.eraser;
            this.eraseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eraseBtn.Location = new System.Drawing.Point(62, 18);
            this.eraseBtn.Name = "eraseBtn";
            this.eraseBtn.Size = new System.Drawing.Size(50, 50);
            this.eraseBtn.TabIndex = 1;
            this.eraseBtn.TabStop = true;
            this.eraseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.eraseBtn.UseVisualStyleBackColor = true;
            this.eraseBtn.Click += new System.EventHandler(this.eraseBtn_Click);
            // 
            // moveBtn
            // 
            this.moveBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.moveBtn.BackgroundImage = global::Drawing.Properties.Resources.move;
            this.moveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moveBtn.Enabled = false;
            this.moveBtn.Location = new System.Drawing.Point(6, 18);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(50, 50);
            this.moveBtn.TabIndex = 0;
            this.moveBtn.TabStop = true;
            this.moveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.moveBtn.UseVisualStyleBackColor = true;
            this.moveBtn.Click += new System.EventHandler(this.moveBtn_Click);
            // 
            // MenuFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 168);
            this.ControlBox = false;
            this.Controls.Add(this.selectFm);
            this.Controls.Add(this.colorGb);
            this.Controls.Add(this.operateGb);
            this.Controls.Add(this.attributeGb);
            this.Controls.Add(this.topMostCb);
            this.Controls.Add(this.ModeGb);
            this.Controls.Add(this.drawingGb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuFm";
            this.ShowInTaskbar = false;
            this.Text = "メニュー";
            this.TopMost = true;
            this.drawingGb.ResumeLayout(false);
            this.ModeGb.ResumeLayout(false);
            this.attributeGb.ResumeLayout(false);
            this.attributeGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineWidthNud)).EndInit();
            this.operateGb.ResumeLayout(false);
            this.colorGb.ResumeLayout(false);
            this.selectFm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox drawingGb;
        private System.Windows.Forms.GroupBox ModeGb;
        private System.Windows.Forms.RadioButton drawBtn;
        private System.Windows.Forms.RadioButton selectBtn;
        private System.Windows.Forms.CheckBox topMostCb;
        public System.Windows.Forms.RadioButton lineBtn;
        public System.Windows.Forms.RadioButton ovalBtn;
        public System.Windows.Forms.RadioButton rectBtn;
        private System.Windows.Forms.GroupBox attributeGb;
        private System.Windows.Forms.Button fillColorBtn;
        private System.Windows.Forms.Timer refreshTm;
        private System.Windows.Forms.Label lineWidthLb;
        private System.Windows.Forms.NumericUpDown lineWidthNud;
        private System.Windows.Forms.CheckBox fillBtn;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.GroupBox operateGb;
        private System.Windows.Forms.Button redoBtn;
        private System.Windows.Forms.Button undoBtn;
        private System.Windows.Forms.GroupBox colorGb;
        private System.Windows.Forms.Button edgeColorBtn;
        private System.Windows.Forms.GroupBox selectFm;
        private System.Windows.Forms.RadioButton moveBtn;
        private System.Windows.Forms.RadioButton eraseBtn;
    }
}