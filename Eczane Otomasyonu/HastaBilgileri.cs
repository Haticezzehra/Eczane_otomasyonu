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
    public partial class HastaBilgileri : Form
    {
        public HastaBilgileri()
        {
            InitializeComponent();
        }

        private void HastaBilgileri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gPDonemOdevDataSet14.HastaBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaBilgiTableAdapter1.Fill(this.gPDonemOdevDataSet14.HastaBilgi);
            // TODO: Bu kod satırı 'gPDonemOdevDataSet4.HastaBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaBilgiTableAdapter.Fill(this.gPDonemOdevDataSet4.HastaBilgi);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
