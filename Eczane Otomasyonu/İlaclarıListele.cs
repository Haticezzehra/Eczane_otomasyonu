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
    public partial class İlaclarıListele : Form
    {
        public İlaclarıListele()
        {
            InitializeComponent();
        }

        private void İlaclarıListele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gPDonemOdevDataSet15.İlaçBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.İlaçBilgiTableAdapter3.Fill(this.gPDonemOdevDataSet15.İlaçBilgi);
            // TODO: Bu kod satırı 'gPDonemOdevDataSet10.İlaçBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.İlaçBilgiTableAdapter2.Fill(this.gPDonemOdevDataSet10.İlaçBilgi);
            // TODO: Bu kod satırı 'gPDonemOdevDataSet9.İlaçBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.İlaçBilgiTableAdapter1.Fill(this.gPDonemOdevDataSet9.İlaçBilgi);
            // TODO: Bu kod satırı 'gPDonemOdevDataSet8.İlaçBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.İlaçBilgiTableAdapter.Fill(this.gPDonemOdevDataSet8.İlaçBilgi);

        }

        private void Anasayfa_Click(object sender, EventArgs e)
        {

            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
