using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileOperations
{
    public partial class TextFile : Form
    {
        public TextFile()
        {
            InitializeComponent();
        }

        string fileName, filePath;
        StreamWriter streamWriter; // bir dosyaya yazma işlemi gerekli olan sınıftır.

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) // Folder Browser penceresinde bir dosya seçilip ok butonuna tıklanırsa
            {
                filePath = folderBrowserDialog1.SelectedPath.ToString(); // Seçilen dosya yolunu filePath değişkenine atama işlemi
                textBox1.Text = filePath;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            fileName = textBox2.Text; // Dosya adını textbox'tan alma
            streamWriter = File.CreateText(filePath + "\\" + fileName + ".txt"); // Belirtilen dosya yoluna bir adet text dosyası oluşturma
            streamWriter.Close(); // Yazma işlemini kapatma
            MessageBox.Show("Dosya belirtilen klasörde oluşturuldu!","Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }



    }
}
