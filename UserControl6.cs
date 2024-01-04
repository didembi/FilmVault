using Npgsql;
using NpgsqlTypes;
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
    public partial class UserControl6 : UserControl
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Host=localhost;Port=5432;Database='film';Username=postgres;Password=1234;");

        public UserControl6()
        {
            InitializeComponent();
            VerileriGuncelle();

        }
        private void VerileriGuncelle()
        {
            try
            {
                baglanti.Open();

                // Veritabanından verileri çeken sorgu
                string sorgu = "SELECT * FROM \"film\"";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sorgu, baglanti))
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // DataGridView kontrolüne verileri bağlamak
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verileri yüklerken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
        private void UserControl6_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // Veritabanından verileri çeken sorgu
                string sorgu = "SELECT * FROM \"film\"";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sorgu, baglanti))
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // DataGridView kontrolüne verileri bağlamak
                        dataGridView1.DataSource = dt;
                        if (dataGridView1.Columns["filmler"] is DataGridViewImageColumn)
                        {
                            ((DataGridViewImageColumn)dataGridView1.Columns["filmler"]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verileri yüklerken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public class ImageHelper
        {
            public static byte[] ConvertImageToByteArray(Image image)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Resmi JPEG formatına dönüştürdük, isteğinize bağlı olarak değiştirebilirsiniz.
                    return ms.ToArray();
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        { //Ekle
            try
            {
                baglanti.Open();
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text)
                     || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    MessageBox.Show("Tüm bilgileri doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string ekle = "INSERT INTO \"film\" (\"filmler\",\"ad\", \"yonetmen\", \"oyuncu\", \"tur\", \"yayin_yili\", \"puan\") " +
                             "VALUES (@filmler ,@ad, @yonetmen, @oyuncu, @tur, @yayin_yili, @puan)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(ekle, baglanti))
                {
                    cmd.Parameters.AddWithValue("@filmler", ImageHelper.ConvertImageToByteArray(pictureBox1.Image));
                    cmd.Parameters.AddWithValue("@ad", textBox1.Text);
                    cmd.Parameters.AddWithValue("@yonetmen", textBox2.Text);
                    cmd.Parameters.AddWithValue("@oyuncu", textBox3.Text);
                    cmd.Parameters.AddWithValue("@tur", textBox4.Text);
                    cmd.Parameters.AddWithValue("@yayin_yili", NpgsqlDbType.Numeric).Value = Convert.ToInt32(textBox5.Text);
                    cmd.Parameters.AddWithValue("@puan", NpgsqlDbType.Numeric).Value = Convert.ToDouble(textBox6.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Film başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    VerileriGuncelle();

                }
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
