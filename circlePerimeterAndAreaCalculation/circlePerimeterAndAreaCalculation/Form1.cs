using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circlePerimeterAndAreaCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double PI = 3.14;
            double radius, diameter, diameterPow, circleArea, circlePerimeter;
            radius = Convert.ToDouble(textBox1.Text);
            diameter = radius * 2;
            diameterPow=  (double)Math.Pow(diameter, 2);
            circleArea = PI * diameterPow;
            circlePerimeter = 2 * PI * radius;
            label4.Text = circleArea.ToString();
            label5.Text = circlePerimeter.ToString();
            if (label4.Visible==false && label5.Visible == false)
            {
                label4.Visible = true;
                label5.Visible = true;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
            if(label4.Visible==true && label5.Visible == true)
            {
                label4.Visible = false;
                label5.Visible = false;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
