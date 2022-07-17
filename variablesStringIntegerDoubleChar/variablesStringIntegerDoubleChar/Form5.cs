using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variablesStringIntegerDoubleChar
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi;
            sayi = 4.25;
            label1.Text = Convert.ToString(sayi);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ortalama, sayi1, sayi2, sayi3;
            sayi1 = 80;
            sayi2 = 90;
            sayi3 = 69;
            ortalama = (sayi1 + sayi2 + sayi3) / 3;
            label2.Text = Convert.ToString(ortalama);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi4;
            sayi4 = 18.446744073;
            label3.Text = sayi4.ToString("0.00000");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            double midtermGrade, finalGrade, projectGrade, gradeAverage;
            midtermGrade = Convert.ToDouble(textBox3.Text);
            finalGrade = Convert.ToDouble(textBox4.Text);
            projectGrade = Convert.ToDouble(textBox5.Text);
            gradeAverage = (midtermGrade + finalGrade + projectGrade) / 3;

            listBox1.Items.Add("Adınız: " + textBox1.Text);
            listBox1.Items.Add("Soyadınız: " + textBox2.Text);
            listBox1.Items.Add("Dönem Sonu Ders Notunuz: " + gradeAverage);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double vergi8, vergi18, urunFiyati, kdv8, kdv18;
            urunFiyati = Convert.ToDouble(textBox6.Text);
            kdv8 = urunFiyati * 8 / 100;
            kdv18 = urunFiyati * 18 / 100;
            vergi8 = urunFiyati + kdv8;
            vergi18 = urunFiyati + kdv18;
            listBox2.Items.Add("Ürününüzün %8 KDV'li fiyatı: " + vergi8);
            listBox2.Items.Add("Ürününüzün %18 KDV'li fiyatı: " + vergi18);


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }
    }
}
