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
using School_Inventory.MyClass;


namespace School_Inventory
{
    public partial class Login : Form
    {
        DataClass dc = new DataClass();
        USER user = new USER();

        //TRANSFER TO ANOTHER  FORM

        public static string T_username;
        public static string T_level;
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            user.log_username = usertxt.Text;
            user.log_password = passtxt.Text;
            user.log_level = cmbRole.SelectedIndex;
            bool verify = user.user_verification();
            
            if(verify)
            {
                MessageBox.Show("Berhasil Login");
                int level = user.log_level;
                T_username = user.log_username;
                if(level == 0)
                {
                    T_level = "ADMINISTRATOR";
                }
                else if(level == 1)
                {
                    T_level = "OPERATOR";
                }
                else if(level == 2)
                {
                    T_level = "PEMINJAM";
                }
                Dashboard1 db = new Dashboard1();
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username, Paswword, dan Hak Akses yang Anda Masukan Salah!");
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
