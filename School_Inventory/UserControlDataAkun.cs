using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Luthor.lib;

namespace School_Inventory
{
    public partial class UserControlDataAkun : UserControl
    {
        public UserControlDataAkun()
        {
            InitializeComponent();
            this.Hide();
        }

        private void Tampilkan()
        {
            DataTable data = Db.Read("petugas", "*");
            dataGridViewAkun.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                dataGridViewAkun.Rows.Add(row.Field<string>("username"), row.Field<string>("password"), row.Field<string>("nama_petugas"), row.Field<int>("id_level"));
            }
        }
        public void Hapus()
        {

            int rowIndex = dataGridViewAkun.CurrentCell.RowIndex;
            dataGridViewAkun.Rows.RemoveAt(rowIndex);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            DataTambahAkun dta = new DataTambahAkun(this);
            dta.ShowDialog();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Tampilkan();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            Hapus();
        }
    }
}
