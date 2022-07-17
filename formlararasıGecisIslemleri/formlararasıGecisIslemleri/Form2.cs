using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formlararasıGecisIslemleri
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide(); // this.Close() metodu kullanılsaydı uygulamayı kapattığın için uygun olmazdı ancak Hide() metodu uygulamayı kaptmayıp sadece sayfyaı gizledi,ği için kullanılması mantıklıdır!
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            Hide(); // this anahtar sözcüğü olamdan da Hide() metodu kullanılabilir!
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Application.Exit();
            Environment.Exit(0); // Exit() metodu int türünde bir parametre almak zorundadır!
            //Close();
        }
    }
}
