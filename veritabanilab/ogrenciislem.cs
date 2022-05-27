using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritabanilab
{
    public partial class ogrenciislem : Form
    {
        Entity.Context dbcontext = new Entity.Context();
        public ogrenciislem()
        {
            InitializeComponent();
        }

        private void ogrenciislem_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'veritabanilabDataSet1.tBolums' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBolumsTableAdapter.Fill(this.veritabanilabDataSet1.tBolums);
            // TODO: Bu kod satırı 'veritabanilabDataSet2.tOgrencis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tOgrencisTableAdapter.Fill(this.veritabanilabDataSet2.tOgrencis);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ogrenciid1 = Convert.ToInt32(ogrenciid.Text);
            int bolumid1 = Convert.ToInt32(bolumid.Text);
            var ogrenci = new Entity.tOgrenci();
            ogrenci.ogrenciID = ogrenciid1;
            ogrenci.bolumID = bolumid1;
            ogrenci.ad = ogrenciad.Text;
            ogrenci.soyad = ogrencisoyad.Text;
            dbcontext.tOgrenci.Add(ogrenci);
            dbcontext.SaveChanges();
            MessageBox.Show("Öğrenci Eklendi. Numarası : " + ogrenciid1 + "", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ogrenciid1 = Convert.ToInt32(ogrenciid.Text);
            int bolumid1 = Convert.ToInt32(bolumid.Text);
            var ogrencisorgu = dbcontext.tOgrenci.FirstOrDefault(x => x.ogrenciID == ogrenciid1);
            if (ogrencisorgu != null)
            {
                ogrencisorgu.ad = ogrenciad.Text;
                ogrencisorgu.soyad = ogrencisoyad.Text;
                ogrencisorgu.bolumID = bolumid1;
                MessageBox.Show("Öğrenci Bilgileri Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbcontext.SaveChanges();
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz öğrenciyi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Silmek İstiyor Musunuz?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ogrenciid.Text != null)
                {
                    int ogrenciid1 = Convert.ToInt32(ogrenciid.Text);
                    var ogrencisorgu = dbcontext.tOgrenci.FirstOrDefault(x => x.ogrenciID == ogrenciid1);
                    if (ogrencisorgu != null)
                    {
                        dbcontext.tOgrenci.Remove(ogrencisorgu);
                        MessageBox.Show("Öğrenci Kaydı Silindi", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dbcontext.SaveChanges();
                        dataGridView1.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen silmek istediğiniz öğrenciyi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void ogrenciid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char character = e.KeyChar;
            if (!Char.IsDigit(character))
            {
                e.Handled = true;
                MessageBox.Show("Sadece sayı giriniz");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
