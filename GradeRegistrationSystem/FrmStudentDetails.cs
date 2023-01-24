using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // SQL kütüphanesi

namespace GradeRegistrationSystem
{
    public partial class FrmStudentDetails : Form
    {
        public FrmStudentDetails()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=YRG\SQLEXPRESS;Initial Catalog=GradeRegistrationSystem;Integrated Security=True"); // Database bağlantısı
        public string number; // Login ekranında girilen değeri öğrenci detayları sayfasına iletmeye yarayan değişken
        
        private void FrmStudentDetails_Load(object sender, EventArgs e)
        {
            lblStudentNumber.Text = number;
            connection.Open();  
            SqlCommand command = new SqlCommand("Select * From Lesson where Student_Number = @p1", connection);
            command.Parameters.AddWithValue("@p1", number);// Komuta parametre olarak değer ekleme
            // Yani komuta p1 isimli bir parametre ekle, değerini ise number isimli değişken al!
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                lblStudentNameAndSurname.Text = sqlDataReader[2].ToString() + " " + sqlDataReader[3].ToString();
                lblExamFirst.Text = sqlDataReader[4].ToString();
                lblExamSecond.Text = sqlDataReader[5].ToString();
                lblExamThird.Text = sqlDataReader[6].ToString();
                lblAverage.Text = sqlDataReader[7].ToString();
                lblState.Text = sqlDataReader[8].ToString();

            }
        }
    }
}
