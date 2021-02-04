namespace School_Inventory
{
    partial class Dashboard1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_Pengaturan = new FontAwesome.Sharp.IconButton();
            this.Btn_Laporan = new FontAwesome.Sharp.IconButton();
            this.btn_pengembalian = new FontAwesome.Sharp.IconButton();
            this.btn_Peminjaman = new FontAwesome.Sharp.IconButton();
            this.btn_Kelas = new FontAwesome.Sharp.IconButton();
            this.btn_Dashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btn_Home = new System.Windows.Forms.PictureBox();
            this.panelTitelBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.icon = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userControlDashboard1 = new School_Inventory.UserControlDashboard();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).BeginInit();
            this.panelTitelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
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
            this.panelMenu.Size = new System.Drawing.Size(220, 561);
            this.panelMenu.TabIndex = 0;
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
            this.btn_Pengaturan.Click += new System.EventHandler(this.iconButton6_Click);
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
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btn_Home);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 120);
            this.panelLogo.TabIndex = 0;
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
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panelTitelBar
            // 
            this.panelTitelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelTitelBar.Controls.Add(this.label3);
            this.panelTitelBar.Controls.Add(this.label1);
            this.panelTitelBar.Controls.Add(this.icon);
            this.panelTitelBar.Controls.Add(this.label2);
            this.panelTitelBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelTitelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitelBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitelBar.Name = "panelTitelBar";
            this.panelTitelBar.Size = new System.Drawing.Size(969, 80);
            this.panelTitelBar.TabIndex = 1;
            this.panelTitelBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitelBar_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(155, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "HOME";
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.icon.ForeColor = System.Drawing.Color.RoyalBlue;
            this.icon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.icon.IconColor = System.Drawing.Color.RoyalBlue;
            this.icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon.Location = new System.Drawing.Point(3, 17);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(32, 32);
            this.icon.TabIndex = 1;
            this.icon.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "USER PAGE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "You Are In";
            // 
            // userControlDashboard1
            // 
            this.userControlDashboard1.BackColor = System.Drawing.Color.White;
            this.userControlDashboard1.Location = new System.Drawing.Point(220, 78);
            this.userControlDashboard1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userControlDashboard1.Name = "userControlDashboard1";
            this.userControlDashboard1.Size = new System.Drawing.Size(971, 485);
            this.userControlDashboard1.TabIndex = 2;
            // 
            // Dashboard1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1189, 561);
            this.Controls.Add(this.userControlDashboard1);
            this.Controls.Add(this.panelTitelBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).EndInit();
            this.panelTitelBar.ResumeLayout(false);
            this.panelTitelBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btn_Pengaturan;
        private FontAwesome.Sharp.IconButton Btn_Laporan;
        private FontAwesome.Sharp.IconButton btn_pengembalian;
        private FontAwesome.Sharp.IconButton btn_Peminjaman;
        private FontAwesome.Sharp.IconButton btn_Kelas;
        private FontAwesome.Sharp.IconButton btn_Dashboard;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitelBar;
        private FontAwesome.Sharp.IconPictureBox icon;
        private System.Windows.Forms.PictureBox btn_Home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private UserControlDashboard userControlDashboard1;
    }
}