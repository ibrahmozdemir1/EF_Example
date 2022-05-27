
namespace veritabanilab
{
    partial class bolumıslemleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bolumid = new System.Windows.Forms.TextBox();
            this.tBolumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veritabanilabDataSet1 = new veritabanilab.veritabanilabDataSet1();
            this.bolumad = new System.Windows.Forms.TextBox();
            this.fakulteid = new System.Windows.Forms.ComboBox();
            this.tFakultesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veritabanilabDataSet = new veritabanilab.veritabanilabDataSet();
            this.tFakultesTableAdapter = new veritabanilab.veritabanilabDataSetTableAdapters.tFakultesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tBolumsTableAdapter = new veritabanilab.veritabanilabDataSet1TableAdapters.tBolumsTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.fakulteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tBolumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFakultesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bölüm Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fakülte ID : ";
            // 
            // bolumid
            // 
            this.bolumid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBolumsBindingSource, "bolumID", true));
            this.bolumid.Location = new System.Drawing.Point(581, 22);
            this.bolumid.Name = "bolumid";
            this.bolumid.Size = new System.Drawing.Size(100, 22);
            this.bolumid.TabIndex = 3;
            this.bolumid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bolumid_KeyPress);
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
            // bolumad
            // 
            this.bolumad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBolumsBindingSource, "bolumAd", true));
            this.bolumad.Location = new System.Drawing.Point(581, 86);
            this.bolumad.Name = "bolumad";
            this.bolumad.Size = new System.Drawing.Size(100, 22);
            this.bolumad.TabIndex = 4;
            // 
            // fakulteid
            // 
            this.fakulteid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBolumsBindingSource, "fakulteID", true));
            this.fakulteid.DataSource = this.tFakultesBindingSource;
            this.fakulteid.DisplayMember = "fakulteID";
            this.fakulteid.FormattingEnabled = true;
            this.fakulteid.Location = new System.Drawing.Point(579, 149);
            this.fakulteid.Name = "fakulteid";
            this.fakulteid.Size = new System.Drawing.Size(121, 24);
            this.fakulteid.TabIndex = 5;
            this.fakulteid.SelectedIndexChanged += new System.EventHandler(this.fakulteid_SelectedIndexChanged);
            // 
            // tFakultesBindingSource
            // 
            this.tFakultesBindingSource.DataMember = "tFakultes";
            this.tFakultesBindingSource.DataSource = this.veritabanilabDataSet;
            // 
            // veritabanilabDataSet
            // 
            this.veritabanilabDataSet.DataSetName = "veritabanilabDataSet";
            this.veritabanilabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tFakultesTableAdapter
            // 
            this.tFakultesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Bölüm Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Bölüm Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tBolumsTableAdapter
            // 
            this.tBolumsTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(504, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 32);
            this.button3.TabIndex = 9;
            this.button3.Text = "Bölüm Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fakulteIDDataGridViewTextBoxColumn
            // 
            this.fakulteIDDataGridViewTextBoxColumn.DataPropertyName = "fakulteID";
            this.fakulteIDDataGridViewTextBoxColumn.HeaderText = "fakulteID";
            this.fakulteIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fakulteIDDataGridViewTextBoxColumn.Name = "fakulteIDDataGridViewTextBoxColumn";
            this.fakulteIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "bolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "bolumAd";
            this.bolumAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            this.bolumAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // bolumIDDataGridViewTextBoxColumn
            // 
            this.bolumIDDataGridViewTextBoxColumn.DataPropertyName = "bolumID";
            this.bolumIDDataGridViewTextBoxColumn.HeaderText = "bolumID";
            this.bolumIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumIDDataGridViewTextBoxColumn.Name = "bolumIDDataGridViewTextBoxColumn";
            this.bolumIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bolumIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumIDDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn,
            this.fakulteIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBolumsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(423, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bolumıslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 280);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fakulteid);
            this.Controls.Add(this.bolumad);
            this.Controls.Add(this.bolumid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "bolumıslemleri";
            this.Text = "bolumıslemleri";
            this.Load += new System.EventHandler(this.bolumıslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBolumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFakultesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bolumid;
        private System.Windows.Forms.TextBox bolumad;
        private System.Windows.Forms.ComboBox fakulteid;
        private veritabanilabDataSet veritabanilabDataSet;
        private System.Windows.Forms.BindingSource tFakultesBindingSource;
        private veritabanilabDataSetTableAdapters.tFakultesTableAdapter tFakultesTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private veritabanilabDataSet1 veritabanilabDataSet1;
        private System.Windows.Forms.BindingSource tBolumsBindingSource;
        private veritabanilabDataSet1TableAdapters.tBolumsTableAdapter tBolumsTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn fakulteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}