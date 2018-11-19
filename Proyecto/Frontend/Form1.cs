using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Frontend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.menuVertical.Width = 250;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(menuVertical.Width == 250)
            {
                menuVertical.Width = 55;
            }
            else
            {
                menuVertical.Width = 250;
            }
        }

        private void cerrarIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizarIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizarIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            restaurarIcon.Visible = true;
            maximizarIcon.Visible = false;
        }

        private void restaurarIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restaurarIcon.Visible = false;
            maximizarIcon.Visible = true;
        }

        private void colapsarMenuIcon_Click(object sender, EventArgs e)
        {
            menuVertical.Width = 55;
            menuIcon.Visible = true;
            colapsarMenuIcon.Visible = false;
        }

        private void menuIcon_Click(object sender, EventArgs e)
        {
            menuVertical.Width = 250;
            menuIcon.Visible = false;
            colapsarMenuIcon.Visible = true;
        }

        private void tituloPnl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112,0xf012,0);
        }
    }
}
