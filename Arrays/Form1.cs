using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        string[] persons = { "Yasin", "Ramazan", "Büşra", "Mehmet", "Hasan", "Ali", "Burak", "Ceyda" };
        char[] characters = { 'a', 'g', 't', 'r', 'q', 'k', 'z', 'o' };
        double[] floatingPoints = { 10.34, 40.67, 89.11, 23.31, 65.98, 19.27 };
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = numbers[3].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = persons[5];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = characters[2].ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = floatingPoints[2].ToString(); // Arayüzde , ile görüntülenecektir.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < persons.Length; i++)
            {
                Veriler.Items.Add(persons[i]);
            }
        }
    }
}
