
namespace veritabanilab
{
    partial class fakulteislem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fakulteid = new System.Windows.Forms.TextBox();
            this.fakultead = new System.Windows.Forms.TextBox();
            this.ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fakülte ID : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fakülte Adı :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // fakulteid
            // 
            this.fakulteid.Location = new System.Drawing.Point(139, 40);
            this.fakulteid.Name = "fakulteid";
            this.fakulteid.Size = new System.Drawing.Size(198, 22);
            this.fakulteid.TabIndex = 2;
            this.fakulteid.TextChanged += new System.EventHandler(this.fakulteid_TextChanged);
            this.fakulteid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fakulteid_KeyPress);
            // 
            // fakultead
            // 
            this.fakultead.Location = new System.Drawing.Point(139, 111);
            this.fakultead.Name = "fakultead";
            this.fakultead.Size = new System.Drawing.Size(202, 22);
            this.fakultead.TabIndex = 3;
            this.fakultead.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(362, 66);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(100, 44);
            this.ekle.TabIndex = 4;
            this.ekle.Text = "FAKÜLTE EKLE";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // fakulteislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 188);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.fakultead);
            this.Controls.Add(this.fakulteid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fakulteislem";
            this.Text = "fakulteislem";
            this.Load += new System.EventHandler(this.fakulteislem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fakulteid;
        private System.Windows.Forms.TextBox fakultead;
        private System.Windows.Forms.Button ekle;
    }
}