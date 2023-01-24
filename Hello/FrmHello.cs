using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tools
{
    public partial class FrmHello : Form
    {
        public FrmHello()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("On the way of software development!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Yasin Ramazan GÖK";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Öğrenci";
            label7.Text = 24.ToString();
            label8.Text = "Turuncu";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Software wants to know you!";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label9.Text = textBox2.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label10.Text = textBox3.Text;
            label11.Text = textBox4.Text;
            label12.Text = textBox5.Text;
        }
    }
}
