using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(); // Bir class'ı kullanabilmek için onu new'lemek yani bir örneğini oluşturmak gereklidir.
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.id = 1;
            customer.name = "Yasin Ramazan"; // Örneğin bir sınıfın property'sine '=' yapılarak değer verildiğinde property'nin set bloğu çalışır.
            customer.surname = "GÖK";
            customer.city = "Hatay";

            Customer customer1 = new Customer
            {
                id = 2,
                name = "Mehmet",
                surname = "YILDIZ",
                city = "Hassa"
            };

            Console.WriteLine(customer1.name); // Bir sınıfın propertisine erişirken ise get bloğu çalışır.

            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        // Sınıf isimleri PascalCase ile isimlendirilir.
        public void Add()
        {
            Console.WriteLine("Customer added!");
        }
        public void Update()
        {
            Console.WriteLine("Customer updated!");
        }
    }
}
