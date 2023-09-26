namespace D0wnloadTube
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Panel = new Guna.UI2.WinForms.Guna2Panel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            DownlaodBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            Browsebtn = new Guna.UI2.WinForms.Guna2GradientButton();
            label9 = new Label();
            label8 = new Label();
            D0wnloadTube = new Label();
            pbDownload = new Guna.UI2.WinForms.Guna2ProgressBar();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtOutputDirectory = new MaskedTextBox();
            Progresslbl = new Label();
            label2 = new Label();
            txtUrl = new MaskedTextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Panel.SuspendLayout();
            SuspendLayout();
            // 
            // Panel
            // 
            Panel.BackColor = Color.Transparent;
            Panel.Controls.Add(label12);
            Panel.Controls.Add(label11);
            Panel.Controls.Add(label10);
            Panel.Controls.Add(DownlaodBtn);
            Panel.Controls.Add(Browsebtn);
            Panel.Controls.Add(label9);
            Panel.Controls.Add(label8);
            Panel.Controls.Add(D0wnloadTube);
            Panel.Controls.Add(pbDownload);
            Panel.Controls.Add(label6);
            Panel.Controls.Add(label5);
            Panel.Controls.Add(label4);
            Panel.Controls.Add(txtOutputDirectory);
            Panel.Controls.Add(Progresslbl);
            Panel.Controls.Add(label2);
            Panel.Controls.Add(txtUrl);
            Panel.CustomizableEdges = customizableEdges7;
            Panel.Dock = DockStyle.Fill;
            Panel.Location = new Point(0, 0);
            Panel.Name = "Panel";
            Panel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Panel.Size = new Size(367, 283);
            Panel.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(2, 215);
            label12.Name = "label12";
            label12.Size = new Size(283, 15);
            label12.TabIndex = 61;
            label12.Text = "PLEASE SUBMIT PULL REQUEST TO MAKE APP BETER";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(2, 200);
            label11.Name = "label11";
            label11.Size = new Size(266, 15);
            label11.TabIndex = 60;
            label11.Text = "THIS APP USES GUNAUI AND YOUTUBE EXPLODE";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(0, 155);
            label10.Name = "label10";
            label10.Size = new Size(252, 15);
            label10.TabIndex = 59;
            label10.Text = "This is Just a Fun project so its not proffecional";
            // 
            // DownlaodBtn
            // 
            DownlaodBtn.Animated = true;
            DownlaodBtn.CustomizableEdges = customizableEdges1;
            DownlaodBtn.DisabledState.BorderColor = Color.DarkGray;
            DownlaodBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            DownlaodBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            DownlaodBtn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            DownlaodBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            DownlaodBtn.FillColor = Color.FromArgb(64, 64, 64);
            DownlaodBtn.FillColor2 = Color.FromArgb(64, 64, 64);
            DownlaodBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DownlaodBtn.ForeColor = Color.White;
            DownlaodBtn.Location = new Point(0, 130);
            DownlaodBtn.Name = "DownlaodBtn";
            DownlaodBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            DownlaodBtn.Size = new Size(369, 20);
            DownlaodBtn.TabIndex = 47;
            DownlaodBtn.Text = "Download Videos";
            DownlaodBtn.Click += btnDownload_Click;
            // 
            // Browsebtn
            // 
            Browsebtn.Animated = true;
            Browsebtn.BackColor = Color.FromArgb(64, 64, 64);
            Browsebtn.CustomizableEdges = customizableEdges3;
            Browsebtn.DisabledState.BorderColor = Color.DarkGray;
            Browsebtn.DisabledState.CustomBorderColor = Color.DarkGray;
            Browsebtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Browsebtn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            Browsebtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Browsebtn.FillColor = Color.FromArgb(64, 64, 64);
            Browsebtn.FillColor2 = Color.FromArgb(64, 64, 64);
            Browsebtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Browsebtn.ForeColor = Color.White;
            Browsebtn.Location = new Point(-3, 73);
            Browsebtn.Name = "Browsebtn";
            Browsebtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Browsebtn.Size = new Size(369, 20);
            Browsebtn.TabIndex = 46;
            Browsebtn.Text = "Browse Download Location";
            Browsebtn.Click += browseBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(0, 170);
            label9.Name = "label9";
            label9.Size = new Size(227, 30);
            label9.TabIndex = 58;
            label9.Text = "THIS APP DOES NOT CONDONE PIRACY \r\nTHIS APP WILL NOT REMOVE COPYRIGHT";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 245);
            label8.Name = "label8";
            label8.Size = new Size(170, 15);
            label8.TabIndex = 57;
            label8.Text = "Longer Videos may take longer";
            // 
            // D0wnloadTube
            // 
            D0wnloadTube.AutoSize = true;
            D0wnloadTube.ForeColor = Color.White;
            D0wnloadTube.Location = new Point(3, 263);
            D0wnloadTube.Name = "D0wnloadTube";
            D0wnloadTube.Size = new Size(170, 15);
            D0wnloadTube.TabIndex = 44;
            D0wnloadTube.Text = "If Theres an error please restart ";
            // 
            // pbDownload
            // 
            pbDownload.BackColor = Color.Transparent;
            pbDownload.CustomizableEdges = customizableEdges5;
            pbDownload.Dock = DockStyle.Top;
            pbDownload.FillColor = Color.Black;
            pbDownload.ForeColor = Color.Transparent;
            pbDownload.Location = new Point(0, 0);
            pbDownload.Name = "pbDownload";
            pbDownload.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pbDownload.Size = new Size(367, 10);
            pbDownload.TabIndex = 45;
            pbDownload.Text = "guna2ProgressBar1";
            pbDownload.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 230);
            label6.Name = "label6";
            label6.Size = new Size(178, 15);
            label6.TabIndex = 43;
            label6.Text = "Download Speeds Based on WIFI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 13);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 42;
            label5.Text = "Downloading:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 43);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 40;
            label4.Text = "File Destenation VVV";
            // 
            // txtOutputDirectory
            // 
            txtOutputDirectory.BackColor = Color.White;
            txtOutputDirectory.BorderStyle = BorderStyle.None;
            txtOutputDirectory.Location = new Point(-3, 57);
            txtOutputDirectory.Name = "txtOutputDirectory";
            txtOutputDirectory.Size = new Size(369, 16);
            txtOutputDirectory.TabIndex = 39;
            // 
            // Progresslbl
            // 
            Progresslbl.AutoSize = true;
            Progresslbl.ForeColor = Color.White;
            Progresslbl.Location = new Point(0, 28);
            Progresslbl.Name = "Progresslbl";
            Progresslbl.Size = new Size(71, 15);
            Progresslbl.TabIndex = 38;
            Progresslbl.Text = "Progress 0%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 96);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 34;
            label2.Text = "Add YT Video Link  VVV";
            // 
            // txtUrl
            // 
            txtUrl.BackColor = Color.White;
            txtUrl.BorderStyle = BorderStyle.None;
            txtUrl.Location = new Point(0, 114);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(369, 16);
            txtUrl.TabIndex = 31;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(367, 283);
            Controls.Add(Panel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Opacity = 0.9D;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "D0wnloadTube";
            Panel.ResumeLayout(false);
            Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel;
        private Guna.UI2.WinForms.Guna2ProgressBar pbDownload;
        private Label D0wnloadTube;
        private Label label6;
        private Label label5;
        private Label label4;
        private MaskedTextBox txtOutputDirectory;
        private Label Progresslbl;
        private Label label2;
        private MaskedTextBox txtUrl;
        private Guna.UI2.WinForms.Guna2GradientButton Browsebtn;
        private Guna.UI2.WinForms.Guna2GradientButton DownlaodBtn;
        private System.Windows.Forms.Timer timer1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}