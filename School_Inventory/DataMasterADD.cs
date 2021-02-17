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
using MySql.Data.MySqlClient;

namespace School_Inventory
{
    public partial class DataMasterADD : Form
    {
        public DataMasterADD(UserControlDataMaster parent)
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            Db.Insert("inventaris", $"NULL, '{txtNama.Text}', '{txtKondisi.Text}', '{txtKeterangan.Text}', '{txtJumlah.Text}', '{txtIDJenis.Text}','{dateTimePickerReg.Value.ToString("yyyy-MM-dd")}', '{txtIDKelas.Text}', '{txtKodeInventaris.Text}', '{txtIDPetugas.Text}'"); 
            MessageBox.Show("Data Berhasil Disimpan");
            this.Hide();
        } 
    }
}
