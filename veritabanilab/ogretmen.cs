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
    public partial class ogretmen : Form
    {
        Entity.Context dbcontext = new Entity.Context();
        public ogretmen()
        {
            InitializeComponent();
        }

        private void ogretmen_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'veritabanilabDataSet7.Ogretmen' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogretmenTableAdapter1.Fill(this.veritabanilabDataSet7.Ogretmen);
            // TODO: Bu kod satırı 'veritabanilabDataSet5.Ogretmen' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogretmenTableAdapter.Fill(this.veritabanilabDataSet5.Ogretmen);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ogretid = Convert.ToInt32(ogretmenid.Text);
            var ogretmen = new Entity.Ogretmen();
            ogretmen.ogrtID = ogretid;
            ogretmen.ogrtAd = ogretmenad.Text;
            ogretmen.ogrtsoyad = ogretmensoyad.Text;
            dbcontext.tOgretmens.Add(ogretmen);
            dbcontext.SaveChanges();
            MessageBox.Show("Öğretmen Eklendi. Numarası : " + ogretid + "", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.Refresh();


        }
    }
}
