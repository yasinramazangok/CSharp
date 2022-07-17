using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!" +" "+ "My name is Yasin Ramazan GÖK" + "On the Way of Software Development!");
            MessageBox.Show("My name is Yasin Ramazan GÖK");
            MessageBox.Show("On the Way of Software Development!");
        }
        

    }
}
