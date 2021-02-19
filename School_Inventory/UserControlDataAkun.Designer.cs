namespace School_Inventory
{
    partial class UserControlDataAkun
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.btnHapus = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_refresh = new FontAwesome.Sharp.IconButton();
            this.btnCari = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAkun = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_peugas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkun)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Btn_Add);
            this.panel1.Controls.Add(this.btnHapus);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 115);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Btn_Add.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.ForeColor = System.Drawing.Color.White;
            this.Btn_Add.Location = new System.Drawing.Point(0, 72);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(91, 33);
            this.Btn_Add.TabIndex = 10;
            this.Btn_Add.Text = "Baru";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnHapus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnHapus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHapus.IconSize = 26;
            this.btnHapus.Location = new System.Drawing.Point(97, 75);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(26, 26);
            this.btnHapus.TabIndex = 11;
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtCari);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btn_refresh);
            this.panel3.Controls.Add(this.btnCari);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(401, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 50);
            this.panel3.TabIndex = 12;
            // 
            // txtCari
            // 
            this.txtCari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtCari.Location = new System.Drawing.Point(85, 16);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(121, 20);
            this.txtCari.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(4, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cari Data :";
            // 
            // btn_refresh
            // 
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btn_refresh.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_refresh.IconSize = 24;
            this.btn_refresh.Location = new System.Drawing.Point(233, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(24, 24);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnCari
            // 
            this.btnCari.FlatAppearance.BorderSize = 0;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnCari.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnCari.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCari.IconSize = 24;
            this.btnCari.Location = new System.Drawing.Point(206, 14);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(24, 24);
            this.btnCari.TabIndex = 4;
            this.btnCari.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 65);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA AKUN ";
            // 
            // dataGridViewAkun
            // 
            this.dataGridViewAkun.AllowUserToAddRows = false;
            this.dataGridViewAkun.AllowUserToDeleteRows = false;
            this.dataGridViewAkun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAkun.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAkun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAkun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.password,
            this.nama_peugas,
            this.id_level});
            this.dataGridViewAkun.Location = new System.Drawing.Point(0, 115);
            this.dataGridViewAkun.Name = "dataGridViewAkun";
            this.dataGridViewAkun.ReadOnly = true;
            this.dataGridViewAkun.Size = new System.Drawing.Size(664, 359);
            this.dataGridViewAkun.TabIndex = 0;
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // nama_peugas
            // 
            this.nama_peugas.HeaderText = "Nama Petugas";
            this.nama_peugas.Name = "nama_peugas";
            this.nama_peugas.ReadOnly = true;
            // 
            // id_level
            // 
            this.id_level.HeaderText = "Level";
            this.id_level.Name = "id_level";
            this.id_level.ReadOnly = true;
            // 
            // UserControlDataAkun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewAkun);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlDataAkun";
            this.Size = new System.Drawing.Size(664, 474);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAkun;
        private System.Windows.Forms.Button Btn_Add;
        private FontAwesome.Sharp.IconButton btnHapus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btn_refresh;
        private FontAwesome.Sharp.IconButton btnCari;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_peugas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_level;
    }
}
