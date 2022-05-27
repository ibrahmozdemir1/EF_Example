using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.Sql;


namespace veritabanilab
{
    public partial class fakulteislem : Form
    {
        Entity.Context dbcontext = new Entity.Context();
        public fakulteislem()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
        {
        
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            int fakulteid1 = Convert.ToInt32(fakulteid.Text);
            var fakulte = new Entity.tFakulte();
            fakulte.fakulteID = fakulteid1;
            fakulte.fakulteAd = fakultead.Text;
            dbcontext.tFakulte.Add(fakulte);
            dbcontext.SaveChanges();
            MessageBox.Show("Fakülte Eklendi. Numarası : " + fakulte.fakulteID + "", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void fakulteid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char character = e.KeyChar;
            if (!Char.IsDigit(character))
            {
                e.Handled = true;
                MessageBox.Show("Sadece sayı giriniz");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fakulteid_TextChanged(object sender, EventArgs e)
        {

        }

        private void fakulteislem_Load(object sender, EventArgs e)
        {

        }
    }
}
