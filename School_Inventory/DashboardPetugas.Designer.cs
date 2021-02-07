namespace School_Inventory
{
    partial class DashboardPetugas
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitelBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_keluar = new FontAwesome.Sharp.IconButton();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_miximize = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Pengaturan = new FontAwesome.Sharp.IconButton();
            this.Btn_Laporan = new FontAwesome.Sharp.IconButton();
            this.btn_pengembalian = new FontAwesome.Sharp.IconButton();
            this.btn_Peminjaman = new FontAwesome.Sharp.IconButton();
            this.btn_Kelas = new FontAwesome.Sharp.IconButton();
            this.btn_Dashboard = new FontAwesome.Sharp.IconButton();
            this.btn_Home = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTitelBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(220, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(580, 360);
            this.panel4.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Minimize);
            this.panel2.Controls.Add(this.btn_miximize);
            this.panel2.Controls.Add(this.btn_Close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(86, 32);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_keluar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(17, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(69, 58);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Selamat Datang, Petugas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(494, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(86, 90);
            this.panel1.TabIndex = 9;
            // 
            // panelTitelBar
            // 
            this.panelTitelBar.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitelBar.Controls.Add(this.label3);
            this.panelTitelBar.Controls.Add(this.panel1);
            this.panelTitelBar.Controls.Add(this.label1);
            this.panelTitelBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelTitelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitelBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitelBar.Name = "panelTitelBar";
            this.panelTitelBar.Size = new System.Drawing.Size(580, 90);
            this.panelTitelBar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-153, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "HOME";
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btn_Home);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 120);
            this.panelLogo.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btn_Pengaturan);
            this.panelMenu.Controls.Add(this.Btn_Laporan);
            this.panelMenu.Controls.Add(this.btn_pengembalian);
            this.panelMenu.Controls.Add(this.btn_Peminjaman);
            this.panelMenu.Controls.Add(this.btn_Kelas);
            this.panelMenu.Controls.Add(this.btn_Dashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 450);
            this.panelMenu.TabIndex = 3;
            // 
            // btn_keluar
            // 
            this.btn_keluar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_keluar.FlatAppearance.BorderSize = 0;
            this.btn_keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_keluar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_keluar.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_keluar.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_keluar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_keluar.IconSize = 32;
            this.btn_keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_keluar.Location = new System.Drawing.Point(22, 0);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_keluar.Size = new System.Drawing.Size(47, 58);
            this.btn_keluar.TabIndex = 7;
            this.btn_keluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_keluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_keluar.UseMnemonic = false;
            this.btn_keluar.UseVisualStyleBackColor = true;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackgroundImage = global::School_Inventory.Properties.Resources.minimize;
            this.btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Location = new System.Drawing.Point(18, 5);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(16, 16);
            this.btn_Minimize.TabIndex = 2;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_miximize
            // 
            this.btn_miximize.BackgroundImage = global::School_Inventory.Properties.Resources.maximize;
            this.btn_miximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_miximize.FlatAppearance.BorderSize = 0;
            this.btn_miximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_miximize.Location = new System.Drawing.Point(39, 5);
            this.btn_miximize.Name = "btn_miximize";
            this.btn_miximize.Size = new System.Drawing.Size(16, 16);
            this.btn_miximize.TabIndex = 1;
            this.btn_miximize.UseVisualStyleBackColor = true;
            this.btn_miximize.Click += new System.EventHandler(this.btn_miximize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = global::School_Inventory.Properties.Resources.close;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(62, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(16, 16);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Pengaturan
            // 
            this.btn_Pengaturan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Pengaturan.FlatAppearance.BorderSize = 0;
            this.btn_Pengaturan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pengaturan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Pengaturan.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btn_Pengaturan.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Pengaturan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Pengaturan.IconSize = 32;
            this.btn_Pengaturan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Pengaturan.Location = new System.Drawing.Point(0, 395);
            this.btn_Pengaturan.Name = "btn_Pengaturan";
            this.btn_Pengaturan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Pengaturan.Size = new System.Drawing.Size(220, 55);
            this.btn_Pengaturan.TabIndex = 6;
            this.btn_Pengaturan.Text = "Pengaturan";
            this.btn_Pengaturan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Pengaturan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Pengaturan.UseMnemonic = false;
            this.btn_Pengaturan.UseVisualStyleBackColor = true;
            this.btn_Pengaturan.Click += new System.EventHandler(this.btn_Pengaturan_Click);
            // 
            // Btn_Laporan
            // 
            this.Btn_Laporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Laporan.FlatAppearance.BorderSize = 0;
            this.Btn_Laporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Laporan.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Laporan.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.Btn_Laporan.IconColor = System.Drawing.Color.Gainsboro;
            this.Btn_Laporan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Laporan.IconSize = 32;
            this.Btn_Laporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Laporan.Location = new System.Drawing.Point(0, 340);
            this.Btn_Laporan.Name = "Btn_Laporan";
            this.Btn_Laporan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_Laporan.Size = new System.Drawing.Size(220, 55);
            this.Btn_Laporan.TabIndex = 5;
            this.Btn_Laporan.Text = "Laporan";
            this.Btn_Laporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Laporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Laporan.UseMnemonic = false;
            this.Btn_Laporan.UseVisualStyleBackColor = true;
            this.Btn_Laporan.Click += new System.EventHandler(this.Btn_Laporan_Click);
            // 
            // btn_pengembalian
            // 
            this.btn_pengembalian.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_pengembalian.FlatAppearance.BorderSize = 0;
            this.btn_pengembalian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pengembalian.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_pengembalian.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.btn_pengembalian.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_pengembalian.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_pengembalian.IconSize = 32;
            this.btn_pengembalian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pengembalian.Location = new System.Drawing.Point(0, 285);
            this.btn_pengembalian.Name = "btn_pengembalian";
            this.btn_pengembalian.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_pengembalian.Size = new System.Drawing.Size(220, 55);
            this.btn_pengembalian.TabIndex = 4;
            this.btn_pengembalian.Text = "Pengembalian";
            this.btn_pengembalian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pengembalian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_pengembalian.UseMnemonic = false;
            this.btn_pengembalian.UseVisualStyleBackColor = true;
            this.btn_pengembalian.Click += new System.EventHandler(this.btn_pengembalian_Click);
            // 
            // btn_Peminjaman
            // 
            this.btn_Peminjaman.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Peminjaman.FlatAppearance.BorderSize = 0;
            this.btn_Peminjaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Peminjaman.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Peminjaman.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btn_Peminjaman.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Peminjaman.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Peminjaman.IconSize = 32;
            this.btn_Peminjaman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Peminjaman.Location = new System.Drawing.Point(0, 230);
            this.btn_Peminjaman.Name = "btn_Peminjaman";
            this.btn_Peminjaman.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Peminjaman.Size = new System.Drawing.Size(220, 55);
            this.btn_Peminjaman.TabIndex = 3;
            this.btn_Peminjaman.Text = "Peminjaman";
            this.btn_Peminjaman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Peminjaman.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Peminjaman.UseMnemonic = false;
            this.btn_Peminjaman.UseVisualStyleBackColor = true;
            this.btn_Peminjaman.Click += new System.EventHandler(this.btn_Peminjaman_Click);
            // 
            // btn_Kelas
            // 
            this.btn_Kelas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Kelas.FlatAppearance.BorderSize = 0;
            this.btn_Kelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kelas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Kelas.IconChar = FontAwesome.Sharp.IconChar.University;
            this.btn_Kelas.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Kelas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Kelas.IconSize = 32;
            this.btn_Kelas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Kelas.Location = new System.Drawing.Point(0, 175);
            this.btn_Kelas.Name = "btn_Kelas";
            this.btn_Kelas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Kelas.Size = new System.Drawing.Size(220, 55);
            this.btn_Kelas.TabIndex = 2;
            this.btn_Kelas.Text = "Kelas";
            this.btn_Kelas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Kelas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Kelas.UseMnemonic = false;
            this.btn_Kelas.UseVisualStyleBackColor = true;
            this.btn_Kelas.Click += new System.EventHandler(this.btn_Kelas_Click);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Dashboard.FlatAppearance.BorderSize = 0;
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Dashboard.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btn_Dashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Dashboard.IconSize = 32;
            this.btn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.Location = new System.Drawing.Point(0, 120);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Dashboard.Size = new System.Drawing.Size(220, 55);
            this.btn_Dashboard.TabIndex = 1;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Dashboard.UseMnemonic = false;
            this.btn_Dashboard.UseVisualStyleBackColor = true;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackgroundImage = global::School_Inventory.Properties.Resources.logosmea;
            this.btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Home.Location = new System.Drawing.Point(58, 14);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(98, 92);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.TabStop = false;
            // 
            // DashboardPetugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelTitelBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardPetugas";
            this.Text = "DashboardPetugas";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelTitelBar.ResumeLayout(false);
            this.panelTitelBar.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_miximize;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_keluar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTitelBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_Home;
        private FontAwesome.Sharp.IconButton btn_Pengaturan;
        private FontAwesome.Sharp.IconButton Btn_Laporan;
        private FontAwesome.Sharp.IconButton btn_pengembalian;
        private FontAwesome.Sharp.IconButton btn_Peminjaman;
        private FontAwesome.Sharp.IconButton btn_Kelas;
        private FontAwesome.Sharp.IconButton btn_Dashboard;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMenu;
    }
}