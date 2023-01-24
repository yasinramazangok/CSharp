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
    public partial class ReadFile : Form
    {
        public ReadFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName); 
                // Bir streamReader nesnesi ile belirtilen dosyayı okuma işlemi nesne ile ilişkilendiriyoruz.
                string line = streamReader.ReadLine(); // ReadLine() metodu ile satır satır okuma işlemi yapıyoruz.
                while (line!=null) // Satırlarda veri olduğu sürece while döngüsü çalışacaktır.
                {
                    Veriler.Items.Add(line);
                    line = streamReader.ReadLine(); // Okumayı sürdürüyoruz.
                }
            }
        }
    }
}
