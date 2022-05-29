
namespace GörselProgramlamaDonemOdev
{
    partial class İlaclarıListele
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
            this.ilaçBilgiBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gPDonemOdevDataSet15 = new GörselProgramlamaDonemOdev.GPDonemOdevDataSet15();
            this.ilaçBilgiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gPDonemOdevDataSet10 = new GörselProgramlamaDonemOdev.GPDonemOdevDataSet10();
            this.gPDonemOdevDataSet8 = new GörselProgramlamaDonemOdev.GPDonemOdevDataSet8();
            this.ilaçBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.İlaçBilgiTableAdapter = new GörselProgramlamaDonemOdev.GPDonemOdevDataSet8TableAdapters.İlaçBilgiTableAdapter();
            this.Anasayfa = new System.Windows.Forms.Button();
            this.gPDonemOdevDataSet9 = new GörselProgramlamaDonemOdev.GPDonemOdevDataSet9();
            this.ilaçBilgiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.İlaçBilgiTableAdapter1 = new GörselProgramlamaDonemOdev.GPDonemOdevDataSet9TableAdapters.İlaçBilgiTableAdapter();
            this.İlaçBilgiTableAdapter2 = new GörselProgramlamaDonemOdev.GPDonemOdevDataSet10TableAdapters.İlaçBilgiTableAdapter();
            this.İlaçBilgiTableAdapter3 = new GörselProgramlamaDonemOdev.GPDonemOdevDataSet15TableAdapters.İlaçBilgiTableAdapter();
            this.ılacIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ılacAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokSayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ılacAciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ılacıTeslimAlanPersonelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilaçBilgiBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPDonemOdevDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilaçBilgiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPDonemOdevDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPDonemOdevDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilaçBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPDonemOdevDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilaçBilgiBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.DataSource = this.ilaçBilgiBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(-41, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(841, 388);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ilaçBilgiBindingSource3
            // 
            this.ilaçBilgiBindingSource3.DataMember = "İlaçBilgi";
            this.ilaçBilgiBindingSource3.DataSource = this.gPDonemOdevDataSet15;
            // 
            // gPDonemOdevDataSet15
            // 
            this.gPDonemOdevDataSet15.DataSetName = "GPDonemOdevDataSet15";
            this.gPDonemOdevDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ilaçBilgiBindingSource2
            // 
            this.ilaçBilgiBindingSource2.DataMember = "İlaçBilgi";
            this.ilaçBilgiBindingSource2.DataSource = this.gPDonemOdevDataSet10;
            // 
            // gPDonemOdevDataSet10
            // 
            this.gPDonemOdevDataSet10.DataSetName = "GPDonemOdevDataSet10";
            this.gPDonemOdevDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gPDonemOdevDataSet8
            // 
            this.gPDonemOdevDataSet8.DataSetName = "GPDonemOdevDataSet8";
            this.gPDonemOdevDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ilaçBilgiBindingSource
            // 
            this.ilaçBilgiBindingSource.DataMember = "İlaçBilgi";
            this.ilaçBilgiBindingSource.DataSource = this.gPDonemOdevDataSet8;
            // 
            // İlaçBilgiTableAdapter
            // 
            this.İlaçBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // Anasayfa
            // 
            this.Anasayfa.Location = new System.Drawing.Point(722, 392);
            this.Anasayfa.Name = "Anasayfa";
            this.Anasayfa.Size = new System.Drawing.Size(66, 21);
            this.Anasayfa.TabIndex = 1;
            this.Anasayfa.Text = "Anasayfa";
            this.Anasayfa.UseVisualStyleBackColor = false;
            this.Anasayfa.Click += new System.EventHandler(this.Anasayfa_Click);
            // 
            // gPDonemOdevDataSet9
            // 
            this.gPDonemOdevDataSet9.DataSetName = "GPDonemOdevDataSet9";
            this.gPDonemOdevDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ilaçBilgiBindingSource1
            // 
            this.ilaçBilgiBindingSource1.DataMember = "İlaçBilgi";
            this.ilaçBilgiBindingSource1.DataSource = this.gPDonemOdevDataSet9;
            // 
            // İlaçBilgiTableAdapter1
            // 
            this.İlaçBilgiTableAdapter1.ClearBeforeFill = true;
            // 
            // İlaçBilgiTableAdapter2
            // 
            this.İlaçBilgiTableAdapter2.ClearBeforeFill = true;
            // 
            // İlaçBilgiTableAdapter3
            // 
            this.İlaçBilgiTableAdapter3.ClearBeforeFill = true;
            // 
            // ılacIdDataGridViewTextBoxColumn
            // 
            this.ılacIdDataGridViewTextBoxColumn.DataPropertyName = "IlacId";
            this.ılacIdDataGridViewTextBoxColumn.HeaderText = "IlacId";
            this.ılacIdDataGridViewTextBoxColumn.Name = "ılacIdDataGridViewTextBoxColumn";
            this.ılacIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ılacIdDataGridViewTextBoxColumn.Width = 130;
            // 
            // barkodNoDataGridViewTextBoxColumn
            // 
            this.barkodNoDataGridViewTextBoxColumn.DataPropertyName = "BarkodNo";
            this.barkodNoDataGridViewTextBoxColumn.HeaderText = "BarkodNo";
            this.barkodNoDataGridViewTextBoxColumn.Name = "barkodNoDataGridViewTextBoxColumn";
            this.barkodNoDataGridViewTextBoxColumn.Width = 130;
            // 
            // ılacAdDataGridViewTextBoxColumn
            // 
            this.ılacAdDataGridViewTextBoxColumn.DataPropertyName = "IlacAd";
            this.ılacAdDataGridViewTextBoxColumn.HeaderText = "IlacAd";
            this.ılacAdDataGridViewTextBoxColumn.Name = "ılacAdDataGridViewTextBoxColumn";
            this.ılacAdDataGridViewTextBoxColumn.Width = 130;
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
            // 
            // ılacıTeslimAlanPersonelDataGridViewTextBoxColumn
            // 
            this.ılacıTeslimAlanPersonelDataGridViewTextBoxColumn.DataPropertyName = "IlacıTeslimAlanPersonel";
            this.ılacıTeslimAlanPersonelDataGridViewTextBoxColumn.HeaderText = "IlacıTeslimAlanPersonel";
            this.ılacıTeslimAlanPersonelDataGridViewTextBoxColumn.Name = "ılacıTeslimAlanPersonelDataGridViewTextBoxColumn";
            this.ılacıTeslimAlanPersonelDataGridViewTextBoxColumn.Width = 120;
            // 
            // İlaclarıListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Anasayfa);
            this.Controls.Add(this.dataGridView1);
            this.Name = "İlaclarıListele";
            this.Text = "ŞİFA ECZANESİ";
            this.Load += new System.EventHandler(this.İlaclarıListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilaçBilgiBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPDonemOdevDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilaçBilgiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPDonemOdevDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPDonemOdevDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilaçBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPDonemOdevDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilaçBilgiBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GPDonemOdevDataSet8 gPDonemOdevDataSet8;
        private System.Windows.Forms.BindingSource ilaçBilgiBindingSource;
        private GPDonemOdevDataSet8TableAdapters.İlaçBilgiTableAdapter İlaçBilgiTableAdapter;
        private System.Windows.Forms.Button Anasayfa;
        private GPDonemOdevDataSet9 gPDonemOdevDataSet9;
        private System.Windows.Forms.BindingSource ilaçBilgiBindingSource1;
        private GPDonemOdevDataSet9TableAdapters.İlaçBilgiTableAdapter İlaçBilgiTableAdapter1;
        private GPDonemOdevDataSet10 gPDonemOdevDataSet10;
        private System.Windows.Forms.BindingSource ilaçBilgiBindingSource2;
        private GPDonemOdevDataSet10TableAdapters.İlaçBilgiTableAdapter İlaçBilgiTableAdapter2;
        private GPDonemOdevDataSet15 gPDonemOdevDataSet15;
        private System.Windows.Forms.BindingSource ilaçBilgiBindingSource3;
        private GPDonemOdevDataSet15TableAdapters.İlaçBilgiTableAdapter İlaçBilgiTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılacIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılacAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokSayısıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılacAciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılacıTeslimAlanPersonelDataGridViewTextBoxColumn;
    }
}