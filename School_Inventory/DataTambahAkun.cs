using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Luthor.lib;

namespace School_Inventory
{
    public partial class DataTambahAkun : Form
    {
        public DataTambahAkun()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Db.Insert("petugas", $"'{txt_IdPetugas}', '{txtUsername}', '{txtPassword}', '{txtNamaPetugas}', '{txtLevel}'");
            MessageBox.Show("Akun Berhasil Ditambahkan");
            this.Hide();
        }
    }
}
