using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace School_Inventory
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string connStr = "datasource=localhost; username=root; password=; database=school-inventory;";
            MySqlConnection conn = new MySqlConnection(connStr);

            if (usertxt.Text == "" || passtxt.Text == "")
            {
                MessageBox.Show("MASUKAN USERNAME DAN PASSWORD!!");
            }
            else
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT* FROM petugas JOIN level ON petugas.id_level = level.id_level WHERE username = '" + usertxt.Text + "' AND password = '" + passtxt.Text + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        int id_level = dr.Field<int>("id_level");

                        if (id_level == 1)
                        {
                            MessageBox.Show("Login berhasil, kamu login sebagai Administrator");
                            this.Hide();
                            Dashboard1 ds = new Dashboard1();
                            ds.Show();
                        }
                        else if (id_level == 2)
                        {
                            MessageBox.Show("Login berhasil, kamu login sebagai Petugasr");
                            this.Hide();
                            DashboardPetugas dp = new DashboardPetugas();
                            dp.Show();
                        }
                        else if(id_level == 3)
                        {
                            MessageBox.Show("Login berhasil, kamu login sebagai Peminjam");
                            this.Hide();
                            DashboardPeminjam dm = new DashboardPeminjam();
                            dm.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("USERNAME ATAU PASSWORD ANDA SALAH!");
                    conn.Close();
                }

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        } 
    }
}
