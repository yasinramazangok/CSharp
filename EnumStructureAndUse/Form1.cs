using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumStructureAndUse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum cities {
            nullValue, Adana, Adıyaman, Afyon, Ağrı, Amasya, Ankara, Antalya,Artvin, Aydın
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // enum yapısı Zero Based Indexing mantığı ile çalışır. 
            int plaqueCode = Convert.ToInt16(textBox1.Text);
            cities c;
            c = (cities)plaqueCode;
            label2.Text = c.ToString();

        }
    }
}
