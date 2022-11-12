using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    /*
     * ACTION'LAR RETURN TYPE OLMAYAN İŞLEMLER İÇİN UYGUN İKEN FUNC İSE RETURN TYPE OLAN İŞLEMLER İÇİN UYGUNDUR.
     * Yani func ile gönderdiğimiz metodu çalıştır ve bize bir değer döndür diyoruz.
    */
    internal class Program
    {
        // Hata yakalama, hataları bulup kullanıcıya daha farklı bir bilgi verme amacı ile yönetilen bir yapıdır.
        // Hata yakalamanın aşamaları, katmanlı mimaride adım adım şekillenir.
        // Hatanın ne olduğu end user'a gösterilmez. Çünkü end user sistem hakkında bilgi sahibi olabilir. Bu da bir güvenlik zaafiyeti doğurabilir.
        // Bunun yerine hatalar düzenli bir şekilde log'lanır.**********
        static void Main(string[] args)
        {
            // ExceptionIntro();

            // TryCatch();

            // ActionDemo();

            // Func<int, int, int> add = Topla(3, 2); // Burada aslında add operasyonunu bir delegate gibi düşünürek delegate kullanır gibi kullanmalıyız.
            Func<int, int, int> add = Topla;
            var result = add(3, 8);
            Console.WriteLine(Topla(2, 5));
            Console.WriteLine(result);

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();   
                return random.Next(1,25);
            };

            Console.WriteLine(getRandomNumber());

            Func<int> getRandomNumber2 = () => new Random().Next(25, 50);
            
            Console.WriteLine(getRandomNumber2());   
            Console.ReadLine();
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }

        private static void ActionDemo()
        {
            HandleException(() =>
            {
                Find();
            }); // Bu action kulanımıdır ve try-catch bloğundan daha kullanışlı bir yapı sunar. Action aslında HandleException() metodunun içerisine yazılan kodlarn tamamıdır.
        }

        private static void TryCatch()
        {
            try
            {
                Find(); // Katmanlı mimarilerde Find() metodu back-end'de yazılırken; try-catch bloğu ise front-end'de yazılır.*****
            }
            catch (RecordNotFoundException exception)
            {

                Console.WriteLine(exception.Message);
            }
        }

        private static void HandleException(Action action)
        {
            // Bu blok genellikle merkezi bir class'ın içerisine konularak oradan çağırılır.
            try
            {
                action.Invoke(); // action'ı invoke etmek, üstte metoda gönderilen Find() metodunu try-catch bloğu içerisinde çalıştır demektir.
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Yasin", "Ramazan", "GÖK" };

            if (!students.Contains("Ali"))
            {
                throw new RecordNotFoundException("Record not found!");
            }
            else
            {
                Console.WriteLine("Record found.");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                // try bloğunda hata alınırsa program catch bloğuna geçer.
                string[] students = new string[3] { "Yasin", "Ramazan", "GÖK" };

                students[3] = "Ahmet"; // IndexOutOfRangeException hatası alınır.
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.InnerException); // Varsa exception hakkınd daha detaylı bilgi verir.
                Console.WriteLine("EXCEPTIONNNN handled!"); ;
            }
        }
    }
}
