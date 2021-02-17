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
    public partial class UserControlDataMaster : UserControl
    {
        public UserControlDataMaster()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Tampilkan()
        {
            DataTable data = Db.Read("inventaris", "*");
            dataGridView.Rows.Clear();
            foreach(DataRow row in data.Rows)
            {
                dataGridView.Rows.Add("", row.Field<int>("id_inventaris"), row.Field<string>("nama"), row.Field<string>("kondisi"), row.Field<string>("keterangan"), row.Field<string>("jumlah"), row.Field<string>("id_jenis"), row.Field<DateTime>("tanggal_register").ToLongDateString(), row.Field<string>("id_ruang"), row.Field<int>("kode_inventaris"), row.Field<int>("id_petugas"));
            }

        }
        public void Hapus()
        {
            
            int rowIndex = dataGridView.CurrentCell.RowIndex;
            dataGridView.Rows.RemoveAt(rowIndex);
        }


        private void Btn_Add_Click(object sender, EventArgs e)
        {
            DataMasterADD add = new DataMasterADD(this);
            add.ShowDialog();
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
