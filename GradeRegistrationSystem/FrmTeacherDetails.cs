using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace GradeRegistrationSystem
{
    public partial class FrmTeacherDetails : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=YRG\SQLEXPRESS;Initial Catalog=GradeRegistrationSystem;Integrated Security=True");

        public FrmTeacherDetails()
        {
            InitializeComponent();
        }

        private void FrmTeacherDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gradeRegistrationSystemDataSet.Lesson' table. You can move, or remove it, as needed.
            this.lessonTableAdapter.Fill(this.gradeRegistrationSystemDataSet.Lesson); // DataGridView'daki verileri sihirbaz ile gösterdiğimiz için otomatik oluşturan kod 


        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert into Lesson (Student_Number, Student_Name, Student_Surname) values (@p1, @p2, @p3)", connection);
            sqlCommand.Parameters.AddWithValue("@p1", mtbxTeacher_StudentNumber.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtTeacher_StudentName.Text);
            sqlCommand.Parameters.AddWithValue("@p3", txtTeacher_StudentSurname.Text);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Öğrenci sisteme eklendi.");
            this.lessonTableAdapter.Fill(this.gradeRegistrationSystemDataSet.Lesson); // Bu komut otomatik doldurma komutudur.
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosed = dataGridView1.SelectedCells[0].RowIndex;
            mtbxTeacher_StudentNumber.Text = dataGridView1.Rows[choosed].Cells[1].Value.ToString();
            txtTeacher_StudentName.Text = dataGridView1.Rows[choosed].Cells[2].Value.ToString();
            txtTeacher_StudentSurname.Text = dataGridView1.Rows[choosed].Cells[3].Value.ToString();
            txtTeacher_ExamFirst.Text = dataGridView1.Rows[choosed].Cells[4].Value.ToString();
            txtTeacher_ExamSecond.Text = dataGridView1.Rows[choosed].Cells[5].Value.ToString();
            txtTeacher_ExamThird.Text = dataGridView1.Rows[choosed].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double average, ex1, ex2, ex3;
            bool state;
            ex1 = Convert.ToDouble(txtTeacher_ExamFirst.Text);
            ex2 = Convert.ToDouble(txtTeacher_ExamSecond.Text);
            ex3 = Convert.ToDouble(txtTeacher_ExamThird.Text);
            average = (ex1 + ex2 + ex3) / 3;
            if (average >= 50)
            {
                state = true;
            }
            else
            {
                state = false;
            }
            lblTeacher_Average.Text = average.ToString();
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update Lesson Set Exam_First=@p1, Exam_Second=@p2, Exam_Third=@p3, Average=@p4, State=@p5 Where Student_Number=@p6", connection);
            sqlCommand.Parameters.AddWithValue("@p1", txtTeacher_ExamFirst.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtTeacher_ExamSecond.Text);
            sqlCommand.Parameters.AddWithValue("@p3", txtTeacher_ExamThird.Text);
            sqlCommand.Parameters.AddWithValue("@p4", decimal.Parse(average.ToString()));
            sqlCommand.Parameters.AddWithValue("@p5", state);
            sqlCommand.Parameters.AddWithValue("@p6", mtbxTeacher_StudentNumber.Text);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Seçilen öğrencinin notu güncellendi.");
            this.lessonTableAdapter.Fill(this.gradeRegistrationSystemDataSet.Lesson);
        }
    }
}
