using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variablesStringIntegerDoubleChar
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, sayi1, toplam, fark, carpım, bolum;
            sayi = Convert.ToInt16(textBox1.Text);
            sayi1 = Convert.ToInt16(textBox2.Text);
            toplam = sayi + sayi1;
            fark = sayi - sayi1;
            carpım = sayi * sayi1;
            bolum = sayi / sayi1;
            label7.Text = toplam.ToString();
            label8.Text = fark.ToString();
            label9.Text = carpım.ToString();
            label10.Text = bolum.ToString();

            if (label7.Visible == false && label8.Visible == false && label9.Visible == false && label10.Visible == false)
            {
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
            }


        }
        void labellarınGorunurlugu()
        {
            if (label7.Visible = false)
            {
                label7.Visible = true;
            }
            if (label8.Visible = false)
            {
                label8.Visible = true;
            }
            if (label9.Visible = false)
            {
                label9.Visible = true;

            }
            if (label10.Visible = false)
            {
                label10.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }
    }
}
