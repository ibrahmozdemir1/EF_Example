using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using veritabanilab.Entity;

namespace veritabanilab
{
    public partial class bolumıslemleri : Form
    {
        Entity.Context dbcontext = new Entity.Context();
        public bolumıslemleri()
        {
            InitializeComponent();
        }

        private void bolumıslemleri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'veritabanilabDataSet1.tBolums' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBolumsTableAdapter.Fill(this.veritabanilabDataSet1.tBolums);
            // TODO: Bu kod satırı 'veritabanilabDataSet.tFakultes' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tFakultesTableAdapter.Fill(this.veritabanilabDataSet.tFakultes);

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bolumid1 = Convert.ToInt32(bolumid.Text);
            int fakulteid1 = Convert.ToInt32(fakulteid.Text);
            var bolum = new Entity.tBolum();
            bolum.bolumID = bolumid1;
            bolum.bolumAd = bolumad.Text;
            bolum.fakulteID = fakulteid1;
            dbcontext.tBolum.Add(bolum);
            dbcontext.SaveChanges();
            dataGridView1.Refresh();
            MessageBox.Show("Bölüm Eklendi. Numarası : " + bolumid1 + "", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bolumid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char character = e.KeyChar;
            if (!Char.IsDigit(character))
            {
                e.Handled = true;
                MessageBox.Show("Sadece sayı giriniz");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bolumnum = Convert.ToInt32(bolumid.Text);
            int fakultenum = Convert.ToInt32(fakulteid.Text);
            var bolumsorgu = dbcontext.tBolum.FirstOrDefault(x => x.bolumID == bolumnum);
            if (bolumsorgu != null)
            {
                bolumsorgu.bolumAd = bolumad.Text;
                bolumsorgu.fakulteID = fakultenum;
                MessageBox.Show(" Bölüm Bilgileri Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbcontext.SaveChanges();
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz bölümü giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(this, "Silmek İstiyor Musunuz?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               if(bolumid.Text != null)
               {
                    int bolumid1 = Convert.ToInt32(bolumid.Text);
                    var bolumsorgu = dbcontext.tBolum.FirstOrDefault(x => x.bolumID == bolumid1);
                    if (bolumsorgu != null)
                    {
                        dbcontext.tBolum.Remove(bolumsorgu);
                        MessageBox.Show("Bölüm Silindi", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dbcontext.SaveChanges();
                        dataGridView1.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen silmek istediğiniz bölümü seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void fakulteid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
