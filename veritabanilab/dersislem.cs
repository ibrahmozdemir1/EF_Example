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
    public partial class dersislem : Form
    {
        Entity.Context dbcontext = new Entity.Context();
        public dersislem()
        {
            InitializeComponent();
        }

        private void dersislem_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'veritabanilabDataSet6.tDers' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tDersTableAdapter1.Fill(this.veritabanilabDataSet6.tDers);
            // TODO: Bu kod satırı 'veritabanilabDataSet5.Ogretmen' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogretmenTableAdapter.Fill(this.veritabanilabDataSet5.Ogretmen);
            // TODO: Bu kod satırı 'veritabanilabDataSet1.tBolums' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBolumsTableAdapter.Fill(this.veritabanilabDataSet1.tBolums);
            // TODO: Bu kod satırı 'veritabanilabDataSet3.tDers' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tDersTableAdapter.Fill(this.veritabanilabDataSet3.tDers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dersid1 = Convert.ToInt32(dersID.Text);
            int bolumid1 = Convert.ToInt32(bolumId.Text);
            int ogretid = Convert.ToInt32(comboBox1.Text);
            var ders = new Entity.tDers();
            ders.dersID = dersid1;
            ders.bolumID = bolumid1;
            ders.dersAd = dersad.Text;
            ders.ogrtID = ogretid;
            dbcontext.tDers.Add(ders);
            dbcontext.SaveChanges();
            MessageBox.Show("Ders Eklendi. Numarası : " + dersid1 + "", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dersid1 = Convert.ToInt32(dersID.Text);
            int bolumid1 = Convert.ToInt32(bolumId.Text);
            int ogretid = Convert.ToInt32(comboBox1.Text);
            var derssorgu = dbcontext.tDers.FirstOrDefault(x => x.dersID == dersid1);
            if (derssorgu != null)
            {
                derssorgu.dersAd = dersad.Text;
                derssorgu.bolumID = bolumid1;
                derssorgu.ogrtID = ogretid;
                MessageBox.Show("Ders Bilgileri Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbcontext.SaveChanges();
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz dersi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Silmek İstiyor Musunuz?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dersID.Text != null)
                {
                    int dersid1 = Convert.ToInt32(dersID.Text);
                    var derssorgu = dbcontext.tDers.FirstOrDefault(x => x.dersID == dersid1);
                    if (derssorgu != null)
                    {
                        dbcontext.tDers.Remove(derssorgu);
                        MessageBox.Show("Dersin Kaydı Silindi", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dbcontext.SaveChanges();
                        dataGridView1.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen silmek istediğiniz dersi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bolumId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
