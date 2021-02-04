namespace School_Inventory
{
    partial class UserControlDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnHapus = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.resourcesXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesXBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(178, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA MASTER SARANA DAN PRASARANA";
            // 
            // btnHapus
            // 
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnHapus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnHapus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHapus.IconSize = 26;
            this.btnHapus.Location = new System.Drawing.Point(6, 50);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(26, 26);
            this.btnHapus.TabIndex = 1;
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(452, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cari Data :";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.textBox1.Location = new System.Drawing.Point(533, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 3;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 24;
            this.iconButton1.Location = new System.Drawing.Point(672, 53);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(24, 24);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 24;
            this.iconButton2.Location = new System.Drawing.Point(697, 53);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(24, 24);
            this.iconButton2.TabIndex = 5;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_inventaris,
            this.nama,
            this.Kondisi,
            this.keterangan,
            this.jumlah,
            this.id_jenis,
            this.tanggal_register,
            this.id_ruang,
            this.kode_inventaris,
            this.id_petugas});
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(0, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(729, 388);
            this.dataGridView1.TabIndex = 6;
            // 
            // id_inventaris
            // 
            this.id_inventaris.HeaderText = "id_inventaris";
            this.id_inventaris.Name = "id_inventaris";
            // 
            // nama
            // 
            this.nama.HeaderText = "Nama Barang";
            this.nama.Name = "nama";
            // 
            // Kondisi
            // 
            this.Kondisi.HeaderText = "Kondisi Barang";
            this.Kondisi.Name = "Kondisi";
            // 
            // keterangan
            // 
            this.keterangan.HeaderText = "Keterangan";
            this.keterangan.Name = "keterangan";
            // 
            // jumlah
            // 
            this.jumlah.HeaderText = "Jumlah Barang";
            this.jumlah.Name = "jumlah";
            // 
            // id_jenis
            // 
            this.id_jenis.HeaderText = "Jenis Barang";
            this.id_jenis.Name = "id_jenis";
            // 
            // tanggal_register
            // 
            this.tanggal_register.HeaderText = "Tanggal Register";
            this.tanggal_register.Name = "tanggal_register";
            // 
            // id_ruang
            // 
            this.id_ruang.HeaderText = "Kelas";
            this.id_ruang.Name = "id_ruang";
            // 
            // kode_inventaris
            // 
            this.kode_inventaris.HeaderText = "Kode Inventaris";
            this.kode_inventaris.Name = "kode_inventaris";
            // 
            // id_petugas
            // 
            this.id_petugas.HeaderText = "Petugas";
            this.id_petugas.Name = "id_petugas";
            // 
            // resourcesXBindingSource
            // 
            this.resourcesXBindingSource.DataSource = typeof(MySql.Data.ResourcesX);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHapus);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 80);
            this.panel1.TabIndex = 7;
            // 
            // UserControlDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControlDashboard";
            this.Size = new System.Drawing.Size(729, 470);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesXBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnHapus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.BindingSource resourcesXBindingSource;
        private System.Windows.Forms.Panel panel1;
    }
}
