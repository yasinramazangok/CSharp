using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int number, number1, number2;
            number = random.Next(1,20); // Next() metodu aralık belirleyen bir komuttur. İlk değer dahil, ikinci değer dahil değildir.
            number1 = random.Next(1, 20);
            number2 = random.Next(1, 20);
            label1.Text = number.ToString();
            label2.Text = number1.ToString();
            label3.Text = number2.ToString();
        }
    }
}
