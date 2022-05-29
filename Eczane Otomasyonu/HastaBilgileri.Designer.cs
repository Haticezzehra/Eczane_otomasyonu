
namespace GörselProgramlamaDonemOdev
{
    partial class HastaBilgileri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adıSoyadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sosyalGüvencesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullandıgıilacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanımSıklıgıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaBilgiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gPDonemOdevDataSet14 = new GörselProgramlamaDonemOdev.GPDonemOdevDataSet14();
            this.hastaBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gPDonemOdevDataSet4 = new GörselProgramlamaDonemOdev.GPDonemOdevDataSet4();
            this.hastaBilgiTableAdapter = new GörselProgramlamaDonemOdev.GPDonemOdevDataSet4TableAdapters.HastaBilgiTableAdapter();
            this.hastaBilgiTableAdapter1 = new GörselProgramlamaDonemOdev.GPDonemOdevDataSet14TableAdapters.HastaBilgiTableAdapter();
            this.Anasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBilgiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPDonemOdevDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPDonemOdevDataSet4)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(-44, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(883, 427);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tCDataGridViewTextBoxColumn
            // 
            this.tCDataGridViewTextBoxColumn.DataPropertyName = "TC";
            this.tCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.tCDataGridViewTextBoxColumn.Name = "tCDataGridViewTextBoxColumn";
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
            this.kullandıgıilacDataGridViewTextBoxColumn.Width = 120;
            // 
            // kullanımSıklıgıDataGridViewTextBoxColumn
            // 
            this.kullanımSıklıgıDataGridViewTextBoxColumn.DataPropertyName = "KullanımSıklıgı";
            this.kullanımSıklıgıDataGridViewTextBoxColumn.HeaderText = "KullanımSıklıgı";
            this.kullanımSıklıgıDataGridViewTextBoxColumn.Name = "kullanımSıklıgıDataGridViewTextBoxColumn";
            this.kullanımSıklıgıDataGridViewTextBoxColumn.Width = 120;
            // 
            // hastaBilgiBindingSource1
            // 
            this.hastaBilgiBindingSource1.DataMember = "HastaBilgi";
            this.hastaBilgiBindingSource1.DataSource = this.gPDonemOdevDataSet14;
            // 
            // gPDonemOdevDataSet14
            // 
            this.gPDonemOdevDataSet14.DataSetName = "GPDonemOdevDataSet14";
            this.gPDonemOdevDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaBilgiBindingSource
            // 
            this.hastaBilgiBindingSource.DataMember = "HastaBilgi";
            this.hastaBilgiBindingSource.DataSource = this.gPDonemOdevDataSet4;
            // 
            // gPDonemOdevDataSet4
            // 
            this.gPDonemOdevDataSet4.DataSetName = "GPDonemOdevDataSet4";
            this.gPDonemOdevDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaBilgiTableAdapter
            // 
            this.hastaBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // hastaBilgiTableAdapter1
            // 
            this.hastaBilgiTableAdapter1.ClearBeforeFill = true;
            // 
            // Anasayfa
            // 
            this.Anasayfa.Location = new System.Drawing.Point(722, 423);
            this.Anasayfa.Name = "Anasayfa";
            this.Anasayfa.Size = new System.Drawing.Size(81, 28);
            this.Anasayfa.TabIndex = 1;
            this.Anasayfa.Text = "Anasayfa";
            this.Anasayfa.UseVisualStyleBackColor = true;
            this.Anasayfa.Click += new System.EventHandler(this.Anasayfa_Click);
            // 
            // HastaBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Anasayfa);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HastaBilgileri";
            this.Text = "ŞİFA ECZANESİ";
            this.Load += new System.EventHandler(this.HastaBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBilgiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPDonemOdevDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPDonemOdevDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GPDonemOdevDataSet4 gPDonemOdevDataSet4;
        private System.Windows.Forms.BindingSource hastaBilgiBindingSource;
        private GPDonemOdevDataSet4TableAdapters.HastaBilgiTableAdapter hastaBilgiTableAdapter;
        private GPDonemOdevDataSet14 gPDonemOdevDataSet14;
        private System.Windows.Forms.BindingSource hastaBilgiBindingSource1;
        private GPDonemOdevDataSet14TableAdapters.HastaBilgiTableAdapter hastaBilgiTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adıSoyadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sosyalGüvencesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullandıgıilacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanımSıklıgıDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Anasayfa;
    }
}