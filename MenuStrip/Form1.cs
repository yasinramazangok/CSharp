using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Yasin Ramazan GÖK'ün bir projesidir.", "Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void shooterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // weBrowser öğesi, uygulamada tarayıcı gibi çalışır ve Navigate() metodu ile verilen bağlantıyı açar.
            webBrowser1.Navigate("https://www.youtube.com/watch?v=6ZVcPhDt-kM");
            label1.Text = "Shooter";
        }

        private void gIJoeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=uQewEuHlsbU");
            label1.Text = "G.I Joe";
        }

        private void esaretinBedeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=7BG-BpvkYB8");
            label1.Text = "Esaretin Bedeli";
        }

        private void marslıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=zb3dm_72j6I");
            label1.Text = "Marslı";
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
