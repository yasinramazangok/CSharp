using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
        int id; // default erişim bildirgeci private'dır.
        protected string name = "Yasin Ramazan"; // inherit edildiği sınıflarda da kullanılabilir. Yani protected private'ın inheritance seviyesine çıkarılmış halidir.
        public void Save()
        {
            int id2;
            Console.WriteLine(id); // id'ye tanımlandığı blok içerisinden erişim sağlayabildik.
        }
        public void Delete()
        {
            // Console.WriteLine(id2); // Hata verir çünkü id2 Save() metodunda tanımlıdır ve erişim belirteci private'dir. Delete() metodunda erişilemez.
        }
    }
    class Student:Customer
    {
        public void Save2()
        {
            /*
            Customer customer = new Customer();
            customer. // denildiği zaman id field'ına erişemeyiz. Çünkü default olarak private'dır ve private erişim sadece tanımlandığı blok içerisinde erişime izin verir.
            */
            Console.WriteLine(name); // name değişkeni protected olduğu için kalıtımla alınan sınıftan erişim sağlayabiliyoruz.
        }
    }
    class Course // Bir class'ın default erişim bildirgeci internal'dır.
    {

    }
    public class Course2
    {
        // AccessModifiersDemo projesinde çağırılıyor.
    }
}
