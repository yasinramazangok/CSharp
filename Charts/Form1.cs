using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["Büyük Şehirler"].Points.AddXY("Akdeniz", 4);
            chart1.Series["Büyük Şehirler"].Points.AddXY("Marmara", 6);
            chart1.Series["Büyük Şehirler"].Points.AddXY("Karadeniz", 3);
            chart1.Series["Büyük Şehirler"].Points.AddXY("Ege", 5);
        }
    }
}
