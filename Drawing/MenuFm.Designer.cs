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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.drawBtn = new System.Windows.Forms.RadioButton();
            this.topMostCb = new System.Windows.Forms.CheckBox();
            this.attributeGb = new System.Windows.Forms.GroupBox();
            this.fillBtn = new System.Windows.Forms.CheckBox();
            this.lineWidthLb = new System.Windows.Forms.Label();
            this.lineWidthNud = new System.Windows.Forms.NumericUpDown();
            this.colorBtn = new System.Windows.Forms.Button();
            this.cd = new System.Windows.Forms.ColorDialog();
            this.refreshTm = new System.Windows.Forms.Timer(this.components);
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.operateGb = new System.Windows.Forms.GroupBox();
            this.redoBtn = new System.Windows.Forms.Button();
            this.undoBtn = new System.Windows.Forms.Button();
            this.drawingGb.SuspendLayout();
            this.ModeGb.SuspendLayout();
            this.attributeGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineWidthNud)).BeginInit();
            this.operateGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingGb
            // 
            this.drawingGb.Controls.Add(this.lineBtn);
            this.drawingGb.Controls.Add(this.ovalBtn);
            this.drawingGb.Controls.Add(this.rectBtn);
            this.drawingGb.Location = new System.Drawing.Point(148, 12);
            this.drawingGb.Name = "drawingGb";
            this.drawingGb.Size = new System.Drawing.Size(121, 128);
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
            this.ModeGb.Controls.Add(this.radioButton1);
            this.ModeGb.Controls.Add(this.drawBtn);
            this.ModeGb.Location = new System.Drawing.Point(79, 12);
            this.ModeGb.Name = "ModeGb";
            this.ModeGb.Size = new System.Drawing.Size(63, 128);
            this.ModeGb.TabIndex = 1;
            this.ModeGb.TabStop = false;
            this.ModeGb.Text = "モード";
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.Enabled = false;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton1.Image = ((System.Drawing.Image)(resources.GetObject("radioButton1.Image")));
            this.radioButton1.Location = new System.Drawing.Point(6, 74);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 50);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "消";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tt.SetToolTip(this.radioButton1, "消去します");
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // drawBtn
            // 
            this.drawBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.drawBtn.Checked = true;
            this.drawBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.drawBtn.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.drawBtn.Image = ((System.Drawing.Image)(resources.GetObject("drawBtn.Image")));
            this.drawBtn.Location = new System.Drawing.Point(6, 18);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(50, 50);
            this.drawBtn.TabIndex = 0;
            this.drawBtn.TabStop = true;
            this.drawBtn.Text = "描";
            this.drawBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.drawBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tt.SetToolTip(this.drawBtn, "描画します");
            this.drawBtn.UseVisualStyleBackColor = true;
            // 
            // topMostCb
            // 
            this.topMostCb.AutoSize = true;
            this.topMostCb.Checked = true;
            this.topMostCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.topMostCb.Location = new System.Drawing.Point(18, 147);
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
            this.attributeGb.Controls.Add(this.colorBtn);
            this.attributeGb.Location = new System.Drawing.Point(275, 12);
            this.attributeGb.Name = "attributeGb";
            this.attributeGb.Size = new System.Drawing.Size(122, 128);
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
            this.fillBtn.Location = new System.Drawing.Point(64, 16);
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
            // colorBtn
            // 
            this.colorBtn.Location = new System.Drawing.Point(8, 16);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(50, 50);
            this.colorBtn.TabIndex = 5;
            this.tt.SetToolTip(this.colorBtn, "色を変更します");
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // refreshTm
            // 
            this.refreshTm.Enabled = true;
            this.refreshTm.Interval = 1000;
            this.refreshTm.Tick += new System.EventHandler(this.refreshTm_Tick);
            // 
            // operateGb
            // 
            this.operateGb.Controls.Add(this.redoBtn);
            this.operateGb.Controls.Add(this.undoBtn);
            this.operateGb.Location = new System.Drawing.Point(12, 12);
            this.operateGb.Name = "operateGb";
            this.operateGb.Size = new System.Drawing.Size(61, 128);
            this.operateGb.TabIndex = 4;
            this.operateGb.TabStop = false;
            this.operateGb.Text = "操作";
            // 
            // redoBtn
            // 
            this.redoBtn.Enabled = false;
            this.redoBtn.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.redoBtn.ForeColor = System.Drawing.Color.Blue;
            this.redoBtn.Location = new System.Drawing.Point(6, 72);
            this.redoBtn.Name = "redoBtn";
            this.redoBtn.Size = new System.Drawing.Size(50, 50);
            this.redoBtn.TabIndex = 1;
            this.redoBtn.Text = "→";
            this.redoBtn.UseVisualStyleBackColor = true;
            this.redoBtn.Click += new System.EventHandler(this.redoBtn_Click);
            // 
            // undoBtn
            // 
            this.undoBtn.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.undoBtn.ForeColor = System.Drawing.Color.Blue;
            this.undoBtn.Location = new System.Drawing.Point(6, 18);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(50, 50);
            this.undoBtn.TabIndex = 0;
            this.undoBtn.Text = "←";
            this.undoBtn.UseVisualStyleBackColor = true;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // MenuFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 171);
            this.ControlBox = false;
            this.Controls.Add(this.operateGb);
            this.Controls.Add(this.attributeGb);
            this.Controls.Add(this.topMostCb);
            this.Controls.Add(this.ModeGb);
            this.Controls.Add(this.drawingGb);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox drawingGb;
        private System.Windows.Forms.GroupBox ModeGb;
        private System.Windows.Forms.RadioButton drawBtn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox topMostCb;
        public System.Windows.Forms.RadioButton lineBtn;
        public System.Windows.Forms.RadioButton ovalBtn;
        public System.Windows.Forms.RadioButton rectBtn;
        private System.Windows.Forms.GroupBox attributeGb;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.ColorDialog cd;
        private System.Windows.Forms.Timer refreshTm;
        private System.Windows.Forms.Label lineWidthLb;
        private System.Windows.Forms.NumericUpDown lineWidthNud;
        private System.Windows.Forms.CheckBox fillBtn;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.GroupBox operateGb;
        private System.Windows.Forms.Button redoBtn;
        private System.Windows.Forms.Button undoBtn;
    }
}