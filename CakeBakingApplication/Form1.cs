using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeBakingApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 5;
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                label5.Visible = true;
                label5.BackColor = Color.LightGreen;
                timer2.Start();
            }
            if (progressBar1.Value % 20 == 10)
            {
                label1.BackColor = Color.White;
            }
            if(progressBar1.Value % 20 == 0)
            {
                label1.BackColor = Color.DarkOliveGreen;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 4;
            if (progressBar2.Value == 100)
            {
                timer2.Stop();
                label6.Visible = true;
                label6.BackColor = Color.LightGreen;
                timer3.Start();
            }
            if (progressBar2.Value % 5 == 0)
            {
                label2.BackColor = Color.White;
            }
            else
            {
                label2.BackColor = Color.DarkOliveGreen;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 5;
            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                label7.Visible = true;
                label7.BackColor = Color.LightGreen;
                timer4.Start();
            }
            if (progressBar3.Value % 20 == 10)
            {
                label3.BackColor = Color.White;
            }
            if (progressBar3.Value % 20 == 0)
            {
                label3.BackColor = Color.DarkOliveGreen;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 2;
            if (progressBar4.Value == 100)
            {
                label8.Visible = true;
                label8.BackColor = Color.LightGreen;
                timer4.Stop();
            }
            if (progressBar4.Value % 10 == 0)
            {
                label4.BackColor = Color.White;
            }
            else 
            {
                label4.BackColor = Color.DarkOliveGreen;
            }
        }
    }
}
