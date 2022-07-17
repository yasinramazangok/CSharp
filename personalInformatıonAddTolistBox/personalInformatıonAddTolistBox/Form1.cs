using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personalInformatıonAddTolistBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bilgiler.Items.Add(textBox1.Text);
            Bilgiler.Items.Add(textBox2.Text);
            Bilgiler.Items.Add(maskedTextBox1.Text);
            Bilgiler.Items.Add(maskedTextBox2.Text);
            Bilgiler.Items.Add(comboBox1.Text);
            Bilgiler.Items.Add(dateTimePicker1.Text);
            MessageBox.Show(textBox1.Text+textBox2.Text);
        }
    }
}
