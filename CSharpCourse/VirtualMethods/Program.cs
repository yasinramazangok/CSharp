using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    // Virtual metotlar, miras alınan sınıfın bazı metotlarının child sınıfta ihtiyaca göre override etmemize olanak sağlayan yapıdır. 
    // Interface'lerde bu şekilde dinamik bir kullanım yoktur. Bütün metotlar ve özellikler implement edilmelidir.
    class Program
    {
        static void Main(string[] args)
        {
            MySql mySql = new MySql();
            mySql.Add();
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            
            Console.ReadLine();
        }
    }
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added.");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted.");
        }
    }
    class MySql : Database
    {
        public override void Add()
        {
            Console.WriteLine("MySql added.");
            // base.Add();
        }
    }
    class SqlServer : Database
    {

    }
}
