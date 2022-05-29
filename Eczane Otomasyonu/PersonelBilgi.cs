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
    public partial class PersonelBilgi : Form
    {
        public PersonelBilgi()
        {
            InitializeComponent();
        }

        private void PersonelId_TextChanged(object sender, EventArgs e)
        {

        }

        private void PersonelBilgi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gPDonemOdevDataSet6.PersonelBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelBilgiTableAdapter3.Fill(this.gPDonemOdevDataSet6.PersonelBilgi);
            // TODO: Bu kod satırı 'gPDonemOdevDataSet5.PersonelBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelBilgiTableAdapter2.Fill(this.gPDonemOdevDataSet5.PersonelBilgi);
            // TODO: Bu kod satırı 'gPDonemOdevDataSet3.PersonelBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelBilgiTableAdapter1.Fill(this.gPDonemOdevDataSet3.PersonelBilgi);


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Listele_Click(object sender, EventArgs e)
        {
            this.personelBilgiTableAdapter1.Fill(this.gPDonemOdevDataSet3.PersonelBilgi);
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EHHVCBQ;Initial Catalog=GPDonemOdev;Integrated Security=True");
        private void Kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();//Bağlantımızı açtık.
            SqlCommand komut = new SqlCommand("insert into PersonelBilgi (Perad,Persoyad,PerSehir,PerMaas,Yakakart,PerDurum) values(@p1,@p2,@p3,@p4,@p5,@p6) ", baglanti);
            komut.Parameters.AddWithValue("@p1", PersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", PerSoyad.Text);
            komut.Parameters.AddWithValue("@p3", Sehir.Text);
            komut.Parameters.AddWithValue("@p4", maskedMaaş.Text);
            komut.Parameters.AddWithValue("@p5", Meslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery();//Komutlarımızı çalıştırır. ekle,sil güncelle.
            baglanti.Close();//Bağlantımızı kapattık
            MessageBox.Show("Personel Eklendi");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;
           // PersonelId.Text = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            PersonelAd.Text = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
            PerSoyad.Text = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();
            Sehir.Text = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();
            label8.Text = dataGridView1.Rows[seçilen].Cells[5].Value.ToString();
            maskedMaaş.Text = dataGridView1.Rows[seçilen].Cells[4].Value.ToString();
            Meslek.Text = dataGridView1.Rows[seçilen].Cells[6].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "true";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from PersonelBilgi where PerAd=@k1", baglanti);
            komut.Parameters.AddWithValue("@k1", PersonelAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        void temizle()
        {
          //  PersonelId.Text = "";
            PersonelAd.Text = "";
            PerSoyad.Text = "";
            Meslek.Text = "";
            maskedMaaş.Text = "";
            Sehir.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            PersonelAd.Focus();
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update PersonelBilgi set PerAd=@p1,Persoyad=@p2,PerSehir=@p3,PerMaas=@p4,Yakakart=@p5,PerDurum=@p6 where PerAd=@p1 ", baglanti);
            komut.Parameters.AddWithValue("@p1", PersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", PerSoyad.Text);
            komut.Parameters.AddWithValue("@p3", Sehir.Text);
            komut.Parameters.AddWithValue("@p4", maskedMaaş.Text);
            komut.Parameters.AddWithValue("@p5", Meslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            //komut.Parameters.AddWithValue("@p7", PersonelId.Text);


            komut.ExecuteNonQuery();//Komutlarımızı çalıştırır. ekle,sil güncelle.

            baglanti.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Anasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
