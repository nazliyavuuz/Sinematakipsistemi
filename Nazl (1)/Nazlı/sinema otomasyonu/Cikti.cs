using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_otomasyonu
{
    public partial class Cikti : Form
    {
        public Cikti()
        {
            InitializeComponent();
        }
        Context dbbagla = new Context();

        private void Cikti_Load(object sender, EventArgs e)
        {
            var za = from i in dbbagla.satilankoltuklar
                     select i;
            dataGridView1.DataSource = za.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idal = Convert.ToInt32(textBox4.Text);
            var idsorgula = dbbagla.satilankoltuklar.Find(idal);
            textBox1.Text = idsorgula.film;
            textBox3.Text = idsorgula.koltuk;
            textBox2.Text = idsorgula.saat;
        }
        PrintDialog PRD = new PrintDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument kagit = new PrintDocument();
            DialogResult yazdırmaislemi;
            yazdırmaislemi = PRD.ShowDialog();
            kagit.PrintPage += Kagit_PrintPage;
            if (yazdırmaislemi == DialogResult.OK)
            {
                kagit.Print();
            }
        }

        private void Kagit_PrintPage(object sender, PrintPageEventArgs e)
        {
            string s1, s2, s3;
            s1 = textBox1.Text;
            s2 = textBox2.Text;
            s3 = textBox3.Text;
            Font YaziAilesi = new Font("Arial", 12);
            SolidBrush Kalem = new SolidBrush(Color.Black);
            e.Graphics.DrawString("Bilgi Formu", YaziAilesi, Kalem, 350,75);
            e.Graphics.DrawString("Film Adı : " + s1, YaziAilesi, Kalem, 60, 150);
            e.Graphics.DrawString("Film Saati : "+s2, YaziAilesi, Kalem, 60, 200);
            e.Graphics.DrawString("Koltuk Numarası : "+s3, YaziAilesi, Kalem, 60, 250);
            
        }
    }
}
