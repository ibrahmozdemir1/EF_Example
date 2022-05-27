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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Context c = new Context();
            //c.Database.Create();
            this.IsMdiContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciislem ogrenci = new ogrenciislem();
            ogrenci.Show();
        }

        private void fakulteEkle_Click(object sender, EventArgs e)
        {
            fakulteislem fakulte = new fakulteislem();
            fakulte.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bolumıslemleri bolum = new bolumıslemleri();
            bolum.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dersislem ders = new dersislem();
            ders.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            derssec derssec = new derssec();
            derssec.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            derslistele dersliste = new derslistele();
            dersliste.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            notgiris not = new notgiris();
            not.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ogretmen og = new ogretmen();
            og.Show();
        }
    }
}
