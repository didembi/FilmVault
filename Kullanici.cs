using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesneproje
{
    public partial class Kullanici : Form
    {
        public Kullanici()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            Sidebar.Width = Sidebar.MinimumSize.Width;
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
        }

        private void AnaButton_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();

            userControl11.Show();
            userControl11.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        bool SidebarExpand;
        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (SidebarExpand)
            {
                Sidebar.Width -= 10;
                if (Sidebar.Width <= Sidebar.MinimumSize.Width)
                {
                    SidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                Sidebar.Width += 10;
                if (Sidebar.Width >= Sidebar.MaximumSize.Width)
                {
                    SidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }


        private void AramaButton_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl31.Hide();
            userControl41.Hide();

            userControl21.Show();
            userControl21.BringToFront();
        }



        private void ProfilButton_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl11.Hide();
            userControl41.Hide();

            userControl31.Show();
            userControl31.BringToFront();
        }

        private void EkleButton_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl31.Hide();
            userControl11.Hide();

            userControl41.Show();
            userControl41.BringToFront();
        }

        private void AyarlarBuuton_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl11.Hide();

            userControl51.Show();
            userControl51.BringToFront();

        }


        private void userControl41_Load(object sender, EventArgs e)
        {

        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }
    }
}
