﻿namespace School_Inventory
{
    partial class DataTambahAkun
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.cmblevel = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtNamaPetugas = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.Label();
            this.txt_IdPetugas = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 83);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(190, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tambah Akun";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.txtLevel);
            this.panel2.Controls.Add(this.btnTambah);
            this.panel2.Controls.Add(this.cmblevel);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Controls.Add(this.txtNamaPetugas);
            this.panel2.Controls.Add(this.txtpass);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtuser);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.txt_IdPetugas);
            this.panel2.Location = new System.Drawing.Point(65, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 402);
            this.panel2.TabIndex = 1;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(55, 280);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(311, 20);
            this.txtLevel.TabIndex = 5;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(283, 334);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(83, 29);
            this.btnTambah.TabIndex = 6;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // cmblevel
            // 
            this.cmblevel.AutoSize = true;
            this.cmblevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmblevel.Location = new System.Drawing.Point(52, 259);
            this.cmblevel.Name = "cmblevel";
            this.cmblevel.Size = new System.Drawing.Size(42, 18);
            this.cmblevel.TabIndex = 9;
            this.cmblevel.Text = "Level";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(55, 219);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(311, 20);
            this.txtname.TabIndex = 4;
            // 
            // txtNamaPetugas
            // 
            this.txtNamaPetugas.AutoSize = true;
            this.txtNamaPetugas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaPetugas.Location = new System.Drawing.Point(52, 198);
            this.txtNamaPetugas.Name = "txtNamaPetugas";
            this.txtNamaPetugas.Size = new System.Drawing.Size(106, 18);
            this.txtNamaPetugas.TabIndex = 7;
            this.txtNamaPetugas.Text = "Nama Petugas";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(55, 159);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(311, 20);
            this.txtpass.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(52, 138);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(75, 18);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "Password";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(55, 101);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(311, 20);
            this.txtuser.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(52, 80);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(77, 18);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "Username";
            // 
            // txt_IdPetugas
            // 
            this.txt_IdPetugas.AutoSize = true;
            this.txt_IdPetugas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdPetugas.Location = new System.Drawing.Point(52, 23);
            this.txt_IdPetugas.Name = "txt_IdPetugas";
            this.txt_IdPetugas.Size = new System.Drawing.Size(80, 18);
            this.txt_IdPetugas.TabIndex = 0;
            this.txt_IdPetugas.Text = "ID Petugas";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(55, 44);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(311, 20);
            this.txtID.TabIndex = 1;
            // 
            // DataTambahAkun
            // 
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(563, 595);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DataTambahAkun";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label cmblevel;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label txtNamaPetugas;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.Label txt_IdPetugas;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtID;
    }
}