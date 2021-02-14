using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Inventory
{
    class DataBase
    { 

        public static MySqlConnection GetSqlConnection()
        {
            string db = "datasource=localhost; username=root; password=; database=school-inventory;";
            MySqlConnection con = new MySqlConnection(db);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }
        public static void TambahData(inventorycs inven)
        {
            string db = "INSERT INTO inventaris VALUES (NULL, @invenNama,@invenKondisi, @invenKeterangan, @invenJumlah, @invenID_Jenis, "+ inven.Tanggal_Registrasi.ToString("yyyy-MM-dd") +" , @invenID_Ruang, @invenKode_Inventaris, @invenID_Petugas)";
            MySqlConnection con = GetSqlConnection();
            MySqlCommand cmd = new MySqlCommand(db, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@invenNama", MySqlDbType.VarChar).Value = inven.Nama;
            cmd.Parameters.Add("@invenKondisi", MySqlDbType.VarChar).Value = inven.Kondisi;
            cmd.Parameters.Add("@invenketerangan", MySqlDbType.VarChar).Value = inven.Keterangan ;
            cmd.Parameters.Add("@invenJumlah", MySqlDbType.VarChar).Value = inven.Jumlah;
            cmd.Parameters.Add("@invenID_Jenis", MySqlDbType.VarChar).Value = inven.ID_Jenis;
            
            cmd.Parameters.Add("@invenID_Ruang", MySqlDbType.VarChar).Value = inven.ID_Ruang;
            cmd.Parameters.Add("@invenKode_Inventaris", MySqlDbType.VarChar).Value = inven.Kode_Inventaris;
            cmd.Parameters.Add("@invenID_Petugas", MySqlDbType.VarChar).Value = inven.ID_Petugas;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Data Gagal Ditambahkan. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void HapusData(string id)
        {
            string db ="DELETE FROM inventaris WHERE ID = @id_inventaris";
            MySqlConnection con = GetSqlConnection();
            MySqlCommand cmd = new MySqlCommand(db, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id_inventaris", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Data Gagal Dihapus. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void TampilkanData(string query, DataGridView dgv)
        {
            string db = query;
            MySqlConnection con = GetSqlConnection();
            MySqlCommand cmd = new MySqlCommand(db, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
    }
}
