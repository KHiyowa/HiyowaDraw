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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuFm));
            this.drawingGb = new System.Windows.Forms.GroupBox();
            this.rectBtn = new System.Windows.Forms.RadioButton();
            this.ovalBtn = new System.Windows.Forms.RadioButton();
            this.lineBtn = new System.Windows.Forms.RadioButton();
            this.ModeGb = new System.Windows.Forms.GroupBox();
            this.drawBtn = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.drawingGb.SuspendLayout();
            this.ModeGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingGb
            // 
            this.drawingGb.Controls.Add(this.lineBtn);
            this.drawingGb.Controls.Add(this.ovalBtn);
            this.drawingGb.Controls.Add(this.rectBtn);
            this.drawingGb.Location = new System.Drawing.Point(157, 10);
            this.drawingGb.Name = "drawingGb";
            this.drawingGb.Size = new System.Drawing.Size(134, 130);
            this.drawingGb.TabIndex = 0;
            this.drawingGb.TabStop = false;
            this.drawingGb.Text = "図形";
            // 
            // rectBtn
            // 
            this.rectBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.rectBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rectBtn.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rectBtn.Location = new System.Drawing.Point(6, 18);
            this.rectBtn.Name = "rectBtn";
            this.rectBtn.Size = new System.Drawing.Size(50, 50);
            this.rectBtn.TabIndex = 0;
            this.rectBtn.TabStop = true;
            this.rectBtn.Text = "■";
            this.rectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rectBtn.UseVisualStyleBackColor = true;
            // 
            // ovalBtn
            // 
            this.ovalBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.ovalBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ovalBtn.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ovalBtn.Location = new System.Drawing.Point(62, 18);
            this.ovalBtn.Name = "ovalBtn";
            this.ovalBtn.Size = new System.Drawing.Size(50, 50);
            this.ovalBtn.TabIndex = 1;
            this.ovalBtn.TabStop = true;
            this.ovalBtn.Text = "●";
            this.ovalBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ovalBtn.UseVisualStyleBackColor = true;
            // 
            // lineBtn
            // 
            this.lineBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.lineBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lineBtn.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lineBtn.Location = new System.Drawing.Point(6, 74);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(50, 50);
            this.lineBtn.TabIndex = 2;
            this.lineBtn.TabStop = true;
            this.lineBtn.Text = "／";
            this.lineBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lineBtn.UseVisualStyleBackColor = true;
            // 
            // ModeGb
            // 
            this.ModeGb.Controls.Add(this.radioButton1);
            this.ModeGb.Controls.Add(this.drawBtn);
            this.ModeGb.Location = new System.Drawing.Point(12, 12);
            this.ModeGb.Name = "ModeGb";
            this.ModeGb.Size = new System.Drawing.Size(139, 128);
            this.ModeGb.TabIndex = 1;
            this.ModeGb.TabStop = false;
            this.ModeGb.Text = "モード";
            // 
            // drawBtn
            // 
            this.drawBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.drawBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.drawBtn.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.drawBtn.Image = ((System.Drawing.Image)(resources.GetObject("drawBtn.Image")));
            this.drawBtn.Location = new System.Drawing.Point(6, 18);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(50, 50);
            this.drawBtn.TabIndex = 1;
            this.drawBtn.TabStop = true;
            this.drawBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.drawBtn.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton1.Image = ((System.Drawing.Image)(resources.GetObject("radioButton1.Image")));
            this.radioButton1.Location = new System.Drawing.Point(62, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 50);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // MenuFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 152);
            this.ControlBox = false;
            this.Controls.Add(this.ModeGb);
            this.Controls.Add(this.drawingGb);
            this.Name = "MenuFm";
            this.ShowInTaskbar = false;
            this.Text = "MenuFm";
            this.TopMost = true;
            this.drawingGb.ResumeLayout(false);
            this.ModeGb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox drawingGb;
        private System.Windows.Forms.RadioButton lineBtn;
        private System.Windows.Forms.RadioButton ovalBtn;
        private System.Windows.Forms.RadioButton rectBtn;
        private System.Windows.Forms.GroupBox ModeGb;
        private System.Windows.Forms.RadioButton drawBtn;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}