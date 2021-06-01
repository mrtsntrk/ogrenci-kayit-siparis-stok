
namespace efealayli
{
    partial class mainform
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
            this.ogrencikayitmodulbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ogrencikayitmodulbtn
            // 
            this.ogrencikayitmodulbtn.Location = new System.Drawing.Point(13, 22);
            this.ogrencikayitmodulbtn.Margin = new System.Windows.Forms.Padding(4);
            this.ogrencikayitmodulbtn.Name = "ogrencikayitmodulbtn";
            this.ogrencikayitmodulbtn.Size = new System.Drawing.Size(250, 84);
            this.ogrencikayitmodulbtn.TabIndex = 0;
            this.ogrencikayitmodulbtn.Text = "ÖĞRENCİ KAYIT MODÜLÜ";
            this.ogrencikayitmodulbtn.UseVisualStyleBackColor = true;
            this.ogrencikayitmodulbtn.Click += new System.EventHandler(this.ogrencikayitmodulbtn_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(271, 114);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 84);
            this.button2.TabIndex = 1;
            this.button2.Text = "ÜRÜN EKLEME MODÜLÜ\r\n[YAKINDA EKLENECEK]\r\n";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(13, 114);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 84);
            this.button3.TabIndex = 2;
            this.button3.Text = "SİPARİŞ EKLEME MODÜLÜ\r\n[YAKINDA EKLENECEK]";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(271, 22);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 84);
            this.button4.TabIndex = 3;
            this.button4.Text = "SİPARİŞ LİSTELEME MODÜLÜ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 220);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ogrencikayitmodulbtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜN TAKİP OTOMASYON";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ogrencikayitmodulbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

