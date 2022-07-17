using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examGradeCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int grade1, grade2, projectGrade,donemSonuNotu;
            grade1 = Convert.ToInt16(maskedTextBox1.Text);
            grade2 = Convert.ToInt16(maskedTextBox2.Text);
            projectGrade = Convert.ToInt16(maskedTextBox3.Text);
            donemSonuNotu = (grade1 + grade2 + projectGrade) / 3;
            label5.Text = donemSonuNotu.ToString();
            if (label5.Visible == false)
            {
                label5.Visible = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox1.Focus();
            if (label5.Visible == true)
            {
                label5.Visible = false;
            }
        }
    }
}
