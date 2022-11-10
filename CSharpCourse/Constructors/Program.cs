using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    // Bir sınıf farklı parametrelere ihtiyaç duyuyorsa ve bu parametreler değişkenlik gösteriyorsa constructor kullanılır.
    // Constructor'lar overload edilebilir.
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.List();
            
            /*
            Product product = new Product();
            product.id;
            product.name;

            Product product1 = new Product { id=2, name = "Telefon"};
            Bu şekilde kullanılabilir ancak constructor tanımlayarak bu parametreler ilgili sınıfın bir örneği oluşturulurken constructor'dan da alınabilir.
            Aşağıda bu örneklenmiştir.
            */
            Product product2 = new Product(3, "Laptop");

            /* 
            1. Kullanım
            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.logger = new DatabaseLogger(); // Bu şekilde kullanıma ihtiyaç olmaması açısından bunu da constructor'dan alabiliriz. Aşağıda örneklenmiştir.
            employeeManager.Add();
            */

            EmployeeManager employeeManager1 = new EmployeeManager(new FileLogger());
            employeeManager1.Add();

            PersonManager personManager = new PersonManager("Bilgisayar");
            personManager.Add();

            Manager.DoSomething(); // static bir metot olduğu için sınıf ismi ile çağırdık.
            Manager manager = new Manager();
            manager.DoSomething2(); // static olmadığı için nesne oluşturarak kullandık.
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        private int _count; // Bu bir field'dır.
        public CustomerManager(int count)
        {
            _count = count;
            
        }
        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0} items",_count);
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }
    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
            // Bu şekilde istenilen parametreler bir sınıfın nesnesi oluşturulduğunda constructor yardımıyla alınabilir.
        }

        public int id { get; set; }
        public string name { get; set; }
    }
    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }
    class EmployeeManager
    {
        public ILogger logger { get; set; }
        public EmployeeManager(ILogger logger)
        {
            this.logger = logger;
        }
        public void Add()
        {
            logger.Log();
            Console.WriteLine("Added");
        }
        /*
        1. Kullanım 

        public ILogger logger { get; set; }
        public void Add()
        {
            logger.Log();
            Console.WriteLine("Added");
        }
        */
    }
    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }
    class PersonManager:BaseClass
    {
        public PersonManager(string entity):base(entity)
        {
            // PersonManager, aslında BaseClass'a parametre göndermeye aracılık etmiş oluyor. 
        }
        public void Add()
        {
            Console.WriteLine("Added");
            Message(); // Miras aldığı için BaseClass'ın metodunu çağırabildik.
        }
    }

    static class Teacher
    {
        // static nesneler bir defa oluşturulur ve bütün program o nesnenin bir kopyasını kullanılır.
        // static nesnenin özellikleri de static olmalıdır.
        // static nesnelerin bir özelliğine değer atandığı zaman bütün kopyalarda aynı değer kullanılır çünkü static kelimesi referans tipe atıfta bulunur.
        // static olan metot veya özellikler instance olmadan sınıf ismi ile çağırılabilirken; static olmayan özellik veya metotları nesne oluşturarak kullanmak zorundayız.
        public static int number { get; set; }
    }
    static class Utilities
    {
        public static void Validate()
        {
            Console.WriteLine("Validation is done.");
        }
    }
    class Manager
    {
        // Bu sınıfın static olmadığı bir senaryo aşağıda örneklenmiştir. Eğer sınıf static olsaydı DoSomething2() metodu da static tanımlanmalı şeklinde uyarı verecekti.
        public static void DoSomething()
        {
            Console.WriteLine("static Done");
        }
        public void DoSomething2()
        {
            Console.WriteLine("non-static Done");
        }
    }
}
