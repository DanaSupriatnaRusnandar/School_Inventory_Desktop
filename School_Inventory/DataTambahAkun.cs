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
        public DataTambahAkun(UserControlDataAkun parent)
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

            Db.Insert("petugas", $"'{txtID.Text}', '{txtuser.Text}', '{txtpass.Text}', '{txtname.Text}', '{txtLevel.Text}'");
            MessageBox.Show("Akun Berhasil Ditambahkan");
            this.Hide();
        }
    }
}
