
namespace veritabanilab
{
    partial class notgiris
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
            this.ogrenciDersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veritabanilabDataSet4 = new veritabanilab.veritabanilabDataSet4();
            this.final = new System.Windows.Forms.TextBox();
            this.vize = new System.Windows.Forms.TextBox();
            this.ogrenciDersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.veritabanilabDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ogrenciDersTableAdapter = new veritabanilab.veritabanilabDataSet4TableAdapters.OgrenciDersTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.ogrenciid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dersid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // ogrenciDersBindingSource
            // 
            this.ogrenciDersBindingSource.DataMember = "OgrenciDers";
            this.ogrenciDersBindingSource.DataSource = this.veritabanilabDataSet4;
            // 
            // veritabanilabDataSet4
            // 
            this.veritabanilabDataSet4.DataSetName = "veritabanilabDataSet4";
            this.veritabanilabDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // final
            // 
            this.final.Location = new System.Drawing.Point(666, 173);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(100, 22);
            this.final.TabIndex = 1;
            // 
            // vize
            // 
            this.vize.Location = new System.Drawing.Point(666, 121);
            this.vize.Name = "vize";
            this.vize.Size = new System.Drawing.Size(100, 22);
            this.vize.TabIndex = 2;
            // 
            // ogrenciDersBindingSource1
            // 
            this.ogrenciDersBindingSource1.DataMember = "OgrenciDers";
            this.ogrenciDersBindingSource1.DataSource = this.veritabanilabDataSet4BindingSource;
            // 
            // veritabanilabDataSet4BindingSource
            // 
            this.veritabanilabDataSet4BindingSource.DataSource = this.veritabanilabDataSet4;
            this.veritabanilabDataSet4BindingSource.Position = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(820, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 63);
            this.button2.TabIndex = 5;
            this.button2.Text = "Not Gir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Final : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ders ID : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vize :";
            // 
            // ogrenciDersTableAdapter
            // 
            this.ogrenciDersTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Öğrenci ID : ";
            // 
            // ogrenciid
            // 
            this.ogrenciid.Location = new System.Drawing.Point(666, 79);
            this.ogrenciid.Name = "ogrenciid";
            this.ogrenciid.Size = new System.Drawing.Size(100, 22);
            this.ogrenciid.TabIndex = 11;
            this.ogrenciid.TextChanged += new System.EventHandler(this.ogrenciid_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(820, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 56);
            this.button1.TabIndex = 12;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dersid
            // 
            this.dersid.Location = new System.Drawing.Point(666, 35);
            this.dersid.Name = "dersid";
            this.dersid.Size = new System.Drawing.Size(100, 22);
            this.dersid.TabIndex = 13;
            // 
            // notgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 249);
            this.Controls.Add(this.dersid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ogrenciid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.vize);
            this.Controls.Add(this.final);
            this.Controls.Add(this.dataGridView1);
            this.Name = "notgiris";
            this.Text = "notgiris";
            this.Load += new System.EventHandler(this.notgiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet4BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox final;
        private System.Windows.Forms.TextBox vize;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private veritabanilabDataSet4 veritabanilabDataSet4;
        private System.Windows.Forms.BindingSource ogrenciDersBindingSource;
        private veritabanilabDataSet4TableAdapters.OgrenciDersTableAdapter ogrenciDersTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource ogrenciDersBindingSource1;
        private System.Windows.Forms.BindingSource veritabanilabDataSet4BindingSource;
        private System.Windows.Forms.TextBox ogrenciid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dersid;
    }
}