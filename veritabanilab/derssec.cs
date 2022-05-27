using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace veritabanilab
{
    public partial class derssec : Form
    {
        Entity.Context dbcontext = new Entity.Context();

        public object OgrenciDersTableAdapter { get; private set; }

        public derssec()
        {
            InitializeComponent();
            yilsec.Format = DateTimePickerFormat.Custom;
            yilsec.CustomFormat = "yyyy";
            yilsec.ShowUpDown = true;
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void derssec_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'veritabanilabDataSet4.OgrenciDers' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciDersTableAdapter.Fill(this.veritabanilabDataSet4.OgrenciDers);

            // TODO: Bu kod satırı 'veritabanilabDataSet3.tDers' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tDersTableAdapter.Fill(this.veritabanilabDataSet3.tDers);
            // TODO: Bu kod satırı 'veritabanilabDataSet2.tOgrencis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tOgrencisTableAdapter.Fill(this.veritabanilabDataSet2.tOgrencis);
            // TODO: Bu kod satırı 'veritabanilabDataSet4.OgrenciDers' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ogrenciid1 = Convert.ToInt32(ogrenciid.Text);
            int dersid1 = Convert.ToInt32(dersidd.Text);
            var dersislem = new Entity.OgrenciDers();
            dersislem.vize = 0;
            dersislem.final = 0;
            dersislem.dersID= dersid1;
            dersislem.ogrenciID = ogrenciid1;
            dersislem.yariyil = yariyil.Text;
            dersislem.yil = yilsec.Text;
            dataGridView1.Refresh();
            dbcontext.ogrenciDers.Add(dersislem);
            dbcontext.SaveChanges();
            MessageBox.Show("Öğrenciye Ders Eklendi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ogrenciid1 = Convert.ToInt32(ogrenciid.Text);
            int dersid1 = Convert.ToInt32(dersidd.Text);
            var derssorgu = dbcontext.ogrenciDers.Where(i => i.dersID == dersid1 && i.ogrenciID == ogrenciid1).FirstOrDefault();
            if (derssorgu != null)
            {
                derssorgu.yariyil = yariyil.Text;
                derssorgu.yil = yilsec.Text;
                dataGridView1.Refresh();
                MessageBox.Show("Öğrencinin Ders Bilgileri Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbcontext.SaveChanges();
            }
            else
            {
                MessageBox.Show("Lütfen derslerini güncellemek istediğiniz öğrenciyi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Silmek İstiyor Musunuz?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ogrenciid.Text != null)
                {
                    int ogrenciid1 = Convert.ToInt32(ogrenciid.Text);
                    int dersid1 = Convert.ToInt32(dersidd.Text);
                    var derssorgu = dbcontext.ogrenciDers.Where(i => i.dersID == dersid1 && i.ogrenciID == ogrenciid1).FirstOrDefault();
                    if (derssorgu != null)
                    {
                        dbcontext.ogrenciDers.Remove(derssorgu);
                        dataGridView1.Refresh();
                        MessageBox.Show("Öğrenciye Atanan Dersin Kaydı Silindi", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dbcontext.SaveChanges();
                        
                    }
                    else
                    {
                        MessageBox.Show("Lütfen silmek istediğiniz dersi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
