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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show(); // ShowDialog() metodu kullanıldığı zaman anasayfaya dönerken Güle Güle sayfasını kapatmaz çünkü sadece açtığı sayfa üzerinde işleme izin verdiği için!
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
