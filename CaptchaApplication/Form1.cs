using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptchaApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             İlk iki karakteri sayı, üçüncü karakteri harf, dördüncü karakteri sembol, beşinci karakteri harf,
             altıncı karakteri sayı olan captcha uygulaması
            */
            Random random = new Random();   
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] symbols = {'!','%','&','?','~','|','$','#'};
            int number1, number2, number3, number4, number5, number6;
            number1 = random.Next(0, 10);
            number2 = random.Next(0, 10);
            number3 = random.Next(0, letters.Length);
            number4 = random.Next(0, symbols.Length);
            number5 = random.Next(0, letters.Length);
            number6 = random.Next(0, 10);

            label1.Text = number1.ToString() + number2.ToString() + letters[number3].ToString() 
                          + symbols[number4].ToString() + letters[number5].ToString()+number6.ToString();


        }
    }
}
