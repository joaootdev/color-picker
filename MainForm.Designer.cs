namespace color_picker
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Panel = new Panel();
            TxtHex = new TextBox();
            label1 = new Label();
            BtnCopyHex = new Button();
            BtnCopyRgb = new Button();
            label2 = new Label();
            TxtRgb = new TextBox();
            BtnCopyCmyk = new Button();
            label3 = new Label();
            TxtCmyk = new TextBox();
            BtnCopyHsv = new Button();
            label4 = new Label();
            TxtHsv = new TextBox();
            BtnCopyHsl = new Button();
            label5 = new Label();
            TxtHsl = new TextBox();
            label6 = new Label();
            LnkGitHub = new LinkLabel();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // Panel
            // 
            Panel.BackColor = Color.White;
            Panel.BorderStyle = BorderStyle.FixedSingle;
            Panel.Location = new Point(14, 16);
            Panel.Margin = new Padding(3, 4, 3, 4);
            Panel.Name = "Panel";
            Panel.Size = new Size(171, 342);
            Panel.TabIndex = 0;
            Panel.Click += Panel_Click;
            // 
            // TxtHex
            // 
            TxtHex.Location = new Point(201, 40);
            TxtHex.Margin = new Padding(3, 4, 3, 4);
            TxtHex.Name = "TxtHex";
            TxtHex.ReadOnly = true;
            TxtHex.Size = new Size(188, 27);
            TxtHex.TabIndex = 1;
            TxtHex.Text = "#FFFFFF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 16);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 7;
            label1.Text = "HEX";
            // 
            // BtnCopyHex
            // 
            BtnCopyHex.Location = new Point(397, 40);
            BtnCopyHex.Margin = new Padding(3, 4, 3, 4);
            BtnCopyHex.Name = "BtnCopyHex";
            BtnCopyHex.Size = new Size(86, 31);
            BtnCopyHex.TabIndex = 2;
            BtnCopyHex.Text = "Copy";
            BtnCopyHex.UseVisualStyleBackColor = true;
            BtnCopyHex.Click += BtnCopyHex_Click;
            // 
            // BtnCopyRgb
            // 
            BtnCopyRgb.Location = new Point(397, 112);
            BtnCopyRgb.Margin = new Padding(3, 4, 3, 4);
            BtnCopyRgb.Name = "BtnCopyRgb";
            BtnCopyRgb.Size = new Size(86, 31);
            BtnCopyRgb.TabIndex = 4;
            BtnCopyRgb.Text = "Copy";
            BtnCopyRgb.UseVisualStyleBackColor = true;
            BtnCopyRgb.Click += BtnCopyRgb_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 88);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 11;
            label2.Text = "RGB";
            // 
            // TxtRgb
            // 
            TxtRgb.Location = new Point(201, 112);
            TxtRgb.Margin = new Padding(3, 4, 3, 4);
            TxtRgb.Name = "TxtRgb";
            TxtRgb.ReadOnly = true;
            TxtRgb.Size = new Size(188, 27);
            TxtRgb.TabIndex = 3;
            TxtRgb.Text = "255, 255, 255";
            // 
            // BtnCopyCmyk
            // 
            BtnCopyCmyk.Location = new Point(397, 184);
            BtnCopyCmyk.Margin = new Padding(3, 4, 3, 4);
            BtnCopyCmyk.Name = "BtnCopyCmyk";
            BtnCopyCmyk.Size = new Size(86, 31);
            BtnCopyCmyk.TabIndex = 6;
            BtnCopyCmyk.Text = "Copy";
            BtnCopyCmyk.UseVisualStyleBackColor = true;
            BtnCopyCmyk.Click += BtnCopyCmyk_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 160);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 14;
            label3.Text = "CMYK";
            // 
            // TxtCmyk
            // 
            TxtCmyk.Location = new Point(201, 184);
            TxtCmyk.Margin = new Padding(3, 4, 3, 4);
            TxtCmyk.Name = "TxtCmyk";
            TxtCmyk.ReadOnly = true;
            TxtCmyk.Size = new Size(188, 27);
            TxtCmyk.TabIndex = 5;
            TxtCmyk.Text = "0%, 0%, 0%, 0%";
            // 
            // BtnCopyHsv
            // 
            BtnCopyHsv.Location = new Point(397, 256);
            BtnCopyHsv.Margin = new Padding(3, 4, 3, 4);
            BtnCopyHsv.Name = "BtnCopyHsv";
            BtnCopyHsv.Size = new Size(86, 31);
            BtnCopyHsv.TabIndex = 8;
            BtnCopyHsv.Text = "Copy";
            BtnCopyHsv.UseVisualStyleBackColor = true;
            BtnCopyHsv.Click += BtnCopyHsv_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(201, 232);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 17;
            label4.Text = "HSV";
            // 
            // TxtHsv
            // 
            TxtHsv.Location = new Point(201, 256);
            TxtHsv.Margin = new Padding(3, 4, 3, 4);
            TxtHsv.Name = "TxtHsv";
            TxtHsv.ReadOnly = true;
            TxtHsv.Size = new Size(188, 27);
            TxtHsv.TabIndex = 7;
            TxtHsv.Text = "0°, 0%, 0%";
            // 
            // BtnCopyHsl
            // 
            BtnCopyHsl.Location = new Point(397, 328);
            BtnCopyHsl.Margin = new Padding(3, 4, 3, 4);
            BtnCopyHsl.Name = "BtnCopyHsl";
            BtnCopyHsl.Size = new Size(86, 31);
            BtnCopyHsl.TabIndex = 10;
            BtnCopyHsl.Text = "Copy";
            BtnCopyHsl.UseVisualStyleBackColor = true;
            BtnCopyHsl.Click += BtnCopyHsl_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(201, 304);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 20;
            label5.Text = "HSL";
            // 
            // TxtHsl
            // 
            TxtHsl.Location = new Point(201, 328);
            TxtHsl.Margin = new Padding(3, 4, 3, 4);
            TxtHsl.Name = "TxtHsl";
            TxtHsl.ReadOnly = true;
            TxtHsl.Size = new Size(188, 27);
            TxtHsl.TabIndex = 9;
            TxtHsl.Text = "0°, 0%, 0%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(14, 405);
            label6.Name = "label6";
            label6.Size = new Size(227, 20);
            label6.TabIndex = 22;
            label6.Text = "Source code available on GitHub";
            // 
            // LnkGitHub
            // 
            LnkGitHub.AutoSize = true;
            LnkGitHub.BackColor = Color.Transparent;
            LnkGitHub.Location = new Point(185, 405);
            LnkGitHub.Name = "LnkGitHub";
            LnkGitHub.Size = new Size(56, 20);
            LnkGitHub.TabIndex = 24;
            LnkGitHub.TabStop = true;
            LnkGitHub.Text = "GitHub";
            LnkGitHub.LinkClicked += LnkGitHub_LinkClicked;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.DarkGray;
            label7.Location = new Point(353, 405);
            label7.Name = "label7";
            label7.Size = new Size(130, 20);
            label7.TabIndex = 25;
            label7.Text = "© 2025 joaootdev";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.DarkGray;
            label8.Location = new Point(14, 385);
            label8.Name = "label8";
            label8.Size = new Size(200, 20);
            label8.TabIndex = 26;
            label8.Text = "ⓘ Press space to pick a color";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 447);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(LnkGitHub);
            Controls.Add(label6);
            Controls.Add(BtnCopyHsl);
            Controls.Add(label5);
            Controls.Add(TxtHsl);
            Controls.Add(BtnCopyHsv);
            Controls.Add(label4);
            Controls.Add(TxtHsv);
            Controls.Add(BtnCopyCmyk);
            Controls.Add(label3);
            Controls.Add(TxtCmyk);
            Controls.Add(BtnCopyRgb);
            Controls.Add(label2);
            Controls.Add(TxtRgb);
            Controls.Add(BtnCopyHex);
            Controls.Add(label1);
            Controls.Add(TxtHex);
            Controls.Add(Panel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Color Picker";
            KeyDown += MainForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel Panel;
        private TextBox TxtHex;
        private Label label1;
        private Button BtnCopyHex;
        private Button BtnCopyRgb;
        private Label label2;
        private TextBox TxtRgb;
        private Button BtnCopyCmyk;
        private Label label3;
        private TextBox TxtCmyk;
        private Button BtnCopyHsv;
        private Label label4;
        private TextBox TxtHsv;
        private Button BtnCopyHsl;
        private Label label5;
        private TextBox TxtHsl;
        private Label label6;
        private LinkLabel LnkGitHub;
        private Label label7;
        private Label label8;
    }
}
