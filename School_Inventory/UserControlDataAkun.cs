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
        }

        private void Tampilkan()
        {
            DataTable data = Db.Read("petugas", "*");
            dataGridViewAkun.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                dataGridViewAkun.Rows.Add("",row.Field<int>("id_petugas"), row.Field<string>("username"), row.Field<string>("password"), row.Field<string>("nama_petugas"), row.Field<int>("id_level"));
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DataTambahAkun dta = new DataTambahAkun();
            dta.ShowDialog();
        }
    }
}
