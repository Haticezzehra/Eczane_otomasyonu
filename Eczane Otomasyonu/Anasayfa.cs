using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GörselProgramlamaDonemOdev
{
    //veritabanı bilgilerini dosya şeklidnde hergün kaydedebilir

    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Çıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Hasta_Kayıt_Click(object sender, EventArgs e)
        {
            HastaKayıtForm hastakayıtform = new HastaKayıtForm();
            hastakayıtform.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Personel_Bilgileri_Click(object sender, EventArgs e)
        {
            PersonelBilgi personelblg = new PersonelBilgi();
            personelblg.Show();
            this.Hide();
        }

        private void Hasta_Bilgileri_Click(object sender, EventArgs e)
        {
            HastaBilgileri hastabilgi = new HastaBilgileri();
            hastabilgi.Show();
            this.Hide();
        }

        private void IlacBilgileri_Click(object sender, EventArgs e)
        {
            İlaçİşlemleri ilacİslemleri = new İlaçİşlemleri();
            ilacİslemleri.Show();
            this.Hide();
        }
    }
}
