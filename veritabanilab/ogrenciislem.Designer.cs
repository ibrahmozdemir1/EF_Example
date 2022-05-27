
namespace veritabanilab
{
    partial class ogrenciislem
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
            this.ogrenciad = new System.Windows.Forms.TextBox();
            this.ogrenciid = new System.Windows.Forms.TextBox();
            this.ogrencisoyad = new System.Windows.Forms.TextBox();
            this.bolumid = new System.Windows.Forms.ComboBox();
            this.tBolumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veritabanilabDataSet1 = new veritabanilab.veritabanilabDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOgrencisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veritabanilabDataSet2 = new veritabanilab.veritabanilabDataSet2();
            this.tOgrencisTableAdapter = new veritabanilab.veritabanilabDataSet2TableAdapters.tOgrencisTableAdapter();
            this.tBolumsTableAdapter = new veritabanilab.veritabanilabDataSet1TableAdapters.tBolumsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tBolumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOgrencisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // ogrenciad
            // 
            this.ogrenciad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOgrencisBindingSource, "ad", true));
            this.ogrenciad.Location = new System.Drawing.Point(688, 79);
            this.ogrenciad.Name = "ogrenciad";
            this.ogrenciad.Size = new System.Drawing.Size(100, 22);
            this.ogrenciad.TabIndex = 0;
            // 
            // ogrenciid
            // 
            this.ogrenciid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOgrencisBindingSource, "ogrenciID", true));
            this.ogrenciid.Location = new System.Drawing.Point(688, 30);
            this.ogrenciid.Name = "ogrenciid";
            this.ogrenciid.Size = new System.Drawing.Size(100, 22);
            this.ogrenciid.TabIndex = 1;
            this.ogrenciid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ogrenciid_KeyPress);
            // 
            // ogrencisoyad
            // 
            this.ogrencisoyad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOgrencisBindingSource, "soyad", true));
            this.ogrencisoyad.Location = new System.Drawing.Point(688, 121);
            this.ogrencisoyad.Name = "ogrencisoyad";
            this.ogrencisoyad.Size = new System.Drawing.Size(100, 22);
            this.ogrencisoyad.TabIndex = 2;
            // 
            // bolumid
            // 
            this.bolumid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOgrencisBindingSource, "bolumID", true));
            this.bolumid.DataSource = this.tBolumsBindingSource;
            this.bolumid.DisplayMember = "bolumID";
            this.bolumid.FormattingEnabled = true;
            this.bolumid.Location = new System.Drawing.Point(667, 169);
            this.bolumid.Name = "bolumid";
            this.bolumid.Size = new System.Drawing.Size(121, 24);
            this.bolumid.TabIndex = 3;
            this.bolumid.ValueMember = "bolumID";
            // 
            // tBolumsBindingSource
            // 
            this.tBolumsBindingSource.DataMember = "tBolums";
            this.tBolumsBindingSource.DataSource = this.veritabanilabDataSet1;
            // 
            // veritabanilabDataSet1
            // 
            this.veritabanilabDataSet1.DataSetName = "veritabanilabDataSet1";
            this.veritabanilabDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Öğrenci ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Öğrenci Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Öğrenci Soyadı : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bölüm ID : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciIDDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.bolumIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tOgrencisBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 181);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ogrenciIDDataGridViewTextBoxColumn
            // 
            this.ogrenciIDDataGridViewTextBoxColumn.DataPropertyName = "ogrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.HeaderText = "ogrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciIDDataGridViewTextBoxColumn.Name = "ogrenciIDDataGridViewTextBoxColumn";
            this.ogrenciIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogrenciIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // bolumIDDataGridViewTextBoxColumn
            // 
            this.bolumIDDataGridViewTextBoxColumn.DataPropertyName = "bolumID";
            this.bolumIDDataGridViewTextBoxColumn.HeaderText = "bolumID";
            this.bolumIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumIDDataGridViewTextBoxColumn.Name = "bolumIDDataGridViewTextBoxColumn";
            this.bolumIDDataGridViewTextBoxColumn.Width = 125;
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
            // tOgrencisTableAdapter
            // 
            this.tOgrencisTableAdapter.ClearBeforeFill = true;
            // 
            // tBolumsTableAdapter
            // 
            this.tBolumsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Öğrenci Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(563, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Öğrenci Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(293, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 38);
            this.button3.TabIndex = 11;
            this.button3.Text = "Bilgileri Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ogrenciislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 311);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bolumid);
            this.Controls.Add(this.ogrencisoyad);
            this.Controls.Add(this.ogrenciid);
            this.Controls.Add(this.ogrenciad);
            this.Name = "ogrenciislem";
            this.Text = "ogrenciislem";
            this.Load += new System.EventHandler(this.ogrenciislem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBolumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOgrencisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ogrenciad;
        private System.Windows.Forms.TextBox ogrenciid;
        private System.Windows.Forms.TextBox ogrencisoyad;
        private System.Windows.Forms.ComboBox bolumid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private veritabanilabDataSet2 veritabanilabDataSet2;
        private System.Windows.Forms.BindingSource tOgrencisBindingSource;
        private veritabanilabDataSet2TableAdapters.tOgrencisTableAdapter tOgrencisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumIDDataGridViewTextBoxColumn;
        private veritabanilabDataSet1 veritabanilabDataSet1;
        private System.Windows.Forms.BindingSource tBolumsBindingSource;
        private veritabanilabDataSet1TableAdapters.tBolumsTableAdapter tBolumsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}