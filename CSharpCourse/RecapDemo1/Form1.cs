using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Constructor metot burasıdır.
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Button button = new Button();
            //button.Width = 50;
            //button.Height = 50;
            //button.Text = "My Button";
            //this.Controls.Add(button); // button nesnesini ekrana koyma

            GenerateButton();
        }

        private void GenerateButton()
        {
            Button[,] buttons = new Button[8, 8]; // 8*8'lik bir button array'i tanımladık.
            int top = 0;
            int left = 0;
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;
                    this.Controls.Add(buttons[i, j]); // Buradaki 'this' anahtar sözcüğü form'a karşılık gelir. Yani formun kendisidir.
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                }
                top += 50;
                left = 0;
            }
        }
    }
}
