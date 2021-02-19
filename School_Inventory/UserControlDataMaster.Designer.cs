namespace School_Inventory
{
    partial class UserControlDataMaster
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.id_inventaris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kondisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_jenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal_register = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ruang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kode_inventaris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_petugas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_detail_pinjam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnHapus = new FontAwesome.Sharp.IconButton();
            this.resourcesXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_inventaris,
            this.nama,
            this.Kondisi,
            this.keterangan,
            this.jumlah,
            this.id_jenis,
            this.tanggal_register,
            this.id_ruang,
            this.kode_inventaris,
            this.id_petugas,
            this.id_detail_pinjam});
            this.dataGridView.GridColor = System.Drawing.Color.Black;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(836, 428);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_inventaris
            // 
            this.id_inventaris.DataPropertyName = "id_inventaris";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id_inventaris.DefaultCellStyle = dataGridViewCellStyle1;
            this.id_inventaris.HeaderText = "No";
            this.id_inventaris.Name = "id_inventaris";
            this.id_inventaris.ReadOnly = true;
            // 
            // nama
            // 
            this.nama.DataPropertyName = "nama";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nama.DefaultCellStyle = dataGridViewCellStyle2;
            this.nama.HeaderText = "Nama Barang";
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            // 
            // Kondisi
            // 
            this.Kondisi.DataPropertyName = "Kondisi";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Kondisi.DefaultCellStyle = dataGridViewCellStyle3;
            this.Kondisi.HeaderText = "Kondisi Barang";
            this.Kondisi.Name = "Kondisi";
            this.Kondisi.ReadOnly = true;
            this.Kondisi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // keterangan
            // 
            this.keterangan.DataPropertyName = "keterangan";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.keterangan.DefaultCellStyle = dataGridViewCellStyle4;
            this.keterangan.HeaderText = "Keterangan";
            this.keterangan.Name = "keterangan";
            this.keterangan.ReadOnly = true;
            // 
            // jumlah
            // 
            this.jumlah.DataPropertyName = "jumlah";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.jumlah.DefaultCellStyle = dataGridViewCellStyle5;
            this.jumlah.HeaderText = "Jumlah Barang";
            this.jumlah.Name = "jumlah";
            this.jumlah.ReadOnly = true;
            // 
            // id_jenis
            // 
            this.id_jenis.DataPropertyName = "id_jenis";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id_jenis.DefaultCellStyle = dataGridViewCellStyle6;
            this.id_jenis.HeaderText = "Jenis Barang";
            this.id_jenis.Name = "id_jenis";
            this.id_jenis.ReadOnly = true;
            // 
            // tanggal_register
            // 
            this.tanggal_register.DataPropertyName = "tanggal_register";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tanggal_register.DefaultCellStyle = dataGridViewCellStyle7;
            this.tanggal_register.HeaderText = "Tanggal Register";
            this.tanggal_register.Name = "tanggal_register";
            this.tanggal_register.ReadOnly = true;
            // 
            // id_ruang
            // 
            this.id_ruang.DataPropertyName = "id_ruang";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id_ruang.DefaultCellStyle = dataGridViewCellStyle8;
            this.id_ruang.HeaderText = "Kelas";
            this.id_ruang.Name = "id_ruang";
            this.id_ruang.ReadOnly = true;
            // 
            // kode_inventaris
            // 
            this.kode_inventaris.DataPropertyName = "kode_inventaris";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kode_inventaris.DefaultCellStyle = dataGridViewCellStyle9;
            this.kode_inventaris.HeaderText = "Kode Inventaris";
            this.kode_inventaris.Name = "kode_inventaris";
            this.kode_inventaris.ReadOnly = true;
            // 
            // id_petugas
            // 
            this.id_petugas.DataPropertyName = "id_petugas";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id_petugas.DefaultCellStyle = dataGridViewCellStyle10;
            this.id_petugas.HeaderText = "Petugas";
            this.id_petugas.Name = "id_petugas";
            this.id_petugas.ReadOnly = true;
            // 
            // id_detail_pinjam
            // 
            this.id_detail_pinjam.HeaderText = "Detail Pinjam";
            this.id_detail_pinjam.Name = "id_detail_pinjam";
            this.id_detail_pinjam.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(836, 65);
            this.panel3.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(836, 65);
            this.panel5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA MASTER SARANA DAN PRASARANA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Btn_Add);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnHapus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 113);
            this.panel1.TabIndex = 7;
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Btn_Add.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.ForeColor = System.Drawing.Color.White;
            this.Btn_Add.Location = new System.Drawing.Point(3, 74);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(91, 33);
            this.Btn_Add.TabIndex = 1;
            this.Btn_Add.Text = "Baru";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtsearch);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(541, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 48);
            this.panel2.TabIndex = 9;
            // 
            // txtsearch
            // 
            this.txtsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtsearch.Location = new System.Drawing.Point(85, 16);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(133, 20);
            this.txtsearch.TabIndex = 3;
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
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 24;
            this.iconButton2.Location = new System.Drawing.Point(254, 12);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(24, 24);
            this.iconButton2.TabIndex = 5;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 24;
            this.iconButton1.Location = new System.Drawing.Point(224, 14);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(24, 24);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnHapus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnHapus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHapus.IconSize = 26;
            this.btnHapus.Location = new System.Drawing.Point(100, 76);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(26, 26);
            this.btnHapus.TabIndex = 2;
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // resourcesXBindingSource
            // 
            this.resourcesXBindingSource.DataSource = typeof(MySql.Data.ResourcesX);
            // 
            // resourcesBindingSource
            // 
            this.resourcesBindingSource.DataSource = typeof(MySql.Data.Resources);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 113);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(836, 428);
            this.panel4.TabIndex = 8;
            // 
            // UserControlDataMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlDataMaster";
            this.Size = new System.Drawing.Size(836, 541);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource resourcesXBindingSource;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnHapus;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.BindingSource resourcesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_inventaris;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kondisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn keterangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_jenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal_register;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ruang;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_inventaris;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_petugas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_detail_pinjam;
        private System.Windows.Forms.Panel panel4;
    }
}
