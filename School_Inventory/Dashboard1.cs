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
using FontAwesome.Sharp;

namespace School_Inventory
{
    public partial class Dashboard1 : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public Dashboard1()
        {
            //Structurator
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            
        }
        //Structs
        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249,118,176);
            public static Color color3 = Color.FromArgb(253,138,114);
            public static Color color4 = Color.FromArgb(95,77,221);
            public static Color color5 = Color.FromArgb(249,88,155);
            public static Color color6 = Color.FromArgb(24,161,251);
        }

        //Methods
        private void activateButton(object senderBtn, Color color)
        {
            if (senderBtn !=null)
            {
                DissableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left Border
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icon Home
                icon.IconChar = currentBtn.IconChar;
                icon.IconColor = color;
            }
        }

        private void DissableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31,30,68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColor.color1);
        }

        private void btn_Kelas_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColor.color2);
        }

        private void btn_Peminjaman_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColor.color3);
        }

        private void btn_pengembalian_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColor.color4);
        }

        private void Btn_Laporan_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColor.color5);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColor.color6);
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DissableButton();
            leftBorderBtn.Visible = false;
            icon.IconChar = IconChar.Home;
            icon.IconColor = Color.RoyalBlue;
            label1.Text = "Home";
        }

        

        private void Dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);
        private void panelTitelBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
