using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliceLightsWithTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start(); // timer'ı başlatır.
        }
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++; // burada counter, global'de int türünde tanımlandığı için counter int'in değer aralığına kadar gidecektir.
            label1.Text = counter.ToString();
            if (counter == 4)
            {
                counter = 0;
                pictureBox1.BackColor = Color.White;
                pictureBox2.BackColor = Color.White;
                pictureBox3.BackColor = Color.White;
            }
            else if (counter == 1)
            {
                pictureBox3.BackColor = Color.Blue;
                this.BackColor = Color.Aqua;
            }              
            else if (counter == 2)
                pictureBox1.BackColor = Color.Red;
            else if (counter == 3)
                pictureBox2.BackColor = Color.SaddleBrown;

        }
    }
}
