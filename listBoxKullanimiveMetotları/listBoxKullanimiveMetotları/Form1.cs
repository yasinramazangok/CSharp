using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listBoxKullanimiveMetotları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(12);
            listBox1.Items.Add(112431235);
            listBox1.Items.Add("j3rt3o4ıjt");
            listBox1.Items.Add("Yasin Ramazan");
            listBox1.Items.Add(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
             listBox1.Items.Remove(listBox1.SelectedItem); // Seçili elemanı siler.
            // listBox1.Items.RemoveAt(2); // İndex numarası 0 dan başlamak üzere 2 numaralı elemanı siler.
            //listBox1.Items.Remove(listBox1.SelectedIndex); // Bu şekilde de kullanılabilir.
            // listBox1.Items.Clear(); // listBox taki tüm verileri temizler.
            }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = listBox1.Items.Count.ToString(); // listBox'taki elemanların sayısını label1'de gösterir.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = listBox1.Items.Contains(textBox2.Text).ToString(); // Contains() metodu aldığı parametreye göre arama yaparak boolean tipinde geri dönüş yapacaktır!
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = listBox1.Items.IndexOf(textBox3.Text).ToString(); // textBox'a girilen listBox'taki elemanın indeks değerini 1. eleman 0'dan başlamak üzere döndürür!
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }
    }
}
