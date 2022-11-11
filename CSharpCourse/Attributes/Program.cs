using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    // Attribute'lar ile merkezi bir noktada iş kurallarını tanımlarız.
    // Attribute'lar hem nesnelere hem de metotlara tanımlanabilir.
    // Attribute'lara parametre de gönderilebilir. Bu da constructor ile set edilir.
    // if ile kontrol edilebilir ancak büyük boyutlu projelerde merkezi bir noktadan attribute'lar ile kontrol etmek daha performanslı ve kullanışlıdır.
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, FirstName = "Yasin Ramazan", LastName = "GÖK", Age = 24 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);

            Console.ReadLine();
        }
    }

    [ToTable("Customers")]
    [ToTable("TBL_CUSTOMERS")]
    class Customer
    {
        [RequiredProperty]
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("Don't use Add(), instead use AddNew() method!")]
        // Obsolete hazır bir attribute'dır.
        public void Add(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} eklendi.", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

        public void AddBNew(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} eklendi.", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    //[AttributeUsage(AttributeTargets.All)]
    [AttributeUsage(AttributeTargets.Property)] // RequiredProperty attribute'ı sadece class'ların üzerine eklenebilir.
    // AttributeUsage ile bir attribute'ı nerelerde kullanabileceğimizin konfigürasyonunu yapabiliyoruz. 
    class RequiredPropertyAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
