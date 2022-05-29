using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GörselProgramlamaDonemOdev
{
    public partial class İlacKaydet : Form
    {
        public İlacKaydet()
        {
            InitializeComponent();
        }

        private void İlacKaydet_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gPDonemOdevDataSet17.İlaçBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.İlaçBilgiTableAdapter.Fill(this.gPDonemOdevDataSet17.İlaçBilgi);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Listele_Click(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gPDonemOdevDataSet17.İlaçBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.İlaçBilgiTableAdapter.Fill(this.gPDonemOdevDataSet17.İlaçBilgi);
            

        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EHHVCBQ;Initial Catalog=GPDonemOdev;Integrated Security=True");


        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT  INTO İlaçBilgi (BarkodNo, IlacAd, StokSayısı, Fiyatı,IlacAciklama, IlacıTeslimAlanPersonel ) values(@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", BarkodNo.Text);
            komut.Parameters.AddWithValue("@p2", ilacAdi.Text);
            komut.Parameters.AddWithValue("@p3", textBox5.Text);
            komut.Parameters.AddWithValue("@p4", fıyat.Text);
            komut.Parameters.AddWithValue("@p5", richTextBox1.Text);
            komut.Parameters.AddWithValue("@p6", ilacteslimalan.Text);
            komut.ExecuteNonQuery();//Komutlarımızı çalıştırır. ekle,sil güncelle.
            baglanti.Close();//Bağlantımızı kapattık
            MessageBox.Show("İlaç  Kaydedildi");


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from İlaçBilgi where BarkodNo=@k1", baglanti);
            komut.Parameters.AddWithValue("@k1", BarkodNo.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Anasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update İlaçBilgi set BarkodNo=@p1,IlacAd=@p2,StokSayısı=@p3,Fiyatı=@p4,IlacAciklama=@p5,IlacıTeslimAlanPersonel=@p6 where BarkodNo=@p1 ", baglanti);
            komut.Parameters.AddWithValue("@p1", BarkodNo.Text);
            komut.Parameters.AddWithValue("@p2", ilacAdi.Text);
            komut.Parameters.AddWithValue("@p3", textBox5.Text);
            komut.Parameters.AddWithValue("@p4", fıyat.Text);
            komut.Parameters.AddWithValue("@p5", richTextBox1.Text);
            komut.Parameters.AddWithValue("@p6", ilacteslimalan.Text);


            komut.ExecuteNonQuery();//Komutlarımızı çalıştırır. ekle,sil güncelle.

            baglanti.Close();
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        void temizle()
        {
            BarkodNo.Text = "";
            ilacAdi.Text = "";
            textBox5.Text = "";
            fıyat.Text = "";
            richTextBox1.Text = "";
            ilacteslimalan.Text = "";
          
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;

            BarkodNo.Text = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
            ilacAdi.Text = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();
            fıyat.Text = dataGridView1.Rows[seçilen].Cells[4].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[seçilen].Cells[5].Value.ToString();
            ilacteslimalan.Text = dataGridView1.Rows[seçilen].Cells[6].Value.ToString();
          
        }
    }
}
