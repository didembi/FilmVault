using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace nesneproje
{
    public partial class UserControl2 : UserControl
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Host=localhost;Port=5432;Database=film;Username=postgres;Password=1234;");

        public UserControl2()
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
                string sorgu = "SELECT * FROM film";

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string anahtarKelime = textBox1.Text;

            // Bağlantıyı açın
            using (NpgsqlConnection baglanti = new NpgsqlConnection("Host=localhost;Port=5432;Database=film;Username=postgres;Password=1234;"))
            {
                baglanti.Open();

                // SQL sorgusunu oluşturun (film adına, yönetmene veya türe göre arama)
                string sorgu = "SELECT * FROM film WHERE ad ILIKE @anahtarKelime OR yonetmen ILIKE @anahtarKelime OR tur ILIKE @anahtarKelime";

                // NpgsqlCommand oluşturun
                using (NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti))
                {
                    // Parametre ekleyin
                    komut.Parameters.AddWithValue("@anahtarKelime", "%" + anahtarKelime + "%");

                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // DataGridView kontrolüne verileri bağlamak
                        dataGridView1.DataSource = dt;

                      
                    }

                    // NpgsqlDataReader kullanarak veritabanından verileri okuyun
                    using (NpgsqlDataReader reader = komut.ExecuteReader())
                    {
                        // Verileri DataGridView'e yükleyin veya başka bir şekilde işleyin
                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Film bulunamadı.");
                        }
                    }
                }
            }
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }
    }
}
