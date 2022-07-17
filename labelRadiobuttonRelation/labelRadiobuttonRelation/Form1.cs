using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labelRadiobuttonRelation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = radioButton1.Checked.ToString(); // radioButton1 seçili ise true değerini değilse false değerini label1'e getirir!
            label2.Text = radioButton2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();   
            // ShowDialog ve Close kullanımı çeşitli farklılıklara yol açmaktadır. Kısa denemelerle bu farklılıklar görülebilir!
        }
    }
}
