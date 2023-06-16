using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            yenibilet.saat = comboBox1.Text.ToString();
            dbbagla.satilankoltuklar.Add(yenibilet);
            dbbagla.SaveChanges();

            Form2 form = new Form2();
            form.ShowDialog();

        }
        Context dbbagla = new Context();
        bilet yenibilet = new bilet();
        private void button1_Click(object sender, EventArgs e)
        {
            yenibilet.film = button1.Text.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yenibilet.film = button2.Text.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yenibilet.film = button3.Text.ToString();
        }
        
    }
}
