using System;
using System.Drawing;
using System.Windows.Forms;

namespace ContextMenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.Orange;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Yasin Ramazan GÖK'ün bir projesidir.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Hand); 
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Diagnostics, tanımlamadır. Sistemde bir process tanımlamaya yarar. görev Yöneticisi ile bağı vardır.
            System.Diagnostics.Process.Start("mspaint.exe");
        }

        private void görevYöneticisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Taskmgr.exe");
        }
    }
}
