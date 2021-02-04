using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace School_Inventory.MyClass
{
    class DataClass
    {
        public MySqlConnection con;
        public DataClass()
        {
            string host = "localhost";
            string db = "school-inventory";
            string username = "root";
            string password = "";
            string constring = "datasource =" + host + "; database=" + db + "; port=" + 3306 + "; username=" + username + "; password=" + password + "; ";

            con = new MySqlConnection(constring);
        }
    }
    class USER : DataClass
    {
        public string log_username { set; get; }
        public string log_password { set; get; }
        public Int32 log_level { set; get; }
        public bool user_verification()
        {
            con.Open();
            MySqlDataReader rd;
            bool check = false;
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM `petugas` WHERE username=@user AND password=@pass";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = log_username;
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = log_password;

                rd = cmd.ExecuteReader();

                while(rd.Read())
                {
                    log_level = rd.GetInt32("level");
                }
                con.Close();
            }
            return check;
        }
    }
}
