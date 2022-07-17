using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace myCowSuruYonetimSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 frm2 = new Form2();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frm2.Show();
            this.Hide();
        }
        public static SqlConnection con = new SqlConnection("Data Source=YRG00;Initial Catalog=myCowSuruTakipSistemi;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand com;
        private void button1_Click(object sender, EventArgs e)
        {
            string mail = textBox1.Text;
            string password = textBox2.Text;
            
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*From registermyCow where kulAd = '" + textBox1.Text +
                "' And sifre='" + textBox2.Text + "'";

            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş başarılı");
            }
            else
            {
                MessageBox.Show("Mail ya da şifre yanlış!");
            }
            con.Close();
        }

    }
}
