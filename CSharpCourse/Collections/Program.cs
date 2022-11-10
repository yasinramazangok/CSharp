using System;
using System.Collections; // ArrayList sınıfını içeren kütüphane
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList();

            // List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            Console.WriteLine(dictionary["table"]);
            // Console.WriteLine(dictionary["glass"]); // KeyNotFoundException hatası alınır çünkü bu key dictionary'de yoktur.
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsValue("bardak"));

            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>(); // array tabanlı bir koleksiyon olan List<>'de çalışacağımız tipi kendimiz belirleriz.
            cities.Add("Ankara");
            cities.Add("İstanbul");
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine(cities.Contains("Hatay")); // Contains() metodu girilen parametrenin ilgili koleksiyonda var olup olmadığına bakar. Var ise true; yok ise False sonucunu döndürür.

            /*
            1. Kullanım
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { id = 1, name = "Yasin Ramazan GÖK" });
            customers.Add(new Customer { id = 2, name = "Yasin Ramazan GÖK 2" });
            */

            List<Customer> customers = new List<Customer> {
            new Customer { id = 1, name = "Yasin Ramazan GÖK" },
            new Customer { id = 2, name = "Yasin Ramazan GÖK 2" }
            };

            var count = customers.Count;
            var customer2 = new Customer
            {
                id = 3,
                name = "Ali"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer{id=4,name="Mehmet"},
                new Customer{id=5,name="Hüseyin"}
            });
            // customers.Clear();

            var index = customers.IndexOf(customer2);
            var index2 = customers.LastIndexOf(customer2);
            Console.WriteLine("IndexOf() metodu sonucunda dönen değer: {0}", index);
            Console.WriteLine("LastIndexOf() metodu sonucunda dönen değer: {0}", index2);
            Console.WriteLine(customers.Contains(customer2)); // true sonucunu döndürür çünkü customer2 nesnesi ilgili koleksiyona eklenmiştir.

            customers.Insert(0, customer2); // Add() metodu sona ekleme yaparken; Insert() metodu ile istediğimiz bir index'e değer ataması yapabiliriz.

            customers.Remove(customer2); // Remove() metodu verilen parametreyi bulduğu ilk indexte siler.
            customers.RemoveAll(c => c.name == "Ali"); // RemoveAll() metodu verilen parametreyi arayıp tamamını siler.





            foreach (var customer in customers)
            {
                // Console.WriteLine(customer); // Customer'ın türünü belirtir.
                Console.WriteLine(customer.id);
                Console.WriteLine(customer.name);
            }

            Console.WriteLine("Count: {0}", count);
            // cities.Add(1); // Bu satırda hata alınır çünkü 1 int tipindedir ancak biz cities nesnesi için string veri türünde çalışacağımızı belirtiyoruz.
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            // Çalıştığımız nesnede type safe durumu yok ise yani her türden değerler alabilen bir nesne var ise ArrayList kullanılabilir. 
            // Bütün koleksiyonların temelinde array mantığı vardır. Sadece dinamik olarak arkada bizim yerimize o array'i yöneten bir mekanizma vardır.
            // Ancak genellikle bizler type safe'i tercih ederiz ve buna uygun koleksiyonlar vardır.
            cities.Add("Ankara");
            cities.Add("Adana");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            cities.Add("Hatay");
            cities.Add(20);
            cities.Add('Y');
            cities.Add(false);
            Console.WriteLine(cities[2]);
            Console.WriteLine("-------------");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
