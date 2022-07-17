using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text=="12345678901" && textBox1.Text == "123456")
            {
                Form3 frm3 = new Form3();
                frm3.Show();
                this.Hide();

            }
            else
            {
                //Application.Exit();
                //Environment.Exit(0);
                Close();
            }
        }
    }
}
