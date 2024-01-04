using System.Windows.Forms;

namespace nesneproje
{
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Sidebar.Width = Sidebar.MinimumSize.Width;

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

        private void AnaButton_Click(object sender, EventArgs e)
        {

        }

        private void AramaButton_Click(object sender, EventArgs e)
        {

        }


        private void ProfilButton_Click(object sender, EventArgs e)
        {

        }

        private void EkleButton_Click(object sender, EventArgs e)
        {

            userControl61.Show();
            userControl61.BringToFront();
        }

        private void userControl61_Load(object sender, EventArgs e)
        {

        }
    }
}
