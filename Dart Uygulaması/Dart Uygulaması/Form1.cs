using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dart_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rast = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3, toplam;
            sayi1 = rast.Next(0, 11);
            sayi2 = rast.Next(0, 11);
            sayi3 = rast.Next(0, 11);
            toplam = sayi1 + sayi2 + sayi3;
            textBox1.Text = sayi1.ToString();
            textBox2.Text = sayi2.ToString();
            textBox3.Text = sayi3.ToString();
            textBox4.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double derece;
            derece = Convert.ToDouble(textBox4.Text);
            if (derece >= 20)
            {
                MessageBox.Show("Mükemmel");
            }
            else if (derece >= 15)
            {
                MessageBox.Show("İyi");
            }
            else if (derece >= 10)
            {
                MessageBox.Show("Normal");
            }
            else if (derece < 10) 
            {
                MessageBox.Show("Kötü");
            }
            
        }
    }
}
