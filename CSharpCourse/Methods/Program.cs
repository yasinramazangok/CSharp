using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Methods
            // Metotlar, genellikle DRY ( Do not Repeat Yourself! ) prensibine uyum sağlamak için tanımlanır.
            Add();
            var result = Add2(2, 56);
            Console.WriteLine(result);
            var result2 = Add3(2);
            Console.WriteLine(result2);
            Console.WriteLine("---------------------");
            int number1 = 25;
            int number2 = 50;
            var result3 = Add4(ref number1, number2);
            Console.WriteLine(result3);
            Console.WriteLine(number1);
            Console.WriteLine("----------------------");
            Console.WriteLine(Multiply(9,5));
            Console.WriteLine(Multiply(9, 5, 3));
            Console.WriteLine("----------------------");
            Console.WriteLine(Add5(1,4,2,5,3,2,1,3));
            Console.WriteLine(Add6(1,4,2,5,3,2,1,3));
            Console.ReadLine();
        }

        static void Add()
        {
            // void metotlar, geriye değer döndürmeyen metotlardır.
            Console.WriteLine("Eklendi!");
        }

        static int Add2(int number1, int number2)
        {
            // Parametre alan metot

            // var result = number1 + number2; 
            // return result;
            
            return number1 + number2;   
        }

        static int Add3(int number1, int number2=56)
        {
            // Parametre alan ve default değeri olan metot
            // Default değerler her zaman en son parametrelerde olmalıdır. Yoksa hata alınır.
            // var result = number1 + number2; 
            // return result;

            return number1 + number2;
        }

        static int Add4(ref int number1, int number2)
        {
            // number1'i ref anahtar sözcüğü ile girerek adresini belirtiyoruz.
            // Yani number1'in metotun içinde gerekli görüldüğü takdirde değişebileceğini kabul etmiş oluyoruz.
            number1 = 30; // Bu şekilde içeride number1'e atama yapıyoruz.

            /* out anahtar sözcüğü ile de aynı işlemleri yapabiliriz ancak
            out'un ref'ten tek farkı gönderilen parametre değişkeninin ilk başta 
            set edilme zorunluluğunun olmamasıdır.
            */

            return number1 + number2;
        }

        // Method Overloading
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        // params
        static int Add5(params int[] numbers)
        {
            // params anahtar sözcüğü ile metodumuza istediğimiz kadar parametre gönderme imkanımız vardır.
            return numbers.Sum();
        }

        static int Add6(int number1, params int[] numbers)
        {
            // Metot çağırıldığın ilk gönderilen parametre number1 olarak atanır.
            // O yüzden aşağıda sadece params parametreleri işleme alındığı için ona göre sonuç döner.
            return numbers.Sum();
        }

        /* Hata verir çünkü params olarak gönderilen parametreler en son parametreler olmalıdır.
        
        static int Add5(int number1, params int[] numbers, int number2)
        {
            return numbers.Sum();
        }
        
        */
    }
}
