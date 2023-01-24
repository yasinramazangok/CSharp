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

namespace SECIMAPPLICATION
{
    public partial class frmGrafikler : Form
    {
        public frmGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=YRG\SQLEXPRESS;Initial Catalog=SECIMAPPLICATION;Integrated Security=True");
        private void frmGrafikler_Load(object sender, EventArgs e)
        {
            // İlçe Adlarını Combobox'ta Gösterme
            connection.Open();
            SqlCommand command = new SqlCommand("select ilceAdi from TBL_ILCE", connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())                
            {
                comboBox1.Items.Add(dataReader[0]);
            }
            connection.Close();

            /*
            // Grafiğe Toplam Sonuçları Getirme
            connection.Open();
            SqlCommand command1 = new SqlCommand("select SUM(aParti),,SUM(bParti), SUM(cParti), SUM(dParti), SUM(eParti) from TBL_ILCE", connection);
            // SUM(), parametre olarak girilen kolondaki bütün değerlerin toplamını döndürür.
            SqlDataReader dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A PARTİSİ", dataReader1[0]);
                chart1.Series["Partiler"].Points.AddXY("B PARTİSİ", dataReader1[1]);
                chart1.Series["Partiler"].Points.AddXY("C PARTİSİ", dataReader1[2]);
                chart1.Series["Partiler"].Points.AddXY("D PARTİSİ", dataReader1[3]);
                chart1.Series["Partiler"].Points.AddXY("E PARTİSİ", dataReader1[4]);
            }
            connection.Close();
            */

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select * from TBL_ILCE where ilceAdi=@P1", connection);
            command.Parameters.AddWithValue("@P1", comboBox1.Text);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                progressBar1.Value = int.Parse(dataReader[2].ToString());
                progressBar2.Value = int.Parse(dataReader[3].ToString());
                progressBar3.Value = int.Parse(dataReader[4].ToString());
                progressBar4.Value = int.Parse(dataReader[5].ToString());
                progressBar5.Value = int.Parse(dataReader[6].ToString());

                lblA.Text = dataReader[2].ToString();
                lblB.Text = dataReader[3].ToString();
                lblC.Text = dataReader[4].ToString();
                lblD.Text = dataReader[5].ToString();
                lblE.Text = dataReader[6].ToString();
            }
            connection.Close();
        }
    }
}
