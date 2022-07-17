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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin;
            metin = "Software0000";
            label1.Text = metin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string adSoyad, meslek;
            adSoyad = "Yasin Ramazan GÖK";
            meslek = "Öğrenci";
            label2.Text = adSoyad + "\n" + meslek;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Text = textBox1.Text;
            label7.Text = textBox2.Text;
            label8.Text = textBox3.Text;      
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
            // Eğer Close() metodu kullanılırsa Application.Run() metodunun parametresinde
            // Form1 tanımlı olduğu için uyulamanın kapanmasına yol açar. O yüzden Hide() metodu kullanmak mantıklıdır!

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
            this.Hide();

        }
    }
}
