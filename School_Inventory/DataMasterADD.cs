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
   //    private readonly UserControlDataMaster _parent;

        public DataMasterADD(UserControlDataMaster parent)
        {
            InitializeComponent();
     //       _parent = parent;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            Db.Insert("inventaris", $"NULL, '{txtNama.Text}', '{txtKondisi.Text}', '{txtKeterangan.Text}', '{txtJumlah.Text}', '{txtIDJenis.Text}','{dateTimePickerReg.Value.ToString("yyyy-MM-dd")}', '{txtIDKelas.Text}', '{txtKodeInventaris.Text}', '{txtIDPetugas.Text}'");
            MessageBox.Show("Data Berhasil Disimpan");
            this.Hide();
        }

        
        //     private void Clear()
        //     {
        //         txtNama.Text = txtKondisi.Text = txtKeterangan.Text = txtJumlah.Text = txtIDJenis.Text = txtIDKelas.Text = txtKodeInventaris.Text = txtIDPetugas.Text = string.Empty;
        //     }

        //    private void btnSimpan_Click(object sender, EventArgs e)
        //    {
        //       if (txtNama.Text.Trim().Length < 3)
        //       {
        //           MessageBox.Show("Nama Barang wajib di isi!");
        //           return;
        //       }
        /*  if (txtKondisi.Text.Trim().Length < 1)
          {
              MessageBox.Show("Kondisi Barang wajib di isi!");
              return;
          }
          if (txtKeterangan.Text.Trim().Length < 1)
          {
              MessageBox.Show("Keterangan Barang wajib di isi!");
          }

              if (txtJumlah.Text.Trim().Length < 1)
              {
                  MessageBox.Show("Jumlah Barang wajib di isi!");
                  return;
              }
              if (txtIDJenis.Text.Trim().Length < 1)
              {
                  MessageBox.Show("ID Jenis Barang wajib di isi!");
                  return;
              }
              if (dateTimePickerReg.ShowCheckBox)
              {
                  MessageBox.Show("Tanggal & Waktu wajib di isi!");
                  return;
              }
              if (txtIDKelas.Text.Trim().Length < 1)
              {
                  MessageBox.Show("ID Kelas wajib di isi!");
                  return;
              }
              if (txtKodeInventaris.Text.Trim().Length < 1)
              {
                  MessageBox.Show("Kode Inventaris Barang wajib di isi!");
                  return;
              }
              if (txtIDPetugas.Text.Trim().Length < 1)
              {
                  MessageBox.Show("ID Petugas wajib di isi!");
                  return;
              }
              if (btnSimpan.Text == "Simpan")
              {
                  inventorycs inven = new inventorycs(txtNama.Text.Trim(), txtKondisi.Text.Trim(), txtKeterangan.Text.Trim(), txtJumlah.Text.Trim(), txtIDJenis.Text.Trim(), dateTimePickerReg.Value, txtIDKelas.Text.Trim(), txtKodeInventaris.Text.Trim(), txtIDPetugas.Text.Trim());
                  DataBase.TambahData(inven);
                  Clear();
              }
          _parent.Tampilkan();*/
        //  }
    }
}
