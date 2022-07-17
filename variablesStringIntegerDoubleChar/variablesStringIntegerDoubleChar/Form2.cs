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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad, meslek, bilgiler;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            meslek = textBox3.Text;
            listBox1.Items.Add("Adınız: " + ad);
            listBox1.Items.Add("Soyadınız: " + soyad);
            listBox1.Items.Add("Yaşınız: " + maskedTextBox1.Text);
            listBox1.Items.Add("Mesleğiniz: " + meslek);
            if (radioButton1.Checked)
            {
                listBox1.Items.Add("Cinsiyetiniz: " + radioButton1.Text);
            }
            else
            {
                listBox1.Items.Add("Cinsiyetiniz: " + radioButton2.Text);
            }
            MessageBox.Show("Bilgileriniz Gösteriliyor!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }
    }
}
