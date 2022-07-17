using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mtbPbDtpKullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(maskedTextBox1.Text);
            comboBox1.Items.Add(maskedTextBox1.Text);
            listBox1.Items.Add(maskedTextBox2.Text);
            comboBox1.Items.Add(maskedTextBox2.Text);
            listBox1.Items.Add(maskedTextBox3.Text);
            comboBox1.Items.Add(maskedTextBox3.Text);
            listBox1.Items.Add(maskedTextBox4.Text);
            comboBox1.Items.Add(maskedTextBox4.Text);
            listBox1.Items.Add(maskedTextBox5.Text);
            comboBox1.Items.Add(maskedTextBox5.Text);
            listBox1.Items.Add(maskedTextBox6.Text);
            comboBox1.Items.Add(maskedTextBox6.Text);
            listBox1.Items.Add(maskedTextBox7.Text);
            comboBox1.Items.Add(maskedTextBox7.Text);
            listBox1.Items.Add(maskedTextBox8.Text);
            comboBox1.Items.Add(maskedTextBox8.Text);
            listBox1.Items.Add(maskedTextBox9.Text);
            comboBox1.Items.Add(maskedTextBox9.Text);
            listBox1.Items.Add(maskedTextBox10.Text);
            comboBox1.Items.Add(maskedTextBox10.Text);
            listBox1.Items.Add(dateTimePicker1.Text);
            comboBox1.Items.Add(dateTimePicker1.Text);

        }
    }
}
