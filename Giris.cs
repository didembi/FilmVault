using System;
using System.Windows.Forms;

namespace nesneproje
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre kontrolü
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;

            if (kullaniciAdi == "d" && sifre == "d")
            {
                // Duygu girişi ise Form3'e yönlendirme
                Kullanici form3 = new Kullanici();
                form3.Show();
                this.Hide(); // Eğer Form2'yi gizlemek istiyorsanız
            }
            else if (kullaniciAdi == "y" && sifre == "y")
            {
                // Yönetici girişi ise Form3'e yönlendirme
                Yonetici form4 = new Yonetici();
                form4.Show();
                this.Hide(); // Eğer Form2'yi gizlemek istiyorsanız
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı. Lütfen tekrar deneyin.");
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
