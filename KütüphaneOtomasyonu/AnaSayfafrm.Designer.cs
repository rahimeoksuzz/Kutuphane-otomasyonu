
namespace KütüphaneOtomasyonu
{
    partial class AnaSayfafrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnÜyeListele = new System.Windows.Forms.Button();
            this.btnÜyeEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKitapListele = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEmanetİade = new System.Windows.Forms.Button();
            this.btnEmanetListele = new System.Windows.Forms.Button();
            this.btnEmanetVer = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.btnSıralama = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnÜyeListele);
            this.groupBox1.Controls.Add(this.btnÜyeEkle);
            this.groupBox1.Location = new System.Drawing.Point(124, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye İşlemleri";
            // 
            // btnÜyeListele
            // 
            this.btnÜyeListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÜyeListele.Location = new System.Drawing.Point(15, 93);
            this.btnÜyeListele.Name = "btnÜyeListele";
            this.btnÜyeListele.Size = new System.Drawing.Size(223, 23);
            this.btnÜyeListele.TabIndex = 1;
            this.btnÜyeListele.Text = "Üye Listeleme İşlemleri";
            this.btnÜyeListele.UseVisualStyleBackColor = true;
            this.btnÜyeListele.Click += new System.EventHandler(this.btnÜyeListele_Click);
            // 
            // btnÜyeEkle
            // 
            this.btnÜyeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÜyeEkle.Location = new System.Drawing.Point(15, 41);
            this.btnÜyeEkle.Name = "btnÜyeEkle";
            this.btnÜyeEkle.Size = new System.Drawing.Size(223, 23);
            this.btnÜyeEkle.TabIndex = 0;
            this.btnÜyeEkle.Text = "Üye Ekleme İşlemleri";
            this.btnÜyeEkle.UseVisualStyleBackColor = true;
            this.btnÜyeEkle.Click += new System.EventHandler(this.btnÜyeEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKitapListele);
            this.groupBox2.Controls.Add(this.btnKitapEkle);
            this.groupBox2.Location = new System.Drawing.Point(448, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 142);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            // 
            // btnKitapListele
            // 
            this.btnKitapListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapListele.Location = new System.Drawing.Point(27, 93);
            this.btnKitapListele.Name = "btnKitapListele";
            this.btnKitapListele.Size = new System.Drawing.Size(202, 23);
            this.btnKitapListele.TabIndex = 1;
            this.btnKitapListele.Text = "Kitap Listeleme İşlemleri";
            this.btnKitapListele.UseVisualStyleBackColor = true;
            this.btnKitapListele.Click += new System.EventHandler(this.btnKitapListele_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapEkle.Location = new System.Drawing.Point(27, 31);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(202, 23);
            this.btnKitapEkle.TabIndex = 0;
            this.btnKitapEkle.Text = "Kitap Ekleme İşlemleri";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEmanetİade);
            this.groupBox3.Controls.Add(this.btnEmanetListele);
            this.groupBox3.Controls.Add(this.btnEmanetVer);
            this.groupBox3.Location = new System.Drawing.Point(96, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 139);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kitap Kiralama İşlemleri";
            // 
            // btnEmanetİade
            // 
            this.btnEmanetİade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetİade.Location = new System.Drawing.Point(43, 96);
            this.btnEmanetİade.Name = "btnEmanetİade";
            this.btnEmanetİade.Size = new System.Drawing.Size(223, 23);
            this.btnEmanetİade.TabIndex = 2;
            this.btnEmanetİade.Text = "Emanet Kitap İade İşlemleri";
            this.btnEmanetİade.UseVisualStyleBackColor = true;
            this.btnEmanetİade.Click += new System.EventHandler(this.btnEmanetİade_Click);
            // 
            // btnEmanetListele
            // 
            this.btnEmanetListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetListele.Location = new System.Drawing.Point(43, 67);
            this.btnEmanetListele.Name = "btnEmanetListele";
            this.btnEmanetListele.Size = new System.Drawing.Size(223, 23);
            this.btnEmanetListele.TabIndex = 1;
            this.btnEmanetListele.Text = "Emanet Kitap Listeleme İşlemleri";
            this.btnEmanetListele.UseVisualStyleBackColor = true;
            this.btnEmanetListele.Click += new System.EventHandler(this.btnEmanetListele_Click);
            // 
            // btnEmanetVer
            // 
            this.btnEmanetVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetVer.Location = new System.Drawing.Point(43, 38);
            this.btnEmanetVer.Name = "btnEmanetVer";
            this.btnEmanetVer.Size = new System.Drawing.Size(223, 23);
            this.btnEmanetVer.TabIndex = 0;
            this.btnEmanetVer.Text = "Emanet Kitap Verme İşlemleri";
            this.btnEmanetVer.UseVisualStyleBackColor = true;
            this.btnEmanetVer.Click += new System.EventHandler(this.btnEmanetVer_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGrafik);
            this.groupBox4.Controls.Add(this.btnSıralama);
            this.groupBox4.Location = new System.Drawing.Point(448, 227);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 139);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İstatistik";
            // 
            // btnGrafik
            // 
            this.btnGrafik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGrafik.Location = new System.Drawing.Point(30, 89);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(199, 23);
            this.btnGrafik.TabIndex = 1;
            this.btnGrafik.Text = "Grafikler";
            this.btnGrafik.UseVisualStyleBackColor = true;
            this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click);
            // 
            // btnSıralama
            // 
            this.btnSıralama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSıralama.Location = new System.Drawing.Point(27, 41);
            this.btnSıralama.Name = "btnSıralama";
            this.btnSıralama.Size = new System.Drawing.Size(202, 23);
            this.btnSıralama.TabIndex = 0;
            this.btnSıralama.Text = "Sıralama";
            this.btnSıralama.UseVisualStyleBackColor = true;
            this.btnSıralama.Click += new System.EventHandler(this.btnSıralama_Click);
            // 
            // AnaSayfafrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnaSayfafrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnÜyeListele;
        private System.Windows.Forms.Button btnÜyeEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKitapListele;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEmanetİade;
        private System.Windows.Forms.Button btnEmanetListele;
        private System.Windows.Forms.Button btnEmanetVer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.Button btnSıralama;
    }
}

