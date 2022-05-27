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
using System.IO;

namespace veritabanilab
{
    public partial class notgiris : Form
    {
        Entity.Context dbcontext = new Entity.Context();
        SqlConnection bag = new SqlConnection(@"Server=DESKTOP-HU112LL; Database =veritabanilab; Trusted_Connection =True;");

        public notgiris()
        {
            InitializeComponent();
        }

        private void notgiris_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'veritabanilabDataSet4.OgrenciDers' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciDersTableAdapter.Fill(this.veritabanilabDataSet4.OgrenciDers);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ogrenciDersTableAdapter.FillBy(this.veritabanilabDataSet4.OgrenciDers);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ogrenciid1 = Convert.ToInt32(ogrenciid.Text);
            int dersid1 = Convert.ToInt32(dersid.Text);
            var derssorgu = dbcontext.ogrenciDers.Where(i => i.dersID == dersid1 && i.ogrenciID == ogrenciid1).FirstOrDefault();
            if (derssorgu != null)
            {
                derssorgu.vize = Convert.ToInt32(vize.Text);
                derssorgu.final = Convert.ToInt32(final.Text);
                MessageBox.Show("Öğrencinin Sınav Notları Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbcontext.SaveChanges();
            }
            else
            {
                MessageBox.Show("Lütfen not girmek istediğiniz öğrenciyi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ogrenciid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bul = Convert.ToInt32(dersid.Text);
            bag.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sorgu = new SqlDataAdapter("select ogrenciID,DersID,vize,final From OgrenciDers Where dersID ='" + bul + "'", bag);
            if (sorgu != null)
            {
                sorgu.Fill(dt);
                bag.Close();
                dataGridView1.DataSource = dt;
            }
        }
    }
}
