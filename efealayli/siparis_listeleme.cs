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
    public partial class siparis_listeleme_ : Form
    {
        public siparis_listeleme_()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=efealayli;Uid=root;Pwd='';");

            baglanti.Open();

            string komut = "Select * from siparisler";

            MySqlDataAdapter da = new MySqlDataAdapter(komut, baglanti);



            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void siparis_listeleme__Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
