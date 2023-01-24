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
    public partial class WriteFile : Form
    {
        public WriteFile()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin Belgesi|*.txt"; // SaveFileDialog penceresinde yalnızca txt uzantılı dosyaları görüntülemek için filtreleme kullanıyoruz.
            saveFileDialog1.Title = "Dosyaya Yazma İşlemi"; // Save File Dialog penceresinin üst kısmında başlık ayarlıyoruz.
            saveFileDialog1.ShowDialog();
            StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);
            streamWriter.WriteLine(richTextBox1.Text);
            streamWriter.Close();
            MessageBox.Show("Dosya Kaydedildi");

        }
    }
}
