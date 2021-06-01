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
    /*
     * Bu proje Efe Alayli tarafından oluşturulmuştur.
     * 
     * Bu proje çalışması için XAMPP programına ihtiyaç vardır. İndirmek için ==> https://www.apachefriends.org/tr/index.html
     * PROJEYE MYSQL TANITMAK İÇİN GEREKLİ OLAN DOSYA ==> "https://dev.mysql.com/downloads/connector/net/"
     * İNDİR KUR SONRA PROJEYE TANIMLA!
     */
    public partial class mainform : Form
    {
        MySqlConnection baglanti;
        public mainform()
        {
            InitializeComponent();
        }
        class DB
        {
            MySqlConnection baglanti;
            //Baglanti adında bir bağlantı oluşturdum

            public bool baglanti_kontrol()
            {
                try
                {
                    baglanti = new MySqlConnection("Server=localhost;Database=efealayli;Uid=root;Pwd='';");
                    baglanti.Open();
                    return true;
                    //Veritabanına bağlanırsa baglanti_kontrol fonksiyonu "true" değeri gönderecek
                }

                catch (Exception)
                {
                    return false;
                    //Veritabanına bağlanamazsa "false" değeri dönecek
                }
            }
        }
//---------------VERİTABANINA TABLOLARI OLUŞTURMA KOD YAPILARI------------------------//
        public void AdTabloOlustur()
        {

            string connStr = "Server=localhost;Database=efealayli;Uid=root;Pwd='';";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd;

            try
            {
                conn.Open();
                cmd = new MySqlCommand(@"
        CREATE TABLE `efe` 
        (efe INT NOT NULL AUTO_INCREMENT,
        ADI_SOYADI VARCHAR(50) NOT NULL, 
        TC_NO VARCHAR(11) NOT NULL,
        TELEFON VARCHAR (11),
        EPOSTA VARCHAR (100),
        ADRES VARCHAR (100),
        SEHIR VARCHAR (50),
        PRIMARY KEY (efe)) COLLATE='utf8_turkish_ci' ENGINE=InnoDB;", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

            }
        }
        public void SoyadTabloOlustur()
        {

            string connStr = "Server=localhost;Database=efealayli;Uid=root;Pwd='';";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd;

            try
            {
                conn.Open();
                cmd = new MySqlCommand(@"
        CREATE TABLE `alayli` 
        (alayli INT NOT NULL AUTO_INCREMENT,
        ADI_SOYADI VARCHAR(50) NOT NULL, 
        TELEFON VARCHAR (11),
        EPOSTA VARCHAR(100),
        PRIMARY KEY (alayli)) COLLATE='utf8_turkish_ci' ENGINE=InnoDB;", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

            }
        }
        public void UrunlerTabloOlustur()
        {

            string connStr = "Server=localhost;Database=efealayli;Uid=root;Pwd='';";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd;

            try
            {
                conn.Open();
                cmd = new MySqlCommand(@"
        CREATE TABLE `urunler` 
        (URUN_KODU INT NOT NULL AUTO_INCREMENT,
        URUN_ADI VARCHAR(100),
        BIRIM_FIYAT INT (100),
        STOK_MIKTAR INT (100),
        PRIMARY KEY (URUN_KODU)) COLLATE='utf8_turkish_ci' ENGINE=InnoDB;", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

            }
        }
        public void SiparsilerTabloOlustur()
        {

            string connStr = "Server=localhost;Database=efealayli;Uid=root;Pwd='';";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd;

            try
            {
                conn.Open();
                cmd = new MySqlCommand(@"
        CREATE TABLE `siparisler` 
        (SIPARIS_NO INT NOT NULL AUTO_INCREMENT,
        OGRENCI_ADI VARCHAR(50) NOT NULL,
        OGRENCI_SOYADI VARCHAR(50) NOT NULL,
        URUN_KODU VARCHAR(100),
        TARIH VARCHAR(40),
        ADET INT(100),
        TUTAR INT(100),
        PRIMARY KEY (SIPARIS_NO)) COLLATE='utf8_turkish_ci' ENGINE=InnoDB;", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

            }
        }
//---------------VERİTABANINA TABLOLARI OLUŞTURMA KOD YAPILARI------------------------//
        #region AD TABLO VERİ OLUŞTURMA BÖLÜMÜ
        public void AdTabloVeriOlustur()
        {
            MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=efealayli;Uid=root;Pwd='';");
            try
            {
                // bağlantıyı açalım
                baglan.Open();
                // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
                MySqlCommand ekle = new MySqlCommand("insert into efe (efe,ADI_SOYADI,TC_NO,TELEFON,EPOSTA,ADRES,SEHIR) values ('','MERT ŞENTÜRK','11111111111','5051002001','mert@gmail.com','Adapazarı Merkezi','Sakarya')", baglan);
                MySqlCommand ekle2 = new MySqlCommand("insert into efe (efe,ADI_SOYADI,TC_NO,TELEFON,EPOSTA,ADRES,SEHIR) values ('','ALİ VELİ','22222222222','50000000000','aliveli@gmail.com','Bülbül Cad.','İstanbul')", baglan);
                MySqlCommand ekle3 = new MySqlCommand("insert into efe (efe,ADI_SOYADI,TC_NO,TELEFON,EPOSTA,ADRES,SEHIR) values ('','Nisa Küçük','33333333333','50002020000','nisakucuk@gmail.com','Merkez','Kocaeli')", baglan);
                MySqlCommand ekle4 = new MySqlCommand("insert into efe (efe,ADI_SOYADI,TC_NO,TELEFON,EPOSTA,ADRES,SEHIR) values ('','Sefa Yıldırım','44444444444','50520030500','sefayildirim@gmail.com','Adapazarı Merkezi','Sakarya')", baglan);
                MySqlCommand ekle5 = new MySqlCommand("insert into efe (efe,ADI_SOYADI,TC_NO,TELEFON,EPOSTA,ADRES,SEHIR) values ('','Ahmet Taş','55555555555','54423000000','ahmettas@yahoo.com','Merkez','İzmir')", baglan);
                MySqlCommand ekle6 = new MySqlCommand("insert into efe (efe,ADI_SOYADI,TC_NO,TELEFON,EPOSTA,ADRES,SEHIR) values ('','Esen NAZ','66666666666','50003000000','esen@gmail.com','Merkez','Antalya')", baglan);
                MySqlCommand ekle7 = new MySqlCommand("insert into efe (efe,ADI_SOYADI,TC_NO,TELEFON,EPOSTA,ADRES,SEHIR) values ('','Leyla CAMBAZ','77777777777','50000007000','leyla_cambaz@gmail.com','Merkez','Ankara')", baglan);
                MySqlCommand ekle8 = new MySqlCommand("insert into efe (efe,ADI_SOYADI,TC_NO,TELEFON,EPOSTA,ADRES,SEHIR) values ('','Ayşe Kurt','88888888888','50000000090','ayse@hotmail.com','Merkez','Kars')", baglan);
                MySqlCommand ekle9 = new MySqlCommand("insert into efe (efe,ADI_SOYADI,TC_NO,TELEFON,EPOSTA,ADRES,SEHIR) values ('','Olcay ŞAN','99999999999','50000000001','olcay_san@outlook.com','Merkez','Trabzon')", baglan);
                MySqlCommand ekle10 = new MySqlCommand("insert into efe (efe,ADI_SOYADI,TC_NO,TELEFON,EPOSTA,ADRES,SEHIR) values ('','Orhan Pamuk','00000000000','50000000300','orhanpmk@gmail.com','Merkez','Zonguldak')", baglan);
                // sorguyu çalıştırıyorum.
                ekle.ExecuteNonQuery(); // sorgu çalıştı ve dönen değer objec türünden değişkene geçti eğer değişken boş değilse eklendi boşşsa eklenmedi.
                ekle2.ExecuteNonQuery();
                ekle3.ExecuteNonQuery();
                ekle4.ExecuteNonQuery();
                ekle5.ExecuteNonQuery();
                ekle6.ExecuteNonQuery();
                ekle7.ExecuteNonQuery();
                ekle8.ExecuteNonQuery();
                ekle9.ExecuteNonQuery();
                ekle10.ExecuteNonQuery();
                baglan.Close();
            }
            catch (Exception HataYakala)
            {
                MessageBox.Show("Hata: " + HataYakala.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region SOYAD TABLO VERİ OLUŞTURMA BÖLÜMÜ
        public void SoyadTabloVeriOlustur()
        {
            MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=efealayli;Uid=root;Pwd='';");
            try
            {
                // bağlantıyı açalım
                baglan.Open();
                // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
                MySqlCommand ekle = new MySqlCommand("insert into alayli (alayli,ADI_SOYADI,TELEFON,EPOSTA) values ('','MERT ŞENTÜRK','5051002001','mert@gmail.com')", baglan);
                MySqlCommand ekle2 = new MySqlCommand("insert into alayli (alayli,ADI_SOYADI,TELEFON,EPOSTA) values ('','ALİ VELİ','50000000000','aliveli@gmail.com')", baglan);
                MySqlCommand ekle3 = new MySqlCommand("insert into alayli (alayli,ADI_SOYADI,TELEFON,EPOSTA) values ('','Nisa Küçük','50002020000','nisakucuk@gmail.com')", baglan);
                MySqlCommand ekle4 = new MySqlCommand("insert into alayli (alayli,ADI_SOYADI,TELEFON,EPOSTA) values ('','Sefa Yıldırım','50520030500','sefayildirim@gmail.com')", baglan);
                MySqlCommand ekle5 = new MySqlCommand("insert into alayli (alayli,ADI_SOYADI,TELEFON,EPOSTA) values ('','Ahmet Taş','54423000000','ahmettas@yahoo.com')", baglan);
                MySqlCommand ekle6 = new MySqlCommand("insert into alayli (alayli,ADI_SOYADI,TELEFON,EPOSTA) values ('','Esen NAZ','50003000000','esen@gmail.com')", baglan);
                MySqlCommand ekle7 = new MySqlCommand("insert into alayli (alayli,ADI_SOYADI,TELEFON,EPOSTA) values ('','Leyla CAMBAZ','50000007000','leyla_cambaz@gmail.com')", baglan);
                MySqlCommand ekle8 = new MySqlCommand("insert into alayli (alayli,ADI_SOYADI,TELEFON,EPOSTA) values ('','Ayşe Kurt','50000000090','ayse@hotmail.com')", baglan);
                MySqlCommand ekle9 = new MySqlCommand("insert into alayli (alayli,ADI_SOYADI,TELEFON,EPOSTA) values ('','Olcay ŞAN','50000000001','olcay_san@outlook.com')", baglan);
                MySqlCommand ekle10 = new MySqlCommand("insert into alayli (alayli,ADI_SOYADI,TELEFON,EPOSTA) values ('','Orhan Pamuk','50000000300','orhanpmk@gmail.com')", baglan);
                // sorguyu çalıştırıyorum.
                ekle.ExecuteNonQuery(); // sorgu çalıştı ve dönen değer objec türünden değişkene geçti eğer değişken boş değilse eklendi boşşsa eklenmedi.
                ekle2.ExecuteNonQuery();
                ekle3.ExecuteNonQuery();
                ekle4.ExecuteNonQuery();
                ekle5.ExecuteNonQuery();
                ekle6.ExecuteNonQuery();
                ekle7.ExecuteNonQuery();
                ekle8.ExecuteNonQuery();
                ekle9.ExecuteNonQuery();
                ekle10.ExecuteNonQuery();
                baglan.Close();
            }
            catch (Exception HataYakala)
            {
                MessageBox.Show("Hata: " + HataYakala.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region ÜRÜN TABLO VERİ OLUŞTURMA BÖLÜMÜ
        public void UrunTabloVeriOlustur()
        {
            MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=efealayli;Uid=root;Pwd='';");
            try
            {
                // bağlantıyı açalım
                baglan.Open();
                // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
                MySqlCommand ekle = new MySqlCommand("insert into urunler (URUN_KODU,URUN_ADI,BIRIM_FIYAT,STOK_MIKTAR) values ('','Kodlab Yayınları C# Eğitim Kitabı','20','10')", baglan);
                MySqlCommand ekle2 = new MySqlCommand("insert into urunler (URUN_KODU,URUN_ADI,BIRIM_FIYAT,STOK_MIKTAR) values ('','Muhasebe Programı','1000','1000')", baglan);
                MySqlCommand ekle3 = new MySqlCommand("insert into urunler (URUN_KODU,URUN_ADI,BIRIM_FIYAT,STOK_MIKTAR) values ('','Domain','100','5')", baglan);
                MySqlCommand ekle4 = new MySqlCommand("insert into urunler (URUN_KODU,URUN_ADI,BIRIM_FIYAT,STOK_MIKTAR) values ('','1 yıllık Hosting','100','1000')", baglan);
                MySqlCommand ekle5 = new MySqlCommand("insert into urunler (URUN_KODU,URUN_ADI,BIRIM_FIYAT,STOK_MIKTAR) values ('','Kurşun Kalem','1','1000')", baglan);
                MySqlCommand ekle6 = new MySqlCommand("insert into urunler (URUN_KODU,URUN_ADI,BIRIM_FIYAT,STOK_MIKTAR) values ('','Tükenmez Kalem','5','100')", baglan);
                MySqlCommand ekle7 = new MySqlCommand("insert into urunler (URUN_KODU,URUN_ADI,BIRIM_FIYAT,STOK_MIKTAR) values ('','Kareli Defter','5','100')", baglan);
                MySqlCommand ekle8 = new MySqlCommand("insert into urunler (URUN_KODU,URUN_ADI,BIRIM_FIYAT,STOK_MIKTAR) values ('','Silgi','1','100')", baglan);
                MySqlCommand ekle9 = new MySqlCommand("insert into urunler (URUN_KODU,URUN_ADI,BIRIM_FIYAT,STOK_MIKTAR) values ('','Dondurma','2','10000')", baglan);
                MySqlCommand ekle10 = new MySqlCommand("insert into urunler (URUN_KODU,URUN_ADI,BIRIM_FIYAT,STOK_MIKTAR) values ('','Su','0,5','1000')", baglan);
                // sorguyu çalıştırıyorum.
                ekle.ExecuteNonQuery(); // sorgu çalıştı ve dönen değer objec türünden değişkene geçti eğer değişken boş değilse eklendi boşşsa eklenmedi.
                ekle2.ExecuteNonQuery();
                ekle3.ExecuteNonQuery();
                ekle4.ExecuteNonQuery();
                ekle5.ExecuteNonQuery();
                ekle6.ExecuteNonQuery();
                ekle7.ExecuteNonQuery();
                ekle8.ExecuteNonQuery();
                ekle9.ExecuteNonQuery();
                ekle10.ExecuteNonQuery();
                baglan.Close();
            }
            catch (Exception HataYakala)
            {
                MessageBox.Show("Hata: " + HataYakala.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region SİPARİŞ TABLO VERİ OLUŞTURMA BÖLÜMÜ
        public void SiparisTabloVeriOlustur()
        {
            MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=efealayli;Uid=root;Pwd='';");
            try
            {
                // bağlantıyı açalım
                baglan.Open();
                // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
                MySqlCommand ekle = new MySqlCommand("insert into siparisler (SIPARIS_NO,OGRENCI_ADI,OGRENCI_SOYADI,URUN_KODU,TARIH,ADET,TUTAR) values ('','MERT','ŞENTÜRK','1','1.06.2021','1','20')", baglan);
                MySqlCommand ekle2 = new MySqlCommand("insert into siparisler (SIPARIS_NO,OGRENCI_ADI,OGRENCI_SOYADI,URUN_KODU,TARIH,ADET,TUTAR) values ('','ESEN','KORKMAZ','2','25.05.2021','2','1000')", baglan);
                MySqlCommand ekle3 = new MySqlCommand("insert into siparisler (SIPARIS_NO,OGRENCI_ADI,OGRENCI_SOYADI,URUN_KODU,TARIH,ADET,TUTAR) values ('','ALİ','ŞAŞMAZ','1','30.02.2021','5','50')", baglan);
                MySqlCommand ekle4 = new MySqlCommand("insert into siparisler (SIPARIS_NO,OGRENCI_ADI,OGRENCI_SOYADI,URUN_KODU,TARIH,ADET,TUTAR) values ('','YUSUF','ASLAN','9','20.08.2021','10','20')", baglan);
                MySqlCommand ekle5 = new MySqlCommand("insert into siparisler (SIPARIS_NO,OGRENCI_ADI,OGRENCI_SOYADI,URUN_KODU,TARIH,ADET,TUTAR) values ('','AHMET','TAŞ','5','1.06.2021','100','500')", baglan);
                MySqlCommand ekle6 = new MySqlCommand("insert into siparisler (SIPARIS_NO,OGRENCI_ADI,OGRENCI_SOYADI,URUN_KODU,TARIH,ADET,TUTAR) values ('','EFE','ALAYLI','3','1.01.2021','3','300')", baglan);
                MySqlCommand ekle7 = new MySqlCommand("insert into siparisler (SIPARIS_NO,OGRENCI_ADI,OGRENCI_SOYADI,URUN_KODU,TARIH,ADET,TUTAR) values ('','KAMİL','KURNAZ','4','1.06.2021','4','400')", baglan);
                MySqlCommand ekle8 = new MySqlCommand("insert into siparisler (SIPARIS_NO,OGRENCI_ADI,OGRENCI_SOYADI,URUN_KODU,TARIH,ADET,TUTAR) values ('','AYŞE','CAMBAZ','1','1.06.2021','10','200')", baglan);
                MySqlCommand ekle9 = new MySqlCommand("insert into siparisler (SIPARIS_NO,OGRENCI_ADI,OGRENCI_SOYADI,URUN_KODU,TARIH,ADET,TUTAR) values ('','HAKAN','DUMAN','6','25.04.2021','10','50')", baglan);
                MySqlCommand ekle10 = new MySqlCommand("insert into siparisler (SIPARIS_NO,OGRENCI_ADI,OGRENCI_SOYADI,URUN_KODU,TARIH,ADET,TUTAR) values ('','HATİCE','YAMAN','10','1.06.2021','50','25')", baglan);
                // sorguyu çalıştırıyorum.
                ekle.ExecuteNonQuery(); // sorgu çalıştı ve dönen değer objec türünden değişkene geçti eğer değişken boş değilse eklendi boşşsa eklenmedi.
                ekle2.ExecuteNonQuery();
                ekle3.ExecuteNonQuery();
                ekle4.ExecuteNonQuery();
                ekle5.ExecuteNonQuery();
                ekle6.ExecuteNonQuery();
                ekle7.ExecuteNonQuery();
                ekle8.ExecuteNonQuery();
                ekle9.ExecuteNonQuery();
                ekle10.ExecuteNonQuery();
                baglan.Close();
            }
            catch (Exception HataYakala)
            {
                MessageBox.Show("Hata: " + HataYakala.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private void mainform_Load(object sender, EventArgs e)
        {
            //------------------DATABASE KONTROL VE OLUŞTURMA KODU BAŞLANGICI------------------//
            DB _vt = new DB();
            if (_vt.baglanti_kontrol() == true)
            {

            }
            else
            {
                DialogResult secenek = MessageBox.Show("MySQL bağlantısı kurulum esnasında veritabanı bulunamadı. Oluşturmak ister misiniz?","DATABASE BULUNAMADI!",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Error);
                if (secenek == DialogResult.Yes)
                {
                    string connStr = "server=localhost;user=root;port=3306;password='';"; //---BAĞLANTI STRİNG KODU
                    MySqlConnection conn = new MySqlConnection(connStr); //---ASIL MYSQL BAĞLANTI KODU
                    MySqlCommand cmd;
                    string s0;

                    try
                    {
                        conn.Open();
                        s0 = "CREATE DATABASE IF NOT EXISTS `efealayli` "; //----> "efealayli" adında bir veri tabanı oluşturuyoruz. Bunu program otomatik olarak yapmaktadır.
                        cmd = new MySqlCommand(s0, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        AdTabloOlustur();//---TABLOLARI YUKARIDAKİ YAPILARDAN ÇEKEREK OTOMATİK OLUŞTURUYOR.
                        SoyadTabloOlustur();//---TABLOLARI YUKARIDAKİ YAPILARDAN ÇEKEREK OTOMATİK OLUŞTURUYOR.
                        UrunlerTabloOlustur();//---TABLOLARI YUKARIDAKİ YAPILARDAN ÇEKEREK OTOMATİK OLUŞTURUYOR.
                        SiparsilerTabloOlustur();//---TABLOLARI YUKARIDAKİ YAPILARDAN ÇEKEREK OTOMATİK OLUŞTURUYOR.
                        //-----------OLUŞTURULAN TABLOLARIN İÇİNE VERİLERİ EKLEME KODU BAŞLANGICI----------------//
                        AdTabloVeriOlustur(); //---> efe Tablosu için içine veri ekleme void veri yapısı
                        SoyadTabloVeriOlustur(); //----> alayli Tablosu için içine veri ekleme void veri yapısı
                        UrunTabloVeriOlustur(); //-----> urunler Tablosu için içine veri ekleme void veri yapısı
                        SiparisTabloVeriOlustur();
                        //-----------OLUŞTURULAN TABLOLARIN İÇİNE VERİLERİ EKLEME KODU SONU----------------//
                        MessageBox.Show("Veritabanı başarıyla oluşturuldu!"); //---İŞLEMLER BAŞARILI OLURSA MESAJ OLARAK YANITLIYOR.
                    }
                    catch (Exception)
                    {
                        
                    }
                }
                else if (secenek == DialogResult.No)
                {
                    MessageBox.Show("Veritabanı ile bağlantı kurulamadı!", "BAŞARISIZ İŞLEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //------------------DATABASE KONTROL VE OLUŞTURMA KODU SONU------------------//
        }

        private void ogrencikayitmodulbtn_Click(object sender, EventArgs e)
        {
            ogrenci_kayit ogrencikayit = new ogrenci_kayit();
            ogrencikayit.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            siparis_listeleme_ siparislistele = new siparis_listeleme_();
            siparislistele.Show();
        }
    }
}
