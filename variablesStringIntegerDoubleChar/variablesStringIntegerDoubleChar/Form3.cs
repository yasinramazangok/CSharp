using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variablesStringIntegerDoubleChar
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1;
            sayi1 = 12;
            label1.Text = Convert.ToString(sayi1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi2, sayi3, toplam;
            sayi2 = 45;
            sayi3 = 78;
            toplam = sayi2 + sayi3;
            label2.Text = Convert.ToString(toplam);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kenar, alan, cevre;
            kenar = 9;
            // kenar= 7.5894; Kodda floating sayıları tanımlarken '.' kullanılır, klavyeden giriş istendiğinde ise ',' ile ayrılır.
            alan = kenar * kenar;
            label3.Text = Convert.ToString(alan);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int uzunKenar, kısaKenar, alan, cevre;
            uzunKenar = 20;
            kısaKenar = 15;
            alan = uzunKenar * kısaKenar;
            cevre = (2 * uzunKenar) + (2 * kısaKenar);
            label4.Text = Convert.ToString(cevre);
            label5.Text = Convert.ToString(alan);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int vizeNotu, finalNotu, odevNotu, ortalama;
            vizeNotu = 78;
            finalNotu = 43;
            odevNotu = 28;
            ortalama = (vizeNotu + finalNotu + odevNotu) / 3; // Burada int bir sonuç çıkmayacağı için toplamı
            // kendinden küçük ilk 3'e bölünebilen sayı olarak kabul edip hesaplar!
            label6.Text = Convert.ToString(ortalama);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt16(textBox1.Text);
            // label8.Text = sayi.ToString();
            label8.Text = Convert.ToString(sayi);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sayi, sayiKupu;
            sayi = Convert.ToInt16(textBox2.Text);
            sayiKupu = sayi * sayi * sayi;
            label9.Text = sayiKupu.ToString();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }
    }
}
