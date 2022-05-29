
namespace GörselProgramlamaDonemOdev
{
    partial class İlacKaydet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.fıyat = new System.Windows.Forms.TextBox();
            this.ilacteslimalan = new System.Windows.Forms.TextBox();
            this.ilacAdi = new System.Windows.Forms.TextBox();
            this.BarkodNo = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fiyat = new System.Windows.Forms.Label();
            this.lkjkö = new System.Windows.Forms.Label();
            this.IlacAd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ılacIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ılacAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokSayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ılacAciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ılacıTeslimAlanPersonelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilaçBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gPDonemOdevDataSet17 = new GörselProgramlamaDonemOdev.GPDonemOdevDataSet17();
            this.İlaçBilgiTableAdapter = new GörselProgramlamaDonemOdev.GPDonemOdevDataSet17TableAdapters.İlaçBilgiTableAdapter();
            this.Listele = new System.Windows.Forms.Button();
            this.Kaydet = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Sil = new System.Windows.Forms.Button();
            this.Guncelle = new System.Windows.Forms.Button();
            this.Anasayfa = new System.Windows.Forms.Button();
            this.Temizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilaçBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPDonemOdevDataSet17)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(230, 113);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(178, 20);
            this.textBox5.TabIndex = 23;
            // 
            // fıyat
            // 
            this.fıyat.Location = new System.Drawing.Point(230, 75);
            this.fıyat.Name = "fıyat";
            this.fıyat.Size = new System.Drawing.Size(178, 20);
            this.fıyat.TabIndex = 22;
            // 
            // ilacteslimalan
            // 
            this.ilacteslimalan.Location = new System.Drawing.Point(230, 150);
            this.ilacteslimalan.Name = "ilacteslimalan";
            this.ilacteslimalan.Size = new System.Drawing.Size(178, 20);
            this.ilacteslimalan.TabIndex = 21;
            // 
            // ilacAdi
            // 
            this.ilacAdi.Location = new System.Drawing.Point(230, -1);
            this.ilacAdi.Name = "ilacAdi";
            this.ilacAdi.Size = new System.Drawing.Size(178, 20);
            this.ilacAdi.TabIndex = 19;
            // 
            // BarkodNo
            // 
            this.BarkodNo.Location = new System.Drawing.Point(230, 37);
            this.BarkodNo.Mask = "0000000000";
            this.BarkodNo.Name = "BarkodNo";
            this.BarkodNo.Size = new System.Drawing.Size(178, 20);
            this.BarkodNo.TabIndex = 18;
            this.BarkodNo.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(132, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "İlaç Açıklama:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(147, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Stok Sayısı:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // fiyat
            // 
            this.fiyat.AutoSize = true;
            this.fiyat.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyat.Location = new System.Drawing.Point(178, 77);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(42, 18);
            this.fiyat.TabIndex = 15;
            this.fiyat.Text = "Fiyat:";
            // 
            // lkjkö
            // 
            this.lkjkö.AutoSize = true;
            this.lkjkö.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lkjkö.Location = new System.Drawing.Point(107, 39);
            this.lkjkö.Name = "lkjkö";
            this.lkjkö.Size = new System.Drawing.Size(117, 18);
            this.lkjkö.TabIndex = 14;
            this.lkjkö.Text = "Barkod Numarası:";
            // 
            // IlacAd
            // 
            this.IlacAd.AutoSize = true;
            this.IlacAd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IlacAd.Location = new System.Drawing.Point(167, 1);
            this.IlacAd.Name = "IlacAd";
            this.IlacAd.Size = new System.Drawing.Size(57, 18);
            this.IlacAd.TabIndex = 13;
            this.IlacAd.Text = "İlaç Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "İlacı Teslim Alan Personel Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ılacIdDataGridViewTextBoxColumn,
            this.barkodNoDataGridViewTextBoxColumn,
            this.ılacAdDataGridViewTextBoxColumn,
            this.stokSayısıDataGridViewTextBoxColumn,
            this.fiyatıDataGridViewTextBoxColumn,
            this.ılacAciklamaDataGridViewTextBoxColumn,
            this.ılacıTeslimAlanPersonelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ilaçBilgiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-18, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(831, 165);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // ılacIdDataGridViewTextBoxColumn
            // 
            this.ılacIdDataGridViewTextBoxColumn.DataPropertyName = "IlacId";
            this.ılacIdDataGridViewTextBoxColumn.HeaderText = "IlacId";
            this.ılacIdDataGridViewTextBoxColumn.Name = "ılacIdDataGridViewTextBoxColumn";
            this.ılacIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ılacIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // barkodNoDataGridViewTextBoxColumn
            // 
            this.barkodNoDataGridViewTextBoxColumn.DataPropertyName = "BarkodNo";
            this.barkodNoDataGridViewTextBoxColumn.HeaderText = "BarkodNo";
            this.barkodNoDataGridViewTextBoxColumn.Name = "barkodNoDataGridViewTextBoxColumn";
            // 
            // ılacAdDataGridViewTextBoxColumn
            // 
            this.ılacAdDataGridViewTextBoxColumn.DataPropertyName = "IlacAd";
            this.ılacAdDataGridViewTextBoxColumn.HeaderText = "IlacAd";
            this.ılacAdDataGridViewTextBoxColumn.Name = "ılacAdDataGridViewTextBoxColumn";
            // 
            // stokSayısıDataGridViewTextBoxColumn
            // 
            this.stokSayısıDataGridViewTextBoxColumn.DataPropertyName = "StokSayısı";
            this.stokSayısıDataGridViewTextBoxColumn.HeaderText = "StokSayısı";
            this.stokSayısıDataGridViewTextBoxColumn.Name = "stokSayısıDataGridViewTextBoxColumn";
            // 
            // fiyatıDataGridViewTextBoxColumn
            // 
            this.fiyatıDataGridViewTextBoxColumn.DataPropertyName = "Fiyatı";
            this.fiyatıDataGridViewTextBoxColumn.HeaderText = "Fiyatı";
            this.fiyatıDataGridViewTextBoxColumn.Name = "fiyatıDataGridViewTextBoxColumn";
            // 
            // ılacAciklamaDataGridViewTextBoxColumn
            // 
            this.ılacAciklamaDataGridViewTextBoxColumn.DataPropertyName = "IlacAciklama";
            this.ılacAciklamaDataGridViewTextBoxColumn.HeaderText = "IlacAciklama";
            this.ılacAciklamaDataGridViewTextBoxColumn.Name = "ılacAciklamaDataGridViewTextBoxColumn";
            this.ılacAciklamaDataGridViewTextBoxColumn.Width = 130;
            // 
            // ılacıTeslimAlanPersonelDataGridViewTextBoxColumn
            // 
            this.ılacıTeslimAlanPersonelDataGridViewTextBoxColumn.DataPropertyName = "IlacıTeslimAlanPersonel";
            this.ılacıTeslimAlanPersonelDataGridViewTextBoxColumn.HeaderText = "IlacıTeslimAlanPersonel";
            this.ılacıTeslimAlanPersonelDataGridViewTextBoxColumn.Name = "ılacıTeslimAlanPersonelDataGridViewTextBoxColumn";
            this.ılacıTeslimAlanPersonelDataGridViewTextBoxColumn.Width = 120;
            // 
            // ilaçBilgiBindingSource
            // 
            this.ilaçBilgiBindingSource.DataMember = "İlaçBilgi";
            this.ilaçBilgiBindingSource.DataSource = this.gPDonemOdevDataSet17;
            // 
            // gPDonemOdevDataSet17
            // 
            this.gPDonemOdevDataSet17.DataSetName = "GPDonemOdevDataSet17";
            this.gPDonemOdevDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // İlaçBilgiTableAdapter
            // 
            this.İlaçBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // Listele
            // 
            this.Listele.Location = new System.Drawing.Point(525, 26);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(75, 31);
            this.Listele.TabIndex = 25;
            this.Listele.Text = "Listele";
            this.Listele.UseVisualStyleBackColor = true;
            this.Listele.Click += new System.EventHandler(this.Listele_Click);
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(525, 69);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(75, 31);
            this.Kaydet.TabIndex = 26;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(230, 192);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(178, 65);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.Text = "";
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(525, 115);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(75, 31);
            this.Sil.TabIndex = 28;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Guncelle
            // 
            this.Guncelle.Location = new System.Drawing.Point(525, 152);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(75, 28);
            this.Guncelle.TabIndex = 29;
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.UseVisualStyleBackColor = true;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // Anasayfa
            // 
            this.Anasayfa.Location = new System.Drawing.Point(525, 192);
            this.Anasayfa.Name = "Anasayfa";
            this.Anasayfa.Size = new System.Drawing.Size(74, 24);
            this.Anasayfa.TabIndex = 30;
            this.Anasayfa.Text = "Anasayfa";
            this.Anasayfa.UseVisualStyleBackColor = true;
            this.Anasayfa.Click += new System.EventHandler(this.Anasayfa_Click);
            // 
            // Temizle
            // 
            this.Temizle.Location = new System.Drawing.Point(524, 232);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(75, 25);
            this.Temizle.TabIndex = 31;
            this.Temizle.Text = "Temizle";
            this.Temizle.UseVisualStyleBackColor = true;
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // İlacKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Temizle);
            this.Controls.Add(this.Anasayfa);
            this.Controls.Add(this.Guncelle);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.Listele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.fıyat);
            this.Controls.Add(this.ilacteslimalan);
            this.Controls.Add(this.ilacAdi);
            this.Controls.Add(this.BarkodNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.lkjkö);
            this.Controls.Add(this.IlacAd);
            this.Controls.Add(this.label1);
            this.Name = "İlacKaydet";
            this.Text = "ŞİFA ECZANESİ";
            this.Load += new System.EventHandler(this.İlacKaydet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilaçBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPDonemOdevDataSet17)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox fıyat;
        private System.Windows.Forms.TextBox ilacteslimalan;
        private System.Windows.Forms.TextBox ilacAdi;
        private System.Windows.Forms.MaskedTextBox BarkodNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label fiyat;
        private System.Windows.Forms.Label lkjkö;
        private System.Windows.Forms.Label IlacAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GPDonemOdevDataSet17 gPDonemOdevDataSet17;
        private System.Windows.Forms.BindingSource ilaçBilgiBindingSource;
        private GPDonemOdevDataSet17TableAdapters.İlaçBilgiTableAdapter İlaçBilgiTableAdapter;
        private System.Windows.Forms.Button Listele;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılacIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılacAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokSayısıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılacAciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılacıTeslimAlanPersonelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.Button Anasayfa;
        private System.Windows.Forms.Button Temizle;
    }
}