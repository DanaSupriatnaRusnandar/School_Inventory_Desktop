using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace School_Inventory
{
    public partial class SplashScreen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgbn
            (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public SplashScreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgbn(0, 0, Width, Height, 25, 25));
            progresBar.Value = 0;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progresBar.Value += 2;
            progresBar.Text = progresBar.Value.ToString() + "%";

            if (progresBar.Value ==100)
            {
                timer1.Enabled = false;
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
        }
    }
}
