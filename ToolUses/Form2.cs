using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolUses
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BİLGİLER.Items.Add(maskedTextBox1.Text); // MaskedTextBox, verileri istediğimiz formatta kullanıcıdan almaya yarayan tool'dur.
            BİLGİLER.Items.Add(maskedTextBox2.Text);
            BİLGİLER.Items.Add(maskedTextBox3.Text);
            BİLGİLER.Items.Add(maskedTextBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BİLGİLER.Items.Add(dateTimePicker1.Text);
        }
    }
}
