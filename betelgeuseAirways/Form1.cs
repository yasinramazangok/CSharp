using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace betelgeuseAirways
{
    public partial class Form1 : Form
    {
        public string kulAd= "Yasin1";
        public string sifre="123456";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==kulAd && textBox2.Text == sifre)
            {
                Form3 frm3 = new Form3();
                frm3.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Hatalı Giriş!");
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();

        }
    }
}
