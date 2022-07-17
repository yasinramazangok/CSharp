using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinemaBufeSatisApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int cashbox = 0;


        private void button1_Click_1(object sender, EventArgs e)
        {
        
            int su, cay, misir, bilet, toplam;
            
            cay = Convert.ToInt16(TxtCay.Text);
            misir = Convert.ToInt16(TxtMisir.Text);
            su = Convert.ToInt16(TxtSu.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);
            toplam = (cay * 3) + (bilet * 5) + (su * 3) + (misir * 4);
            
            if (TxtBilet.Text == "" || TxtCay.Text == "" || TxtMisir.Text == "" || TxtSu.Text == "")
            {
                if (TxtBilet.Text == "")
                {
                    toplam = (cay * 3) +  (su * 3) + (misir * 4);
                }
                if (TxtCay.Text == "")
                {
                    toplam = (bilet * 5) + (su * 3) + (misir * 4);
                }
                if (TxtSu.Text == "")
                {
                    toplam = (bilet * 5) + (cay * 3) + (misir * 4);
                }
                if (TxtMisir.Text == "")
                {
                    toplam = (bilet * 5) + (cay * 3) + (su * 3);
                }
            
                label14.Text = toplam.ToString();
                cashbox = cashbox + toplam;
                label16.Text = cashbox.ToString();

            }
            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TxtCay.Text = "";
            TxtBilet.Clear();
            TxtSu.Clear();
            TxtMisir.Text = "";
            TxtBilet.Focus();
            if (label14.Text != "0")
            {
                label14.Text = "0 TL";
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (label16.Text != "0")
            {
                label16.Text = "0 TL";
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            //  Close();
            //  Environment.Exit(0);
        }
    }
}
