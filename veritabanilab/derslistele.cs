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
using veritabanilab.Entity;

namespace veritabanilab
{
    public partial class derslistele : Form
    {
        Entity.Context dbcontext = new Entity.Context();
        SqlConnection bag = new SqlConnection(@"Server=DESKTOP-HU112LL; Database =veritabanilab; Trusted_Connection =True;");
        SqlCommand komut;
        public derslistele()
        {
            InitializeComponent();
            tarihsec.Format = DateTimePickerFormat.Custom;
            tarihsec.CustomFormat = "yyyy";
            tarihsec.ShowUpDown = true;
        }

        private void derslistele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'veritabanilabDataSet4.OgrenciDers' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciDersTableAdapter.Fill(this.veritabanilabDataSet4.OgrenciDers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bul = Convert.ToInt32(ogrencibul.Text);
            bag.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sorgu = new SqlDataAdapter("select ogrenciID,DersID,yil,yariyil From OgrenciDers Where ogrenciID ='" + bul + "'", bag);
            if (sorgu != null)
            {
                sorgu.Fill(dt);
                bag.Close();
                dersgosterim.DataSource = dt;
            }
        }

        private void ogrencibul_TextChanged(object sender, EventArgs e)
        {
        }

        private void dersgosterim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            bag.Open();
            string kayit = "SELECT dersID,COUNT(ogrenciID) AS ToplamOgrenciSayisi FROM OgrenciDers WHERE yariyil = @yariyil AND yil = @yil GROUP BY dersID";
            //musteriler tablosundaki tüm alanları isim parametresi
            SqlCommand komut = new SqlCommand(kayit, bag);
            komut.Parameters.AddWithValue("@yariyil", yariyil.Text);
            komut.Parameters.AddWithValue("@yil", tarihsec.Text);
            //isim parametremize textbox'dan girilen değeri aktarıyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dersgosterim.DataSource = dt;
            bag.Close();
        }

        private void tarih_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
