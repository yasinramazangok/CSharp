using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace betelgeuseAirways
{
    public partial class Form4 : Form
    {
       
        public Form4()
        {
            InitializeComponent();
        }



        Form5 frm55 = new Form5();

        private void button2_Click(object sender, EventArgs e)
        {

            frm55.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label6.Text = radioButton1.Text;

            }
            else
            {
                label6.Text = radioButton2.Text;
            }

            frm55.listBox1.Items.Add("Uçuş Güzergahı: " + comboBox1.Text + " - " + comboBox2.Text);
            frm55.listBox1.Items.Add("Tarih: " + dateTimePicker1.Text);
            frm55.listBox1.Items.Add("Saat: " + maskedTextBox1.Text);
            frm55.listBox1.Items.Add("Bilet Şekli: " + label6.Text);
            frm55.listBox1.Items.Add("Adı: " + textBox1.Text);
            frm55.listBox1.Items.Add("Soyadı: " + textBox2.Text);
            frm55.listBox1.Items.Add("TC Kimlik Numarası: " + maskedTextBox2.Text);
            frm55.listBox1.Items.Add("Telefon Numarası: " + maskedTextBox3.Text);
            MessageBox.Show("Rezervasyonunuz Tamamlandı! İyi Yolculuklar Dileriz!");



        }
        
    }
}
