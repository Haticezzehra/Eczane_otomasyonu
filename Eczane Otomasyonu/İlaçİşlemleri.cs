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
    public partial class İlaçİşlemleri : Form
    {
        public İlaçİşlemleri()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            İlaclarıListele ilaclistele = new İlaclarıListele();
            ilaclistele.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            İlacKaydet ilacKaydet = new İlacKaydet();
            ilacKaydet.Show();
            this.Hide();
       
        }

        private void İlaçİşlemleri_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
