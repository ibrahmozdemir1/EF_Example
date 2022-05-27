
namespace veritabanilab
{
    partial class derslistele
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
            this.dersgosterim = new System.Windows.Forms.DataGridView();
            this.ogrenciDersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.veritabanilabDataSet4 = new veritabanilab.veritabanilabDataSet4();
            this.ogrenciDersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrencibul = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ogrenciDersTableAdapter = new veritabanilab.veritabanilabDataSet4TableAdapters.OgrenciDersTableAdapter();
            this.yariyil = new System.Windows.Forms.ComboBox();
            this.tarihsec = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dersgosterim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dersgosterim
            // 
            this.dersgosterim.AllowUserToOrderColumns = true;
            this.dersgosterim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dersgosterim.Location = new System.Drawing.Point(12, 21);
            this.dersgosterim.Name = "dersgosterim";
            this.dersgosterim.RowHeadersWidth = 51;
            this.dersgosterim.RowTemplate.Height = 24;
            this.dersgosterim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dersgosterim.Size = new System.Drawing.Size(333, 178);
            this.dersgosterim.TabIndex = 0;
            this.dersgosterim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dersgosterim_CellContentClick);
            this.dersgosterim.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dersgosterim_CellContentClick);
            // 
            // ogrenciDersBindingSource1
            // 
            this.ogrenciDersBindingSource1.DataMember = "OgrenciDers";
            this.ogrenciDersBindingSource1.DataSource = this.veritabanilabDataSet4;
            // 
            // veritabanilabDataSet4
            // 
            this.veritabanilabDataSet4.DataSetName = "veritabanilabDataSet4";
            this.veritabanilabDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciDersBindingSource
            // 
            this.ogrenciDersBindingSource.DataMember = "OgrenciDers";
            // 
            // ogrencibul
            // 
            this.ogrencibul.Location = new System.Drawing.Point(491, 43);
            this.ogrencibul.Name = "ogrencibul";
            this.ogrencibul.Size = new System.Drawing.Size(100, 22);
            this.ogrencibul.TabIndex = 1;
            this.ogrencibul.TextChanged += new System.EventHandler(this.ogrencibul_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Öğrencinin Derslerini Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Öğrenci Numarası : ";
            // 
            // ogrenciDersTableAdapter
            // 
            this.ogrenciDersTableAdapter.ClearBeforeFill = true;
            // 
            // yariyil
            // 
            this.yariyil.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ogrenciDersBindingSource1, "yariyil", true));
            this.yariyil.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ogrenciDersBindingSource1, "yariyil", true));
            this.yariyil.DataSource = this.ogrenciDersBindingSource1;
            this.yariyil.DisplayMember = "yariyil";
            this.yariyil.FormattingEnabled = true;
            this.yariyil.Location = new System.Drawing.Point(110, 253);
            this.yariyil.Name = "yariyil";
            this.yariyil.Size = new System.Drawing.Size(121, 24);
            this.yariyil.TabIndex = 4;
            this.yariyil.ValueMember = "yariyil";
            // 
            // tarihsec
            // 
            this.tarihsec.Location = new System.Drawing.Point(110, 315);
            this.tarihsec.Name = "tarihsec";
            this.tarihsec.Size = new System.Drawing.Size(200, 22);
            this.tarihsec.TabIndex = 5;
            this.tarihsec.ValueChanged += new System.EventHandler(this.tarih_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yıl : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yarı Yıl :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 61);
            this.button2.TabIndex = 8;
            this.button2.Text = "Ders Toplamı Listele";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // derslistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 358);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tarihsec);
            this.Controls.Add(this.yariyil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ogrencibul);
            this.Controls.Add(this.dersgosterim);
            this.Name = "derslistele";
            this.Text = "derslistele";
            this.Load += new System.EventHandler(this.derslistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dersgosterim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanilabDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dersgosterim;
        private System.Windows.Forms.TextBox ogrencibul;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.BindingSource ogrenciDersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersIDDataGridViewTextBoxColumn;
        private veritabanilabDataSet4 veritabanilabDataSet4;
        private System.Windows.Forms.BindingSource ogrenciDersBindingSource1;
        private veritabanilabDataSet4TableAdapters.OgrenciDersTableAdapter ogrenciDersTableAdapter;
        private System.Windows.Forms.ComboBox yariyil;
        private System.Windows.Forms.DateTimePicker tarihsec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}