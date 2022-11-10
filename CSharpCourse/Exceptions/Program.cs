using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        // Hata yakalama, hataları bulup kullanıcıya daha farklı bir bilgi verme amacı ile yönetilen bir yapıdır.
        // Hata yakalamanın aşamaları, katmanlı mimaride adım adım şekillenir.
        // Hatanın ne olduğu end user'a gösterilmez. Çünkü end user sistem hakkında bilgi sahibi olabilir. Bu da bir güvenlik zaafiyeti doğurabilir.
        // Bunun yerine hatalar düzenli bir şekilde log'lanır.**********
        static void Main(string[] args)
        {
            // ExceptionIntro();

            try
            {
                Find(); // Katmanlı mimarilerde Find() metodu back-end'de yazılırken; try-catch bloğu ise front-end'de yazılır.*****
            }
            catch (RecordNotFoundException exception)
            {

                Console.WriteLine(exception.Message);
            }

            HandleException(() =>
            {
                Find();
            }); // Bu action kulanımıdır ve try-catch bloğundan daha kullanışlı bir yapı sunar. Action aslında HandleException() metodunun içerisine yazılan kodlarn tamamıdır.

            Console.ReadLine();
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
