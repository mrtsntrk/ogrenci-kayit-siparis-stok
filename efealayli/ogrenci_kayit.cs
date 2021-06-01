using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace efealayli
{
    public partial class ogrenci_kayit : Form
    {
        public ogrenci_kayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=efealayli;Uid=root;Pwd='';");
            try
            {
                // bağlantıyı açalım
                baglan.Open();
                // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
                MySqlCommand ekle = new MySqlCommand("insert into efe (ADI_SOYADI,TC_NO,TELEFON,EPOSTA,ADRES,SEHIR) values ('" + adisoyaditxt.Text + "','" + tcnotxt.Text + "','" + telefontxt.Text + "','" + epostatxt.Text + "','" + adrestxt.Text + "','" + sehirtxt.Text + "')", baglan);
                // sorguyu çalıştırıyorum.
                object sonuc = null;
                sonuc = ekle.ExecuteNonQuery(); // sorgu çalıştı ve dönen değer objec türünden değişkene geçti eğer değişken boş değilse eklendi boşşsa eklenmedi.
                if (sonuc != null)
                    MessageBox.Show("Sisteme başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sisteme eklenemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // bağlantıyı kapatalım
                baglan.Close();
                Listele();
            }
            catch (Exception HataYakala)
            {
                MessageBox.Show("Hata: " + HataYakala.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Listele()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=efealayli;Uid=root;Pwd='';");

            baglanti.Open();

            string komut = "Select * from efe";

            MySqlDataAdapter da = new MySqlDataAdapter(komut, baglanti);

            

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void ogrenci_kayit_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=efealayli;Uid=root;Pwd='';");
            MySqlCommand kmt = new MySqlCommand("DELETE FROM efe WHERE efe='" + dataGridView1.CurrentRow.Cells["efe"].Value.ToString() + "'", baglanti);
            baglanti.Open();
            kmt.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarılı");
            Listele();
        }
    }
}
