using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileOperations
{
    public partial class FileOperation : Form
    {
        public FileOperation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); // Open Dialog penceresini açar.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(); // Save Dialog penceresini açar.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog(); // Folder Browser penceresini açar.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextFile textFile = new TextFile();
            textFile.Show(); // Dosya oluşturma işlemi için tasarlanan formu açma
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReadFile readFile = new ReadFile();
            readFile.Show(); // Okuma işlemi için tasarlanan formu açma
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WriteFile writeFile = new WriteFile(); 
            writeFile.Show(); // Dosyaya yazma işlemi için tasarlanan formu açma

        }
    }
}
