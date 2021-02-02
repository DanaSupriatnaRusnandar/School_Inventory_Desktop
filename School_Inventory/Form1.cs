using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            bool verify = user.user_verification();
            
            if(verify)
            {
                MessageBox.Show("Berhasil Login");
                int role = user.log_level;
                T_username = user.log_username;
                if(role == 0)
                {
                    T_level = "SUPER ADMIN";
                }
                else if(role == 1)
                {
                    T_level = "ADMIN USER";
                }
                else if(role == 2)
                {
                    T_level = "STANDAR USER";
                }
                Dashboard1 db = new Dashboard1();
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Harap Periksa Username dan Password!");
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
