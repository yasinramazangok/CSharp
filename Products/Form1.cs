using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432; database=DBProducts; user ID=postgres; password=Ramazan.1212");
        private void buttonList_Click(object sender, EventArgs e)
        {
            string query = "Select * from categories";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("insert into categories (id, name) values (@p1, @p2)", connection);
            command.Parameters.AddWithValue("@p1", int.Parse(textBoxCategoryID.Text));
            command.Parameters.AddWithValue("@p2", textBoxCategoryName.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kategori eklendi.");
        }
    }
}
