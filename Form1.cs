using System;
using System.Windows.Forms;

namespace nesneproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // LoginForm'u oluþturun
            Giris loginForm = new Giris();

            // LoginForm'u gösterin (ana formu gizleme seçeneðine baðlý olarak)
            loginForm.Show();

            // Ana formu gizlemek istiyorsanýz:
             this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris loginForm = new Giris();

            // LoginForm'u gösterin (ana formu gizleme seçeneðine baðlý olarak)
            loginForm.Show();

            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
