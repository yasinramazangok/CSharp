using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rgbCryptoAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // button1 ile şifrelediğimiz metni şifreleme algoritmasının tam tersi çözüyoruz.
            char[] alfabe = { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'q', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'w', 'x', 'y', 'z' };
            char[] sifresiCozulecekMetin = label1.Text.ToCharArray();
            char[] originalMetin = new char[sifresiCozulecekMetin.Length];
            
            Array.Reverse(sifresiCozulecekMetin);

            for (int i = 0; i < sifresiCozulecekMetin.Length; i++)
            {
                
                for (int j = 0; j < alfabe.Length; j++)
                {
                    
                    if (sifresiCozulecekMetin[i] == alfabe[j])
                    {
                        if (sifresiCozulecekMetin[i] == 'a')
                        {
                            originalMetin[i] = alfabe[alfabe.Length-1];
                            break;
                        }
                        originalMetin[i] = alfabe[j - 1];
                    }
                }
            }
            label2.Text = "";
            for (int i = 0; i < originalMetin.Length; i++)
            {
                label2.Text += originalMetin[i];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] alfabe = { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'q', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'w', 'x', 'y', 'z' };
            // Alfabeyi tanımlıyoruz.
            char[] girilenMetinKarakterleri = textBox1.Text.ToCharArray(); // Girilen metni karakterlere bölüp bir karakter dizisine atıyoruz.
            char[] sifreliMetin = new char[girilenMetinKarakterleri.Length]; // Şifrelenecek metin için girilen metin uzunluğunda bir dizi tanımlıyoruz.

            for (int i = 0; i < girilenMetinKarakterleri.Length; i++)
            { // Birinci for döngüsü girilen metinin bütün karakterlerinde gezinmemizi sağlıyor.
                for (int j = 0; j < alfabe.Length; j++)
                { // İkinci for döngüsü ile girilen her karakteri alfabe ile karşılaştırıyoruz.
                    if (girilenMetinKarakterleri[i] == alfabe[j])
                    {
                        if (girilenMetinKarakterleri[i] == 'z')
                        { // İstisna durumu ele alıyoruz.
                            sifreliMetin[i] = alfabe[0]; 
                        }
                        else 
                        {
                            sifreliMetin[i] = alfabe[j + 1]; // Girilen metindeki her bir karakterin alfabede kendisinden sonra gelen harfe ataması yapılıyor.
                        }                       
                    }                   
                }
            }
            Array.Reverse(sifreliMetin); // Şifreli metni ters çeviriyoruz.
            label1.Text = "";
            for (int i = 0; i < sifreliMetin.Length; i++)
            {
                label1.Text += sifreliMetin[i]; // Ters çevrilen metni ekrana yazdırıyoruz. 
            }
        }
    }
}
