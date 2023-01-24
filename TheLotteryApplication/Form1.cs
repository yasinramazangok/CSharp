using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheLotteryApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int  number1, number2, number3, number4, number5, number6, number7;
            number1 = random.Next(1,8);
            number2 = random.Next(1, 8);
            number3 = random.Next(1, 8);
            number4 = random.Next(1, 8);
            number5 = random.Next(1, 8);
            number6 = random.Next(1, 8);
            number7 = random.Next(1, 8);
            label1.Text = number1.ToString();
            label2.Text = number2.ToString();
            label3.Text = number3.ToString();
            label4.Text = number4.ToString();
            label5.Text = number5.ToString();
            label6.Text = number6.ToString();
            label7.Text = number7.ToString();
            if(number1.ToString() == textBox1.Text)
            {
                label1.BackColor = Color.Green;
            }
            else
            {
                label1.BackColor = Color.Red;
            }
            if (number2.ToString() == textBox2.Text)
            {
                label2.BackColor = Color.Green;
            }
            else
            {
                label2.BackColor = Color.Red;
            }
            if (number3.ToString() == textBox3.Text)
            {
                label3.BackColor = Color.Green;
            }
            else
            {
                label3.BackColor = Color.Red;
            }
            if (number4.ToString() == textBox4.Text)
            {
                label4.BackColor = Color.Green;
            }
            else
            {
                label4.BackColor = Color.Red;
            }
            if (number5.ToString() == textBox5.Text)
            {
                label5.BackColor = Color.Green;
            }
            else
            {
                label5.BackColor = Color.Red;
            }
            if (number6.ToString() == textBox6.Text)
            {
                label6.BackColor = Color.Green;
            }
            else
            {
                label6.BackColor = Color.Red;
            }
            if (number7.ToString() == textBox7.Text)
            {
                label7.BackColor = Color.Green;
            }
            else
            {
                label7.BackColor = Color.Red;
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox1.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
