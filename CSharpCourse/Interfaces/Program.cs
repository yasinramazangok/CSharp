using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    // Bir interface veya 'abstract type' new'lenemez yani bir instance'ı oluşturulamaz. Fakat onu implemente eden nesnelerin instance'ı oluşturulabilir.
    internal class Program
    {
        static void Main(string[] args)
        {
            // InterfacesIntro();
            // IPerson person = new IPerson(); // Bu kod hata verecektir çünkü interface'ler new'lemez.
            // PolymorphismExample();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
                // İlerleyen zamanlarda buraya yeni bir veritabanı rahatlıkla eklenebilir. Bu bağımsızlığın azaltılmasıdır.
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add(); // Bu şekilde bir şirketteki veritabanındaki data'ları bütün veri tabanlarına atmış oluyoruz.
            }
            Console.ReadLine();
        }

        private static void PolymorphismExample()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal()); // Interface'ler gerçek hayatta bu şekilde katmanlar arası geçişlerde yoğunlukla kullanılır. Amaç, bağımlılığı azaltmaktır.
        }

        private static void InterfacesIntro()
        {
            // 1. kullanım şekli
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { id = 1, name = "1. Kullanım Şekli:Yasin Ramazan", surname = "GÖK", address = "Hatay" });

            // 2. kullanım şekli
            Customer customer = new Customer
            {
                id = 2,
                name = "2. Kullanım Şekli:YasinRamazan",
                surname = "GÖK",
                address = "Hassa"
            };
            personManager.Add(customer);

            /*
            Student student = new Student
            {
                id = 2,
                name = "girilen Parametrenin Geçersizliği:YasinRamazan",
                surname = "GÖK",
                department = "Software Engineering"
            };
            personManager.Add(student); // Bu şekilde verilemez çünkü PersonManager sınıfında Customer nesnesinden bir parametre veriliyor.
            */

            PersonManager1 personManager1 = new PersonManager1();
            Student student1 = new Student
            {
                id = 2,
                name = "Student İçin Aynı Türden Parametrenin Hata Vermemesi:YasinRamazan",
                surname = "GÖK",
                department = "Software Engineering"
            };
            personManager1.Add(student1); // Burada izin vermesinin sebebi IPerson türünden bir nesneyi parametre olarak Add() metoduna göndermemiş olmamızdır.

            Customer customer1 = new Customer
            {
                id = 2,
                name = "Customer İçin Aynı Türden Parametrenin Hata Vermemesi:YasinRamazan",
                surname = "GÖK",
                address = "Hassa/Aktepe"
            };
            personManager1.Add(customer1); // Hata vermez çünkü IPerson türünde bir nesneyi parametre olarak verdik.           
        }
    }
    interface IPerson
    {
        // Soyut nesne
        int id { get; set; }
        string name { get; set; }
        string surname { get; set; }
    }
    class Customer : IPerson
    {
        // Somut nesne
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string address { get; set; }
    }
    class Student : IPerson
    {
        // Somut nesne
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string department { get; set; }
    }

    class Worker : IPerson
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
    }

    class PersonManager
    {
        // 27 ile 36. satırlar arasını anlamak için yazılan kod bloğu
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.name);
        }
    }

    class PersonManager1
    {
        // Interface'lerin kullanımına en güzel örneklerden birisidir. 
        /*
        Customer ve Student nesneleri IPerson'ı implemente ettiği için aslında bu nesnelerde birer interface özelliği kazanıyor ve Add() metoduna 
        IPerson türünde bir parametre gönderildiğinde ve istenildiği takdirde
        Student veya Customer nesnesini IPerson ile aynı tür ( interface ) olması sebebiyle parametre olarak vermemize olanak sağlamış oluyoruz.
        */
        public void Add(IPerson person)
        {
            Console.WriteLine(person.name);
        }
    }
}
