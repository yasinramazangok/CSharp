using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb; initial catalog=ETrade;integrated security=true");
        // @ işareti içeride yazılan her şeyi string olarak kabul et demektir.
        // initial catalog, bağlanacağımız veritabanını refere eder.
        // integrated security, Windows Authentication ile bağlanmayı aktifleştirir. 
        // Burada bir bağlantı nesnesi oluşturduk ancak bağlantıyı henüz açmadık.

        /*
        public DataTable GetAll()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb; initial catalog=ETrade;integrated security=true");
            // @ işareti içeride yazılan her şeyi string olarak kabul et demektir.
            // initial catalog, bağlanacağımız veritabanını refere eder.
            // integrated security, Windows Authentication ile bağlanmayı aktifleştirir. 
            // Burada bir bağlantı nesnesi oluşturduk ancak bağlantıyı henüz açmadık.
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open(); // Bağlantıyı açıyoruz.
            }

            SqlCommand command = new SqlCommand("Select * from Products", connection); // SQL sorgu komutunu oluşturduk ancak çalıştırmadık.
            SqlDataReader reader = command.ExecuteReader(); // Tablo sonucu istediğimiz için bu metodu kullandık. Farklı işlemlerde sorgu komutu farklı metotlarla çalıştırılır.
            DataTable dataTable = new DataTable(); // Data table oluşturduk. 
            // GÜNÜMÜZDE DATATABLE NADİR KULLANILMAKTADIR VE KULLANILMASI ÖNERİLMEMEKTEDİR.*****
            dataTable.Load(reader); // Data table'ı reader'ın içeriği ile doldurduk.
            reader.Close();
            connection.Close();
            return dataTable;
        }
        */


        public List<Product> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from Products", _connection); // SQL sorgu komutunu oluşturduk ancak çalıştırmadık.

            SqlDataReader reader = command.ExecuteReader(); // Tablo sonucu istediğimiz için bu metodu kullandık. Farklı işlemlerde sorgu komutu farklı metotlarla çalıştırılır.

            List<Product> products = new List<Product>();

            while (reader.Read()) // reader'daki kayıtları tek tek oku, okuyabildiği sürece while döngüsü çalışacak.
            {
                Product product = new Product
                {
                    id = Convert.ToInt32(reader["ID"]),
                    name = Convert.ToString(reader["Name"]),
                    unitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    stockAmount = Convert.ToInt32(reader["StockAmount"])
                };
                products.Add(product);
            }

            reader.Close();
            _connection.Close();
            return products;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open(); // Bağlantıyı açıyoruz.
            }
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Products values(@name,@unitPrice,@stockAmount)", _connection);
            command.Parameters.AddWithValue("@name", product.name);
            command.Parameters.AddWithValue("@unitPrice", product.unitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.stockAmount);
            command.ExecuteNonQuery(); // Bu metot etkilenen kayıt sayısını int türünden döndürür.
            _connection.Close();
        }
        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("update Products set  name = @name, unitPrice = @unitPrice, stockAmount = @stockAmount where id=@id", _connection);
            command.Parameters.AddWithValue("@name", product.name);
            command.Parameters.AddWithValue("@unitPrice", product.unitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.stockAmount);
            command.Parameters.AddWithValue("@id", product.id);
            command.ExecuteNonQuery(); // Bu metot etkilenen kayıt sayısını int türünden döndürür.
            _connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("delete from Products where id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery(); // Bu metot etkilenen kayıt sayısını int türünden döndürür.
            _connection.Close();
        }
    }
}
