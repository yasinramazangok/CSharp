using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Ne zaman interface ne zaman class kullanacağımıza karar verme noktasında abstract class'lar önemli bir bileşendir.
    // Interface kullanımı öncelikli olmalıdır. Ancak class'ları miras alma senaryolarını da iyi belirlemek gerekmektedir.
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Customer{name="Yasin"},
                new Student{name="Ramazan"},
                new Person{name="Ali"} // Ebeveyn olan Person'ı ekleyebiliyoruz çünkü class olduğu için tek başına bir nesneyi ifade edebilir. Interface'lerde aynı durum geçerli değildi.
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.name);
            }

            Console.ReadLine();
        }
    }
    class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
    }
    class Person2
    {
        // Bir nesne bir sınıfı miras alabilirken birden fazla interface'i implemente edebilir. Yani C# çoklu kalıtımı desteklemez. 
    }
    class Customer : Person
    {
        public string city { get; set; }
    }
    class Student : Person
    {
        public string department { get; set; }
    }
}
