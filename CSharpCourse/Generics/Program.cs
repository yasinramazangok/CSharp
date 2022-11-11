using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "Hatay", "İzmir");
            // Burada verilen parametreleri metodun generic kısmında belirtilen türde liste yapar.Yani burada metotlarda generic olabilir.
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName="Ayşe"}, new Customer { FirstName="Ali" });
            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }
            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }


    // Burada her nesne için ayrı ayrı interface tanımlamak zorunda kaldık.
    // Bu durumlarda generic ifadelerle bu yapıyı base bir yapı üzerinden tanımlayabiliriz. Aşağıda bu örneklenmiştir.
    interface IProductDal : IRepository<Product>
    {
    }

    class Product
    {

    }

    interface ICustomerDal : IRepository<Customer>
    {
    }

    class Customer
    {
        public string FirstName { get; set; }
    }

    /*
    where T: class demek, generic constraints yani generic kısıtıdır. Çünkü T yerine örneğin Customer yazacağı yerde string veya int yazabilir.
    Aslında class demek referans tip yazılabilir demektir. 
    interface IStudentDal : IRepository<string>
    {
        // burası hata vermez!
    }
    interface IStudentDal : IRepository<int>
    {
        // Ancak burası hata verir çünkü int bir value type'dır.
    }
    new() ise buraya yazılan tip hem referans tip olmalı hem de new'lenebilmelidir anlamına gelir. Yani artık;
    interface IStudentDal : IRepository<string>
    {
        // Burası da hata verir.
    }

    interface IEntity
    {

    }
    class Student:IEntity
    {

    }
    interface IRepository<T> where T : class, IEntity, new() // Yani hem referans tip, hem IEntity'den implemente edilmeli hem de new'lenebilmeli demektir.
    {
        List<T> GetAll();
        T Get();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    interface IStudentDal : IRepository<Student>
    {
        // u şekilde kullanılmalıdır.
    }

    interface IRepository<T> where T : struct // Değer tipler için kullanım bu şekildedir.
    {
        List<T> GetAll();
        T Get();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
    */

    interface IRepository<T> where T : class, new() // Yani hem referans tip, hem IEntity'den implemente edilmeli hem de new'lenebilmeli demektir.
    {
        List<T> GetAll();
        T Get();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
