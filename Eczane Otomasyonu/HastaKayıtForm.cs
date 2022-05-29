using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GörselProgramlamaDonemOdev
{
    public partial class HastaKayıtForm : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EHHVCBQ;Initial Catalog=GPDonemOdev;Integrated Security=True");
        public HastaKayıtForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into HastaBilgi(TC,AdıSoyadı,SosyalGüvencesi," +
                "Adres,Telefonu,Kullandıgıilac,KullanımSıklıgı) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7) ", baglanti);
            // SqlCommand komut = new SqlCommand("insert into Personel (Perad,Persoyad,PerSehir,PerMaas,PerMeslek,PerDurum) " +
            //   "values(@p1,@p2,@p3,@p4,@p5,@p6) ", baglanti);
            komut.Parameters.AddWithValue("@p1", TcKimlik.Text);
            komut.Parameters.AddWithValue("@p2", textBoxAdsoyad.Text);
            komut.Parameters.AddWithValue("@p3", SosyalGuvencecombo.Text);
            komut.Parameters.AddWithValue("@p4", Adres.Text);
            komut.Parameters.AddWithValue("@p5", TelefonNo.Text);
            komut.Parameters.AddWithValue("@p6", Kullandigiİlac.Text);
            komut.Parameters.AddWithValue("@p7", KullanımSıklıgı.Text);
            komut.ExecuteNonQuery();//Komutlarımızı çalıştırır. ekle,sil güncelle.
            baglanti.Close();//Bağlantımızı kapattık
            MessageBox.Show("Hasta Eklendi");
        }

        private void HastaKayıtForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gPDonemOdevDataSet13.HastaBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaBilgiTableAdapter1.Fill(this.gPDonemOdevDataSet13.HastaBilgi);
            // TODO: Bu kod satırı 'gPDonemOdevDataSet11.HastaBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaBilgiTableAdapter.Fill(this.gPDonemOdevDataSet11.HastaBilgi);
            // TODO: Bu kod satırı 'gPDonemOdevDataSet1.IlacBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // this.ilacBilgiTableAdapter1.Fill(this.gPDonemOdevDataSet1.IlacBilgi);
            // TODO: Bu kod satırı 'gPDonemOdevDataSet.IlacBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        void temizle()
        {
            TcKimlik.Text = "";
            textBoxAdsoyad.Text = "";
            SosyalGuvencecombo.Text = "";
            Adres.Text = "";
            TelefonNo.Text = "";
            Kullandigiİlac.Text = "";
            KullanımSıklıgı.Text = "";
        }


        private void Anasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            int seçilen = dataGridView1.SelectedCells[0].RowIndex;

            TcKimlik.Text = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            textBoxAdsoyad.Text = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
            SosyalGuvencecombo.Text = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();
            Adres.Text = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();
            Kullandigiİlac.Text = dataGridView1.Rows[seçilen].Cells[5].Value.ToString();
           KullanımSıklıgı.Text = dataGridView1.Rows[seçilen].Cells[4].Value.ToString();
            TelefonNo.Text = dataGridView1.Rows[seçilen].Cells[4].Value.ToString();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update HastaBilgi set AdıSoyadı=@p2,SosyalGüvencesi=@p3,Adres=@p4,Telefonu=@p5,Kullandıgıilac=@p6 , KullanımSıklıgı=@p7 where TC=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", TcKimlik.Text);
            komut.Parameters.AddWithValue("@p2", textBoxAdsoyad.Text);
            komut.Parameters.AddWithValue("@p3", SosyalGuvencecombo.Text);
            komut.Parameters.AddWithValue("@p4", Adres.Text);
            komut.Parameters.AddWithValue("@p5", TelefonNo.Text);
            komut.Parameters.AddWithValue("@p6", Kullandigiİlac.Text);
            komut.Parameters.AddWithValue("@p7", KullanımSıklıgı.Text);

            komut.ExecuteNonQuery();//Komutlarımızı çalıştırır. ekle,sil güncelle.

            baglanti.Close();
            // TODO: Bu kod satırı 'gPDonemOdevDataSet13.HastaBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaBilgiTableAdapter1.Fill(this.gPDonemOdevDataSet13.HastaBilgi);
            // TODO: Bu kod satırı 'gPDonemOdevDataSet11.HastaBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaBilgiTableAdapter.Fill(this.gPDonemOdevDataSet11.HastaBilgi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from HastaBilgi where TC=@k1", baglanti);
            komut.Parameters.AddWithValue("@k1", TcKimlik.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}