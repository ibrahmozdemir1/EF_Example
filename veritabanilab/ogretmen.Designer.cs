
namespace veritabanilab
{
    partial class ogretmen
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
            this.button1 = new System.Windows.Forms.Button();
            this.ogretmenad = new System.Windows.Forms.TextBox();
            this.ogretmensoyad = new System.Windows.Forms.TextBox();
            this.ogretmenid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.veritabanilabDataSet5 = new veritabanilab.veritabanilabDataSet5();
            this.ogretmenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogretmenTableAdapter = new veritabanilab.veritabanilabDataSet5TableAdapters.OgretmenTableAdapter();
            this.ogrtIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veritabanilabDataSet7 = new veritabanilab.veritabanilabDataSet7();
            this.ogretmenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ogretmenTableAdapter1 = new veritabanilab.veritabanilabDataSet7TableAdapters.OgretmenTableAdapter();
            this.ogretmenBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrtAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrtsoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ogretmenad
            // 
            this.ogretmenad.Location = new System.Drawing.Point(600, 87);
            this.ogretmenad.Name = "ogretmenad";
            this.ogretmenad.Size = new System.Drawing.Size(100, 22);
            this.ogretmenad.TabIndex = 1;
            // 
            // ogretmensoyad
            // 
            this.ogretmensoyad.Location = new System.Drawing.Point(600, 131);
            this.ogretmensoyad.Name = "ogretmensoyad";
            this.ogretmensoyad.Size = new System.Drawing.Size(100, 22);
            this.ogretmensoyad.TabIndex = 2;
            // 
            // ogretmenid
            // 
            this.ogretmenid.Location = new System.Drawing.Point(600, 27);
            this.ogretmenid.Name = "ogretmenid";
            this.ogretmenid.Size = new System.Drawing.Size(100, 22);
            this.ogretmenid.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Öğretmen Soyadı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Öğretmen ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Öğretmen Adı :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrtIDDataGridViewTextBoxColumn,
            this.ogrtAd,
            this.ogrtsoyad});
            this.dataGridView1.DataSource = this.ogretmenBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(37, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(385, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // veritabanilabDataSet5
            // 
            this.veritabanilabDataSet5.DataSetName = "veritabanilabDataSet5";
            this.veritabanilabDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogretmenBindingSource
            // 
            this.ogretmenBindingSource.DataMember = "Ogretmen";
            this.ogretmenBindingSource.DataSource = this.veritabanilabDataSet5;
            // 
            // ogretmenTableAdapter
            // 
            this.ogretmenTableAdapter.ClearBeforeFill = true;
            // 
            // ogrtIDDataGridViewTextBoxColumn
            // 
            this.ogrtIDDataGridViewTextBoxColumn.DataPropertyName = "ogrtID";
            this.ogrtIDDataGridViewTextBoxColumn.HeaderText = "ogrtID";
            this.ogrtIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrtIDDataGridViewTextBoxColumn.Name = "ogrtIDDataGridViewTextBoxColumn";
            this.ogrtIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogrtIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // veritabanilabDataSet7
            // 
            this.veritabanilabDataSet7.DataSetName = "veritabanilabDataSet7";
            this.veritabanilabDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogretmenBindingSource1
            // 
            this.ogretmenBindingSource1.DataMember = "Ogretmen";
            this.ogretmenBindingSource1.DataSource = this.veritabanilabDataSet7;
            // 
            // ogretmenTableAdapter1
            // 
            this.ogretmenTableAdapter1.ClearBeforeFill = true;
            // 
            // ogretmenBindingSource2
            // 
            this.ogretmenBindingSource2.DataMember = "Ogretmen";
            this.ogretmenBindingSource2.DataSource = this.veritabanilabDataSet7;
            // 
            // ogrtAd
            // 
            this.ogrtAd.DataPropertyName = "ogrtAd";
            this.ogrtAd.HeaderText = "ogrtAd";
            this.ogrtAd.MinimumWidth = 6;
            this.ogrtAd.Name = "ogrtAd";
            this.ogrtAd.Width = 125;
            // 
            // ogrtsoyad
            // 
            this.ogrtsoyad.DataPropertyName = "ogrtsoyad";
            this.ogrtsoyad.HeaderText = "ogrtsoyad";
            this.ogrtsoyad.MinimumWidth = 6;
            this.ogrtsoyad.Name = "ogrtsoyad";
            this.ogrtsoyad.Width = 125;
            // 
            // ogretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 246);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ogretmenid);
            this.Controls.Add(this.ogretmensoyad);
            this.Controls.Add(this.ogretmenad);
            this.Controls.Add(this.button1);
            this.Name = "ogretmen";
            this.Text = "ogretmen";
            this.Load += new System.EventHandler(this.ogretmen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ogretmenad;
        private System.Windows.Forms.TextBox ogretmensoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ogretmenid;
        private veritabanilabDataSet5 veritabanilabDataSet5;
        private System.Windows.Forms.BindingSource ogretmenBindingSource;
        private veritabanilabDataSet5TableAdapters.OgretmenTableAdapter ogretmenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtIDDataGridViewTextBoxColumn;
        private veritabanilabDataSet7 veritabanilabDataSet7;
        private System.Windows.Forms.BindingSource ogretmenBindingSource1;
        private veritabanilabDataSet7TableAdapters.OgretmenTableAdapter ogretmenTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtsoyad;
        private System.Windows.Forms.BindingSource ogretmenBindingSource2;
    }
}