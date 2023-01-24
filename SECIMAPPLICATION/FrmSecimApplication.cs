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
    public partial class frmSecimApplication : Form
    {
        public frmSecimApplication()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=YRG\SQLEXPRESS;Initial Catalog=SECIMAPPLICATION;Integrated Security=True");
        private void btnOyGirisiYap_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TBL_ILCE (ilceAdi, aParti, bParti, cParti, dParti, eParti) values (@P1, @P2, @P3, @P4, @P5, @P6)", connection);
            command.Parameters.AddWithValue("@P1", txtIlceAdi.Text);
            command.Parameters.AddWithValue("@P2", txtAParti.Text);
            command.Parameters.AddWithValue("@P3", txtBParti.Text);
            command.Parameters.AddWithValue("@P4", txtCParti.Text);
            command.Parameters.AddWithValue("@P5", txtDParti.Text);
            command.Parameters.AddWithValue("@P6", txtEParti.Text);
            command.ExecuteNonQuery(); // Sorguyu çalıştırır.
            connection.Close();
            MessageBox.Show("Oy Girişi Tamamlandı!");

        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            frmGrafikler frmGrafikler = new frmGrafikler();
            frmGrafikler.Show();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
