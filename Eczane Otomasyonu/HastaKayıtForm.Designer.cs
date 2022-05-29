
namespace GörselProgramlamaDonemOdev
{
    partial class HastaKayıtForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TcKimlik = new System.Windows.Forms.MaskedTextBox();
            this.AdSoyad = new System.Windows.Forms.Label();
            this.textBoxAdsoyad = new System.Windows.Forms.TextBox();
            this.SosyalGüvence = new System.Windows.Forms.Label();
            this.SosyalGuvencecombo = new System.Windows.Forms.ComboBox();
            this.Adres = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TelefonNo = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ılacBilgiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gPDonemOdevDataSet1 = new GörselProgramlamaDonemOdev.GPDonemOdevDataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Temizle = new System.Windows.Forms.Button();
            this.Anasayfa = new System.Windows.Forms.Button();
            this.gPDonemOdevDataSet = new GörselProgramlamaDonemOdev.GPDonemOdevDataSet();
            this.ılacBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ilacBilgiTableAdapter = new GörselProgramlamaDonemOdev.GPDonemOdevDataSetTableAdapters.IlacBilgiTableAdapter();
            this.ilacBilgiTableAdapter1 = new GörselProgramlamaDonemOdev.GPDonemOdevDataSet1TableAdapters.IlacBilgiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adıSoyadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sosyalGüvencesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullandıgıilacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanımSıklıgıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaBilgiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gPDonemOdevDataSet13 = new GörselProgramlamaDonemOdev.GPDonemOdevDataSet13();
            this.hastaBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gPDonemOdevDataSet11 = new GörselProgramlamaDonemOdev.GPDonemOdevDataSet11();
            this.hastaBilgiTableAdapter = new GörselProgramlamaDonemOdev.GPDonemOdevDataSet11TableAdapters.HastaBilgiTableAdapter();
            this.Guncelle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.hastaBilgiTableAdapter1 = new GörselProgramlamaDonemOdev.GPDonemOdevDataSet13TableAdapters.HastaBilgiTableAdapter();
            this.KullanımSıklıgı = new System.Windows.Forms.MaskedTextBox();
            this.ilaçBilgiTableAdapter1 = new GörselProgramlamaDonemOdev.GPDonemOdevDataSet10TableAdapters.İlaçBilgiTableAdapter();
            this.Kullandigiİlac = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ılacBilgiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPDonemOdevDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPDonemOdevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ılacBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBilgiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPDonemOdevDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPDonemOdevDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik:";
            // 
            // TcKimlik
            // 
            this.TcKimlik.Location = new System.Drawing.Point(134, 193);
            this.TcKimlik.Mask = "00000000000";
            this.TcKimlik.Name = "TcKimlik";
            this.TcKimlik.Size = new System.Drawing.Size(151, 20);
            this.TcKimlik.TabIndex = 1;
            this.TcKimlik.ValidatingType = typeof(int);
            // 
            // AdSoyad
            // 
            this.AdSoyad.AutoSize = true;
            this.AdSoyad.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdSoyad.Location = new System.Drawing.Point(54, 231);
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.Size = new System.Drawing.Size(74, 18);
            this.AdSoyad.TabIndex = 2;
            this.AdSoyad.Text = "Ad- Soyad:";
            // 
            // textBoxAdsoyad
            // 
            this.textBoxAdsoyad.Location = new System.Drawing.Point(134, 229);
            this.textBoxAdsoyad.Name = "textBoxAdsoyad";
            this.textBoxAdsoyad.Size = new System.Drawing.Size(151, 20);
            this.textBoxAdsoyad.TabIndex = 3;
            // 
            // SosyalGüvence
            // 
            this.SosyalGüvence.AutoSize = true;
            this.SosyalGüvence.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SosyalGüvence.Location = new System.Drawing.Point(531, 195);
            this.SosyalGüvence.Name = "SosyalGüvence";
            this.SosyalGüvence.Size = new System.Drawing.Size(119, 18);
            this.SosyalGüvence.TabIndex = 4;
            this.SosyalGüvence.Text = "Sosyal Güvencesi:";
            // 
            // SosyalGuvencecombo
            // 
            this.SosyalGuvencecombo.FormattingEnabled = true;
            this.SosyalGuvencecombo.Location = new System.Drawing.Point(656, 193);
            this.SosyalGuvencecombo.Name = "SosyalGuvencecombo";
            this.SosyalGuvencecombo.Size = new System.Drawing.Size(177, 19);
            this.SosyalGuvencecombo.TabIndex = 5;
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(656, 236);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(177, 67);
            this.Adres.TabIndex = 6;
            this.Adres.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(599, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adres:";
            // 
            // TelefonNo
            // 
            this.TelefonNo.Location = new System.Drawing.Point(134, 265);
            this.TelefonNo.Mask = "00000000000";
            this.TelefonNo.Name = "TelefonNo";
            this.TelefonNo.Size = new System.Drawing.Size(151, 20);
            this.TelefonNo.TabIndex = 8;
            this.TelefonNo.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(48, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefon No:";
            // 
            // ılacBilgiBindingSource1
            // 
            this.ılacBilgiBindingSource1.DataMember = "IlacBilgi";
            this.ılacBilgiBindingSource1.DataSource = this.gPDonemOdevDataSet1;
            // 
            // gPDonemOdevDataSet1
            // 
            this.gPDonemOdevDataSet1.DataSetName = "GPDonemOdevDataSet1";
            this.gPDonemOdevDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kullandığı İlaç:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(25, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kullanım Sıklığı";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Temizle
            // 
            this.Temizle.Location = new System.Drawing.Point(332, 356);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(79, 23);
            this.Temizle.TabIndex = 15;
            this.Temizle.Text = "Temizle";
            this.Temizle.UseVisualStyleBackColor = true;
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // Anasayfa
            // 
            this.Anasayfa.Location = new System.Drawing.Point(426, 356);
            this.Anasayfa.Name = "Anasayfa";
            this.Anasayfa.Size = new System.Drawing.Size(79, 23);
            this.Anasayfa.TabIndex = 16;
            this.Anasayfa.Text = "Anasayfa";
            this.Anasayfa.UseVisualStyleBackColor = true;
            this.Anasayfa.Click += new System.EventHandler(this.Anasayfa_Click);
            // 
            // gPDonemOdevDataSet
            // 
            this.gPDonemOdevDataSet.DataSetName = "GPDonemOdevDataSet";
            this.gPDonemOdevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ılacBilgiBindingSource
            // 
            this.ılacBilgiBindingSource.DataMember = "IlacBilgi";
            this.ılacBilgiBindingSource.DataSource = this.gPDonemOdevDataSet;
            // 
            // ilacBilgiTableAdapter
            // 
            this.ilacBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // ilacBilgiTableAdapter1
            // 
            this.ilacBilgiTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tCDataGridViewTextBoxColumn,
            this.adıSoyadıDataGridViewTextBoxColumn,
            this.sosyalGüvencesiDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.telefonuDataGridViewTextBoxColumn,
            this.kullandıgıilacDataGridViewTextBoxColumn,
            this.kullanımSıklıgıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hastaBilgiBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-40, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(992, 179);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // tCDataGridViewTextBoxColumn
            // 
            this.tCDataGridViewTextBoxColumn.DataPropertyName = "TC";
            this.tCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.tCDataGridViewTextBoxColumn.Name = "tCDataGridViewTextBoxColumn";
            this.tCDataGridViewTextBoxColumn.Width = 120;
            // 
            // adıSoyadıDataGridViewTextBoxColumn
            // 
            this.adıSoyadıDataGridViewTextBoxColumn.DataPropertyName = "AdıSoyadı";
            this.adıSoyadıDataGridViewTextBoxColumn.HeaderText = "AdıSoyadı";
            this.adıSoyadıDataGridViewTextBoxColumn.Name = "adıSoyadıDataGridViewTextBoxColumn";
            this.adıSoyadıDataGridViewTextBoxColumn.Width = 120;
            // 
            // sosyalGüvencesiDataGridViewTextBoxColumn
            // 
            this.sosyalGüvencesiDataGridViewTextBoxColumn.DataPropertyName = "SosyalGüvencesi";
            this.sosyalGüvencesiDataGridViewTextBoxColumn.HeaderText = "SosyalGüvencesi";
            this.sosyalGüvencesiDataGridViewTextBoxColumn.Name = "sosyalGüvencesiDataGridViewTextBoxColumn";
            this.sosyalGüvencesiDataGridViewTextBoxColumn.Width = 120;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 120;
            // 
            // telefonuDataGridViewTextBoxColumn
            // 
            this.telefonuDataGridViewTextBoxColumn.DataPropertyName = "Telefonu";
            this.telefonuDataGridViewTextBoxColumn.HeaderText = "Telefonu";
            this.telefonuDataGridViewTextBoxColumn.Name = "telefonuDataGridViewTextBoxColumn";
            this.telefonuDataGridViewTextBoxColumn.Width = 120;
            // 
            // kullandıgıilacDataGridViewTextBoxColumn
            // 
            this.kullandıgıilacDataGridViewTextBoxColumn.DataPropertyName = "Kullandıgıilac";
            this.kullandıgıilacDataGridViewTextBoxColumn.HeaderText = "Kullandıgıilac";
            this.kullandıgıilacDataGridViewTextBoxColumn.Name = "kullandıgıilacDataGridViewTextBoxColumn";
            this.kullandıgıilacDataGridViewTextBoxColumn.Width = 150;
            // 
            // kullanımSıklıgıDataGridViewTextBoxColumn
            // 
            this.kullanımSıklıgıDataGridViewTextBoxColumn.DataPropertyName = "KullanımSıklıgı";
            this.kullanımSıklıgıDataGridViewTextBoxColumn.HeaderText = "KullanımSıklıgı";
            this.kullanımSıklıgıDataGridViewTextBoxColumn.Name = "kullanımSıklıgıDataGridViewTextBoxColumn";
            this.kullanımSıklıgıDataGridViewTextBoxColumn.Width = 150;
            // 
            // hastaBilgiBindingSource1
            // 
            this.hastaBilgiBindingSource1.DataMember = "HastaBilgi";
            this.hastaBilgiBindingSource1.DataSource = this.gPDonemOdevDataSet13;
            // 
            // gPDonemOdevDataSet13
            // 
            this.gPDonemOdevDataSet13.DataSetName = "GPDonemOdevDataSet13";
            this.gPDonemOdevDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaBilgiBindingSource
            // 
            this.hastaBilgiBindingSource.DataMember = "HastaBilgi";
            this.hastaBilgiBindingSource.DataSource = this.gPDonemOdevDataSet11;
            // 
            // gPDonemOdevDataSet11
            // 
            this.gPDonemOdevDataSet11.DataSetName = "GPDonemOdevDataSet11";
            this.gPDonemOdevDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaBilgiTableAdapter
            // 
            this.hastaBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // Guncelle
            // 
            this.Guncelle.Location = new System.Drawing.Point(521, 356);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(75, 23);
            this.Guncelle.TabIndex = 18;
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.UseVisualStyleBackColor = true;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(602, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // hastaBilgiTableAdapter1
            // 
            this.hastaBilgiTableAdapter1.ClearBeforeFill = true;
            // 
            // KullanımSıklıgı
            // 
            this.KullanımSıklıgı.Location = new System.Drawing.Point(134, 330);
            this.KullanımSıklıgı.Mask = "00";
            this.KullanımSıklıgı.Name = "KullanımSıklıgı";
            this.KullanımSıklıgı.Size = new System.Drawing.Size(151, 20);
            this.KullanımSıklıgı.TabIndex = 20;
            this.KullanımSıklıgı.ValidatingType = typeof(int);
            // 
            // ilaçBilgiTableAdapter1
            // 
            this.ilaçBilgiTableAdapter1.ClearBeforeFill = true;
            // 
            // Kullandigiİlac
            // 
            this.Kullandigiİlac.FormattingEnabled = true;
            this.Kullandigiİlac.Items.AddRange(new object[] {
            "Parol",
            "Katarin",
            "ColdC",
            "Zeratonin",
            "Acnetrend",
            "Aferin",
            "Dolven Şurup"});
            this.Kullandigiİlac.Location = new System.Drawing.Point(134, 300);
            this.Kullandigiİlac.Name = "Kullandigiİlac";
            this.Kullandigiİlac.Size = new System.Drawing.Size(151, 19);
            this.Kullandigiİlac.TabIndex = 21;
            // 
            // HastaKayıtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(845, 381);
            this.Controls.Add(this.Kullandigiİlac);
            this.Controls.Add(this.KullanımSıklıgı);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Guncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Anasayfa);
            this.Controls.Add(this.Temizle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TelefonNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.SosyalGuvencecombo);
            this.Controls.Add(this.SosyalGüvence);
            this.Controls.Add(this.textBoxAdsoyad);
            this.Controls.Add(this.AdSoyad);
            this.Controls.Add(this.TcKimlik);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HastaKayıtForm";
            this.Text = "ŞİFA ECZANESİ";
            this.Load += new System.EventHandler(this.HastaKayıtForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ılacBilgiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPDonemOdevDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPDonemOdevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ılacBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBilgiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPDonemOdevDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPDonemOdevDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TcKimlik;
        private System.Windows.Forms.Label AdSoyad;
        private System.Windows.Forms.TextBox textBoxAdsoyad;
        private System.Windows.Forms.Label SosyalGüvence;
        private System.Windows.Forms.ComboBox SosyalGuvencecombo;
        private System.Windows.Forms.RichTextBox Adres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TelefonNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Temizle;
        private System.Windows.Forms.Button Anasayfa;
        private GPDonemOdevDataSet gPDonemOdevDataSet;
        private System.Windows.Forms.BindingSource ılacBilgiBindingSource;
        private GPDonemOdevDataSetTableAdapters.IlacBilgiTableAdapter ilacBilgiTableAdapter;
        private GPDonemOdevDataSet1 gPDonemOdevDataSet1;
        private System.Windows.Forms.BindingSource ılacBilgiBindingSource1;
        private GPDonemOdevDataSet1TableAdapters.IlacBilgiTableAdapter ilacBilgiTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GPDonemOdevDataSet11 gPDonemOdevDataSet11;
        private System.Windows.Forms.BindingSource hastaBilgiBindingSource;
        private GPDonemOdevDataSet11TableAdapters.HastaBilgiTableAdapter hastaBilgiTableAdapter;
        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.Button button3;
        private GPDonemOdevDataSet13 gPDonemOdevDataSet13;
        private System.Windows.Forms.BindingSource hastaBilgiBindingSource1;
        private GPDonemOdevDataSet13TableAdapters.HastaBilgiTableAdapter hastaBilgiTableAdapter1;
        private System.Windows.Forms.MaskedTextBox KullanımSıklıgı;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adıSoyadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sosyalGüvencesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullandıgıilacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanımSıklıgıDataGridViewTextBoxColumn;
        private GPDonemOdevDataSet10TableAdapters.İlaçBilgiTableAdapter ilaçBilgiTableAdapter1;
        private System.Windows.Forms.ComboBox Kullandigiİlac;
    }
}