
namespace veritabanilab
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.fakulteEkle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Öğrenci İşlemleri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fakulteEkle
            // 
            this.fakulteEkle.Location = new System.Drawing.Point(42, 33);
            this.fakulteEkle.Name = "fakulteEkle";
            this.fakulteEkle.Size = new System.Drawing.Size(252, 58);
            this.fakulteEkle.TabIndex = 1;
            this.fakulteEkle.Text = "Fakülte Ekle";
            this.fakulteEkle.UseVisualStyleBackColor = true;
            this.fakulteEkle.Click += new System.EventHandler(this.fakulteEkle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "Bölüm Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(252, 53);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ders İşlemleri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(375, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(228, 58);
            this.button4.TabIndex = 4;
            this.button4.Text = "Ders Atama İşlemleri";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(375, 122);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(228, 56);
            this.button5.TabIndex = 5;
            this.button5.Text = "Ders Listeleme";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(375, 215);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(228, 50);
            this.button6.TabIndex = 6;
            this.button6.Text = "Not Girişi";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(375, 301);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(228, 53);
            this.button7.TabIndex = 7;
            this.button7.Text = "Öğretmen Ekle";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 401);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fakulteEkle);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button fakulteEkle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

