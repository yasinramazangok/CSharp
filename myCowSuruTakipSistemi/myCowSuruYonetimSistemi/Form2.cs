using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Net;
using System.Net.Mail;
using System.Data.Sql;
using System.Data.SqlClient;




namespace myCowSuruYonetimSistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = Form1.con;

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("Select * From registermyCow where mail='" + textBoxMail.Text.ToString().TrimEnd() + "'", con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                try
                {
                    if(con.State== ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SmtpClient smtp = new SmtpClient();
                    MailMessage mailMessage = new MailMessage();
                    string tarih = DateTime.Now.ToLongDateString();
                    string mailAdres = ("yrg6830@gmail.com");
                    string sifre =
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}