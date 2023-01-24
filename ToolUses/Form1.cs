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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // combobox'ta metin yazdırmak için text özelliği kullanılabilir ancak açılır pencere kutularında text 
            // özelliği pek tercih edilmez ve add özelliği kullanılır.
            // comboBox1.Text = "Ramazan";
            //comboBox1.Items.Add("Buffon");
            //comboBox1.Items.Add("Beckham");
            //comboBox1.Items.Add("Lampard");
            comboBox1.Items.Add(textBox1.Text);
            Efsaneler.Items.Add(textBox1.Text);
            //textBox1.Text = default;
            textBox1.Text = null; // default veya null ile tekrardan textbox'ın text'ini boş hale getiriyoruz.

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            
        }
    }
}
