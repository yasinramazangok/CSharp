using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point point = new Point();
            int x = 125;
            int y = 110;
            point.X = x; 
            point.Y = y;
            label1.Location = point; // label1'i yeni konumuna taşıma
        }
    }
}
