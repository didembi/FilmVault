namespace nesneproje
{
    partial class Kullanici
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
            components = new System.ComponentModel.Container();
            Sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            MenuButton = new Button();
            panel2 = new Panel();
            AnaButton = new Button();
            panel3 = new Panel();
            AramaButton = new Button();
            panel4 = new Panel();
            ProfilButton = new Button();
            panel5 = new Panel();
            EkleButton = new Button();
            panel6 = new Panel();
            AyarlarBuuton = new Button();
            SidebarTimer = new System.Windows.Forms.Timer(components);
            userControl51 = new UserControl5();
            userControl11 = new UserControl1();
            userControl21 = new UserControl2();
            userControl31 = new UserControl3();
            userControl41 = new UserControl4();
            Sidebar.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // Sidebar
            // 
            Sidebar.BackColor = Color.DimGray;
            Sidebar.Controls.Add(panel1);
            Sidebar.Controls.Add(panel2);
            Sidebar.Controls.Add(panel3);
            Sidebar.Controls.Add(panel4);
            Sidebar.Controls.Add(panel5);
            Sidebar.Controls.Add(panel6);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Location = new Point(0, 0);
            Sidebar.MaximumSize = new Size(205, 452);
            Sidebar.MinimumSize = new Size(61, 452);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(182, 452);
            Sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(MenuButton);
            panel1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = Color.FromArgb(64, 64, 64);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 100);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(64, 39);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 10;
            label1.Text = "Menü";
            // 
            // MenuButton
            // 
            MenuButton.BackColor = Color.DimGray;
            MenuButton.FlatStyle = FlatStyle.Flat;
            MenuButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            MenuButton.Image = Properties.Resources.icons8_menu_32;
            MenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            MenuButton.Location = new Point(8, 33);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(45, 38);
            MenuButton.TabIndex = 10;
            MenuButton.UseVisualStyleBackColor = false;
            MenuButton.Click += MenuButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(AnaButton);
            panel2.Location = new Point(3, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 43);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // AnaButton
            // 
            AnaButton.BackColor = Color.DimGray;
            AnaButton.FlatStyle = FlatStyle.Flat;
            AnaButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AnaButton.ForeColor = SystemColors.ButtonHighlight;
            AnaButton.Image = Properties.Resources.icons8_home_30;
            AnaButton.ImageAlign = ContentAlignment.MiddleLeft;
            AnaButton.Location = new Point(-21, -23);
            AnaButton.Name = "AnaButton";
            AnaButton.Padding = new Padding(30, 0, 0, 0);
            AnaButton.RightToLeft = RightToLeft.No;
            AnaButton.Size = new Size(243, 78);
            AnaButton.TabIndex = 0;
            AnaButton.Text = "            Ana Sayfa";
            AnaButton.TextAlign = ContentAlignment.MiddleLeft;
            AnaButton.UseVisualStyleBackColor = false;
            AnaButton.Click += AnaButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(AramaButton);
            panel3.Location = new Point(3, 158);
            panel3.Name = "panel3";
            panel3.Size = new Size(197, 43);
            panel3.TabIndex = 3;
            // 
            // AramaButton
            // 
            AramaButton.BackColor = Color.DimGray;
            AramaButton.FlatStyle = FlatStyle.Flat;
            AramaButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AramaButton.ForeColor = SystemColors.ButtonHighlight;
            AramaButton.Image = Properties.Resources.icons8_search_30;
            AramaButton.ImageAlign = ContentAlignment.MiddleLeft;
            AramaButton.Location = new Point(-21, -23);
            AramaButton.Name = "AramaButton";
            AramaButton.Padding = new Padding(30, 0, 0, 0);
            AramaButton.RightToLeft = RightToLeft.No;
            AramaButton.Size = new Size(243, 78);
            AramaButton.TabIndex = 0;
            AramaButton.Text = "            Arama";
            AramaButton.TextAlign = ContentAlignment.MiddleLeft;
            AramaButton.UseVisualStyleBackColor = false;
            AramaButton.Click += AramaButton_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(ProfilButton);
            panel4.Location = new Point(3, 207);
            panel4.Name = "panel4";
            panel4.Size = new Size(197, 43);
            panel4.TabIndex = 4;
            // 
            // ProfilButton
            // 
            ProfilButton.BackColor = Color.DimGray;
            ProfilButton.FlatStyle = FlatStyle.Flat;
            ProfilButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProfilButton.ForeColor = SystemColors.ButtonHighlight;
            ProfilButton.Image = Properties.Resources.icons8_account_32;
            ProfilButton.ImageAlign = ContentAlignment.MiddleLeft;
            ProfilButton.Location = new Point(-21, -23);
            ProfilButton.Name = "ProfilButton";
            ProfilButton.Padding = new Padding(30, 0, 0, 0);
            ProfilButton.RightToLeft = RightToLeft.No;
            ProfilButton.Size = new Size(243, 78);
            ProfilButton.TabIndex = 0;
            ProfilButton.Text = "            Profil";
            ProfilButton.TextAlign = ContentAlignment.MiddleLeft;
            ProfilButton.UseVisualStyleBackColor = false;
            ProfilButton.Click += ProfilButton_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(EkleButton);
            panel5.Location = new Point(3, 256);
            panel5.Name = "panel5";
            panel5.Size = new Size(197, 43);
            panel5.TabIndex = 5;
            // 
            // EkleButton
            // 
            EkleButton.BackColor = Color.DimGray;
            EkleButton.FlatStyle = FlatStyle.Flat;
            EkleButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EkleButton.ForeColor = SystemColors.ButtonHighlight;
            EkleButton.Image = Properties.Resources.icons8_plus_32;
            EkleButton.ImageAlign = ContentAlignment.MiddleLeft;
            EkleButton.Location = new Point(-21, -23);
            EkleButton.Name = "EkleButton";
            EkleButton.Padding = new Padding(30, 0, 0, 0);
            EkleButton.RightToLeft = RightToLeft.No;
            EkleButton.Size = new Size(243, 78);
            EkleButton.TabIndex = 0;
            EkleButton.Text = "            Film";
            EkleButton.TextAlign = ContentAlignment.MiddleLeft;
            EkleButton.UseVisualStyleBackColor = false;
            EkleButton.Click += EkleButton_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(AyarlarBuuton);
            panel6.Location = new Point(3, 305);
            panel6.Name = "panel6";
            panel6.Size = new Size(197, 43);
            panel6.TabIndex = 6;
            // 
            // AyarlarBuuton
            // 
            AyarlarBuuton.BackColor = Color.DimGray;
            AyarlarBuuton.FlatStyle = FlatStyle.Flat;
            AyarlarBuuton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AyarlarBuuton.ForeColor = SystemColors.ButtonHighlight;
            AyarlarBuuton.Image = Properties.Resources.icons8_settings_32;
            AyarlarBuuton.ImageAlign = ContentAlignment.MiddleLeft;
            AyarlarBuuton.Location = new Point(-21, -17);
            AyarlarBuuton.Name = "AyarlarBuuton";
            AyarlarBuuton.Padding = new Padding(30, 0, 0, 0);
            AyarlarBuuton.RightToLeft = RightToLeft.No;
            AyarlarBuuton.Size = new Size(243, 78);
            AyarlarBuuton.TabIndex = 0;
            AyarlarBuuton.Text = "            Ayarlar";
            AyarlarBuuton.TextAlign = ContentAlignment.MiddleLeft;
            AyarlarBuuton.UseVisualStyleBackColor = false;
            AyarlarBuuton.Click += AyarlarBuuton_Click;
            // 
            // SidebarTimer
            // 
            SidebarTimer.Interval = 10;
            SidebarTimer.Tick += SidebarTimer_Tick;
            // 
            // userControl51
            // 
            userControl51.Location = new Point(177, 0);
            userControl51.Name = "userControl51";
            userControl51.Size = new Size(821, 537);
            userControl51.TabIndex = 5;
            // 
            // userControl11
            // 
            userControl11.BackColor = SystemColors.ActiveCaptionText;
            userControl11.Location = new Point(177, 3);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(821, 518);
            userControl11.TabIndex = 6;
            // 
            // userControl21
            // 
            userControl21.BackColor = SystemColors.InactiveCaptionText;
            userControl21.Location = new Point(177, 0);
            userControl21.Name = "userControl21";
            userControl21.Size = new Size(821, 537);
            userControl21.TabIndex = 7;
            // 
            // userControl31
            // 
            userControl31.Location = new Point(177, 0);
            userControl31.Margin = new Padding(3, 2, 3, 2);
            userControl31.Name = "userControl31";
            userControl31.Size = new Size(821, 537);
            userControl31.TabIndex = 8;
            userControl31.Load += userControl31_Load;
            // 
            // userControl41
            // 
            userControl41.Location = new Point(177, 0);
            userControl41.Name = "userControl41";
            userControl41.Size = new Size(821, 537);
            userControl41.TabIndex = 9;
            userControl41.Load += userControl41_Load;
            // 
            // Kullanici
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(993, 533);
            Controls.Add(userControl41);
            Controls.Add(userControl31);
            Controls.Add(userControl21);
            Controls.Add(userControl11);
            Controls.Add(userControl51);
            Controls.Add(Sidebar);
            Location = new Point(3, 3);
            Name = "Kullanici";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            Sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button AnaButton;
        private Panel panel2;
        private Panel panel3;
        private Button AramaButton;
        private Panel panel4;
        private Button ProfilButton;
        private Panel panel5;
        private Button EkleButton;
        private Button MenuButton;
        private Panel panel6;
        private Button AyarlarBuuton;
        private Label label1;
        private System.Windows.Forms.Timer SidebarTimer;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private UserControl3 userControl31;
        private UserControl4 userControl41;
        protected FlowLayoutPanel Sidebar;
        private UserControl5 userControl51;
    }
}