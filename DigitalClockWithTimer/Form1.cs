using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClockWithTimer
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
        int second = 0, minute = 0, hour = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            label3.Text = second.ToString();
            if (second == 59)
            {
                minute++;
                label2.Text = minute.ToString();
                second = 0;
                if (minute == 59)
                {
                    hour++;
                    label1.Text = hour.ToString();
                    minute = 0;

                }
            }
        }
    }
}
