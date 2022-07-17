using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rectangleAreaAndPerimeterCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double perimeter, area, longSide, shortSide;
            longSide = Convert.ToDouble(uzunKenar.Text);
            shortSide = Convert.ToDouble(kısaKenar.Text);
            perimeter = shortSide * 2 + longSide * 2;
            area = shortSide * longSide;
            cevre.Text = perimeter.ToString();
            alan.Text = area.ToString();
            if (cevre.Visible==false && alan.Visible==false)
            {
                cevre.Visible = true;
                alan.Visible = true;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            uzunKenar.Clear();
            kısaKenar.Clear();
            uzunKenar.Focus();
            if (cevre.Visible== true && alan.Visible == true)
            {
                cevre.Visible = false;
                alan.Visible = false;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }
    }
}
