using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql; // Library required to use PostgreSQL

namespace Products
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432; database=DBProducts; user ID=postgres; password=Ramazan.1212");

        private void buttonList_Click(object sender, EventArgs e)
        {
            string query = "Select * from products";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("Select * from categories", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            comboBoxCategory.DisplayMember = "name";
            comboBoxCategory.ValueMember = "id";
            comboBoxCategory.DataSource = dataTable;
            connection.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("insert into products (id, name, stock, purchaseprice, saleprice, image, categoryid)" +
                "values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", connection);
            command.Parameters.AddWithValue("@p1", int.Parse(textBoxProductID.Text));
            command.Parameters.AddWithValue("@p2", textBoxProductName.Text);
            command.Parameters.AddWithValue("@p3", int.Parse(numericUpDownStock.Text));
            command.Parameters.AddWithValue("@p4", double.Parse(textBoxPurchasePrice.Text));
            command.Parameters.AddWithValue("@p5", double.Parse(textBoxSalePrice.Text));
            command.Parameters.AddWithValue("@p6", textBoxImage.Text);
            command.Parameters.AddWithValue("@p7", int.Parse(comboBoxCategory.SelectedValue.ToString()));
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ürün eklendi.","Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("Delete from products where id=@p1", connection);
            command.Parameters.AddWithValue("@p1", int.Parse(textBoxProductID.Text));
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ürün silindi.","Bilgilendirme", MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("Update products set name=@p1, stock=@p2, purchaseprice=@p3, saleprice=@p4 where id=@p5", connection);
            command.Parameters.AddWithValue("@p1", textBoxProductName.Text);
            command.Parameters.AddWithValue("@p2", int.Parse(numericUpDownStock.Text));
            command.Parameters.AddWithValue("@p3", double.Parse(textBoxPurchasePrice.Text));
            command.Parameters.AddWithValue("@p4", double.Parse(textBoxSalePrice.Text));
            command.Parameters.AddWithValue("@p5", int.Parse(textBoxProductID.Text));
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ürün başarılı bir şekilde güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("Select * from productlist", connection);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
        }
    }
}
