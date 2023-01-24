using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeRegistrationSystem
{
    public partial class FrmUserLogin : Form
    {
        public FrmUserLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmStudentDetails frmStudentDetails = new FrmStudentDetails();
            frmStudentDetails.number = mtbxStudentNumber.Text; // Login ekranında girilen numarayı number değişkenine atama
            frmStudentDetails.Show();
            this.Hide();
        }
        private void mtbxStudentNumber_TextChanged(object sender, EventArgs e)
        {
            // TextChanged özelliği ile mtbx'in Text'ini sürekli okur ve ilgili değere eşit olduğunu direkt if bloğu çalışır.
            if (mtbxStudentNumber.Text == "1111")
            {
                FrmTeacherDetails frmTeacherDetails = new FrmTeacherDetails();
                frmTeacherDetails.Show();
                this.Hide();
            }
        }
    }
}
