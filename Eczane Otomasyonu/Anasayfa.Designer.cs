
namespace GörselProgramlamaDonemOdev
{
    partial class Anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.Hasta_Kayıt = new System.Windows.Forms.Button();
            this.Hasta_Bilgileri = new System.Windows.Forms.Button();
            this.Personel_Bilgileri = new System.Windows.Forms.Button();
            this.Çıkış = new System.Windows.Forms.Button();
            this.IlacBilgileri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Hasta_Kayıt
            // 
            this.Hasta_Kayıt.BackColor = System.Drawing.Color.Brown;
            this.Hasta_Kayıt.Location = new System.Drawing.Point(52, 180);
            this.Hasta_Kayıt.Name = "Hasta_Kayıt";
            this.Hasta_Kayıt.Size = new System.Drawing.Size(100, 65);
            this.Hasta_Kayıt.TabIndex = 0;
            this.Hasta_Kayıt.Text = "Hasta Kayıt";
            this.Hasta_Kayıt.UseVisualStyleBackColor = false;
            this.Hasta_Kayıt.Click += new System.EventHandler(this.Hasta_Kayıt_Click);
            // 
            // Hasta_Bilgileri
            // 
            this.Hasta_Bilgileri.BackColor = System.Drawing.Color.Brown;
            this.Hasta_Bilgileri.Location = new System.Drawing.Point(193, 180);
            this.Hasta_Bilgileri.Name = "Hasta_Bilgileri";
            this.Hasta_Bilgileri.Size = new System.Drawing.Size(100, 65);
            this.Hasta_Bilgileri.TabIndex = 1;
            this.Hasta_Bilgileri.Text = "Hasta Listesi";
            this.Hasta_Bilgileri.UseVisualStyleBackColor = false;
            this.Hasta_Bilgileri.Click += new System.EventHandler(this.Hasta_Bilgileri_Click);
            // 
            // Personel_Bilgileri
            // 
            this.Personel_Bilgileri.BackColor = System.Drawing.Color.Brown;
            this.Personel_Bilgileri.Location = new System.Drawing.Point(324, 180);
            this.Personel_Bilgileri.Name = "Personel_Bilgileri";
            this.Personel_Bilgileri.Size = new System.Drawing.Size(100, 65);
            this.Personel_Bilgileri.TabIndex = 2;
            this.Personel_Bilgileri.Text = "Personel Bilgileri";
            this.Personel_Bilgileri.UseVisualStyleBackColor = false;
            this.Personel_Bilgileri.Click += new System.EventHandler(this.Personel_Bilgileri_Click);
            // 
            // Çıkış
            // 
            this.Çıkış.BackColor = System.Drawing.Color.Brown;
            this.Çıkış.Location = new System.Drawing.Point(471, 180);
            this.Çıkış.Name = "Çıkış";
            this.Çıkış.Size = new System.Drawing.Size(100, 65);
            this.Çıkış.TabIndex = 3;
            this.Çıkış.Text = "Çıkış";
            this.Çıkış.UseVisualStyleBackColor = false;
            this.Çıkış.Click += new System.EventHandler(this.Çıkış_Click);
            // 
            // IlacBilgileri
            // 
            this.IlacBilgileri.BackColor = System.Drawing.Color.Brown;
            this.IlacBilgileri.Location = new System.Drawing.Point(619, 180);
            this.IlacBilgileri.Name = "IlacBilgileri";
            this.IlacBilgileri.Size = new System.Drawing.Size(109, 66);
            this.IlacBilgileri.TabIndex = 4;
            this.IlacBilgileri.Text = "İlaç İşlemleri";
            this.IlacBilgileri.UseVisualStyleBackColor = false;
            this.IlacBilgileri.Click += new System.EventHandler(this.IlacBilgileri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 95);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(132, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(238, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "ŞİFA ECZANESİ";
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IlacBilgileri);
            this.Controls.Add(this.Çıkış);
            this.Controls.Add(this.Personel_Bilgileri);
            this.Controls.Add(this.Hasta_Bilgileri);
            this.Controls.Add(this.Hasta_Kayıt);
            this.Name = "Anasayfa";
            this.Text = "ŞİFA ECZANESİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hasta_Kayıt;
        private System.Windows.Forms.Button Hasta_Bilgileri;
        private System.Windows.Forms.Button Personel_Bilgileri;
        private System.Windows.Forms.Button Çıkış;
        private System.Windows.Forms.Button IlacBilgileri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

