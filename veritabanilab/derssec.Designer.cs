
namespace veritabanilab
{
    partial class derssec
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
            this.yilsec = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ogrenciid = new System.Windows.Forms.ComboBox();
            this.tOgrencisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veritabanilabDataSet2 = new veritabanilab.veritabanilabDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.dersid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dersidd = new System.Windows.Forms.ComboBox();
            this.tDersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veritabanilabDataSet3 = new veritabanilab.veritabanilabDataSet3();
            this.yariyil = new System.Windows.Forms.ComboBox();
            this.ogrenciDersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tOgrencisTableAdapter = new veritabanilab.veritabanilabDataSet2TableAdapters.tOgrencisTableAdapter();
            this.tDersTableAdapter = new veritabanilab.veritabanilabDataSet3TableAdapters.tDersTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.ogrenciDersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.veritabanilabDataSet4 = new veritabanilab.veritabanilabDataSet4();
            this.ogrenciDersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciDersTableAdapter = new veritabanilab.veritabanilabDataSet4TableAdapters.OgrenciDersTableAdapter();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tOgrencisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // yilsec
            // 
            this.yilsec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ogrenciDersBindingSource2, "yil", true));
            this.yilsec.Location = new System.Drawing.Point(131, 345);
            this.yilsec.Name = "yilsec";
            this.yilsec.Size = new System.Drawing.Size(121, 22);
            this.yilsec.TabIndex = 0;
            this.yilsec.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Öğrenciden Ders Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Derslerini Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(319, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(255, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Öğrenciye Ders Ata";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ogrenciid
            // 
            this.ogrenciid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOgrencisBindingSource, "ogrenciID", true));
            this.ogrenciid.DataSource = this.tOgrencisBindingSource;
            this.ogrenciid.DisplayMember = "ogrenciID";
            this.ogrenciid.FormattingEnabled = true;
            this.ogrenciid.Location = new System.Drawing.Point(131, 183);
            this.ogrenciid.Name = "ogrenciid";
            this.ogrenciid.Size = new System.Drawing.Size(121, 24);
            this.ogrenciid.TabIndex = 6;
            // 
            // tOgrencisBindingSource
            // 
            this.tOgrencisBindingSource.DataMember = "tOgrencis";
            this.tOgrencisBindingSource.DataSource = this.veritabanilabDataSet2;
            // 
            // veritabanilabDataSet2
            // 
            this.veritabanilabDataSet2.DataSetName = "veritabanilabDataSet2";
            this.veritabanilabDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Öğrenci ID : ";
            // 
            // dersid
            // 
            this.dersid.AutoSize = true;
            this.dersid.Location = new System.Drawing.Point(18, 238);
            this.dersid.Name = "dersid";
            this.dersid.Size = new System.Drawing.Size(63, 17);
            this.dersid.TabIndex = 8;
            this.dersid.Text = "Ders ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yarı Yıl : ";
            // 
            // dersidd
            // 
            this.dersidd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tDersBindingSource, "dersID", true));
            this.dersidd.DataSource = this.tDersBindingSource;
            this.dersidd.DisplayMember = "dersID";
            this.dersidd.FormattingEnabled = true;
            this.dersidd.Location = new System.Drawing.Point(131, 235);
            this.dersidd.Name = "dersidd";
            this.dersidd.Size = new System.Drawing.Size(121, 24);
            this.dersidd.TabIndex = 10;
            // 
            // tDersBindingSource
            // 
            this.tDersBindingSource.DataMember = "tDers";
            this.tDersBindingSource.DataSource = this.veritabanilabDataSet3;
            // 
            // veritabanilabDataSet3
            // 
            this.veritabanilabDataSet3.DataSetName = "veritabanilabDataSet3";
            this.veritabanilabDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yariyil
            // 
            this.yariyil.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ogrenciDersBindingSource2, "yariyil", true));
            this.yariyil.FormattingEnabled = true;
            this.yariyil.Items.AddRange(new object[] {
            "Güz",
            "Bahar"});
            this.yariyil.Location = new System.Drawing.Point(131, 290);
            this.yariyil.Name = "yariyil";
            this.yariyil.Size = new System.Drawing.Size(121, 24);
            this.yariyil.TabIndex = 11;
            // 
            // ogrenciDersBindingSource
            // 
            this.ogrenciDersBindingSource.DataMember = "OgrenciDers";
            // 
            // tOgrencisTableAdapter
            // 
            this.tOgrencisTableAdapter.ClearBeforeFill = true;
            // 
            // tDersTableAdapter
            // 
            this.tDersTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Yıl : ";
            // 
            // ogrenciDersBindingSource1
            // 
            this.ogrenciDersBindingSource1.DataMember = "OgrenciDers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.ogrenciDersBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(21, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 150);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // veritabanilabDataSet4
            // 
            this.veritabanilabDataSet4.DataSetName = "veritabanilabDataSet4";
            this.veritabanilabDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciDersBindingSource2
            // 
            this.ogrenciDersBindingSource2.DataMember = "OgrenciDers";
            this.ogrenciDersBindingSource2.DataSource = this.veritabanilabDataSet4;
            // 
            // ogrenciDersTableAdapter
            // 
            this.ogrenciDersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "dersID";
            this.dataGridViewTextBoxColumn2.FillWeight = 60F;
            this.dataGridViewTextBoxColumn2.HeaderText = "dersID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ogrenciID";
            this.dataGridViewTextBoxColumn1.FillWeight = 60F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ogrenciID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "yariyil";
            this.dataGridViewTextBoxColumn4.FillWeight = 60F;
            this.dataGridViewTextBoxColumn4.HeaderText = "yariyil";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "yil";
            this.dataGridViewTextBoxColumn3.FillWeight = 60F;
            this.dataGridViewTextBoxColumn3.HeaderText = "yil";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 90;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "vize";
            this.dataGridViewTextBoxColumn5.FillWeight = 60F;
            this.dataGridViewTextBoxColumn5.HeaderText = "vize";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 90;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "final";
            this.dataGridViewTextBoxColumn6.FillWeight = 60F;
            this.dataGridViewTextBoxColumn6.HeaderText = "final";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 90;
            // 
            // derssec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 381);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yariyil);
            this.Controls.Add(this.dersidd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dersid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ogrenciid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yilsec);
            this.Name = "derssec";
            this.Text = "derssec";
            this.Load += new System.EventHandler(this.derssec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tOgrencisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker yilsec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox ogrenciid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dersid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dersidd;
        private System.Windows.Forms.ComboBox yariyil;
       
        private System.Windows.Forms.BindingSource ogrenciDersBindingSource;
        
        private veritabanilabDataSet2 veritabanilabDataSet2;
        private System.Windows.Forms.BindingSource tOgrencisBindingSource;
        private veritabanilabDataSet2TableAdapters.tOgrencisTableAdapter tOgrencisTableAdapter;
        private veritabanilabDataSet3 veritabanilabDataSet3;
        private System.Windows.Forms.BindingSource tDersBindingSource;
        private veritabanilabDataSet3TableAdapters.tDersTableAdapter tDersTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource ogrenciDersBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yariyilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalDataGridViewTextBoxColumn;
        private veritabanilabDataSet4 veritabanilabDataSet4;
        private System.Windows.Forms.BindingSource ogrenciDersBindingSource2;
        private veritabanilabDataSet4TableAdapters.OgrenciDersTableAdapter ogrenciDersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}