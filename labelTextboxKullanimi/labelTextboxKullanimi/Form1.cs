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

namespace labelTextboxKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "On the Way of Software Development!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "Yasin Ramazan";
            label7.Text = "GÖK";
            label8.Text = "Software Developer";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label9.Text = textBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            label10.Text = textBox2.Text;
            label12.Text = textBox3.Text;
            label11.Text = textBox4.Text;








        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox5.Text);
        }
    }
}
