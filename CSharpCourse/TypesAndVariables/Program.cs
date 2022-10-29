using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Types
            // Console.WriteLine("Merhaba Dünya");

            int number1 = -2147483648;
            int number2 = 2147483647;
            // Bellekte 32 bit yer alır.
            // Eksi değer aralığının mutlak değerce 1 fazla olmasının sebebi, işaret bit'inin de hesaba katılmasıdır.***
            Console.WriteLine("Integer negative bottom range is {0}", number1);
            Console.WriteLine("Integer positive top range is {0}", number2);

            long number3 = -9223372036854775808;
            long number4 = 9223372036854775807;
            // Bellekte 64 bit yer alır.
            // long veri tipi, int veri tipinin 2 katı büyüklüğünde bellekte yer alır.
            Console.WriteLine("Long negative bottom range is {0}", number3);
            Console.WriteLine("Long positive top range is {0}", number4);

            short number5 = -32768;
            short number6 = 32767;
            // Bellekte 16 bit yer alır.
            Console.WriteLine("Short negative bottom range is {0}", number5);
            Console.WriteLine("Short positive top range is {0}", number6);
            
            byte number7 = 0;
            byte number8 = 255;
            // Bellekte 8 bit yer alır.
            Console.WriteLine("Byte bottom range is {0}", number7);
            Console.WriteLine("Byte positive top range is {0}", number8);

            bool condition1 = true;
            bool condition2 = false;
            // Mantıksal değer tipi boolean'dır.

            char character = 'a';
            // Genellikle ASCII olarak bilinen yani klavyede bulunan değerleri tutmak için kullanılan veri türüdür.
            // string veri türü, aslında char türünde bir dizidir.
            // char veri türü int veri türüne 'cast' edilebilir.
            char character2 = 'A';
            Console.WriteLine("Character {0} ASCII code is {1}",character2,(int)character2);

            double number9 = 1234.1234;
            // Bellekte 64 bit yer alır.
            // Ondalıklı sayıları da tutabileceğimiz değer türüdür.
            // Virgülden sonra 15 veya 16 karakter tutabilir.
            Console.WriteLine(number9);

            decimal number10 = 123413.12234m;
            decimal number11 = 123413.243534M;
            // Bellekte 128 bit yer alır.
            // int için long ne ise double veri türü için de decimal odur.
            // Hassasiyet gösteren veriler için kullanılır. ( Örneğin para birimleri gibi )
            // Virgülden sonra 28 veya 29 karakter tutabilir.
            Console.WriteLine(number10);
            Console.WriteLine(number11);

            // enum veri türü de bir değer tipli veri türüdür.
            if (Days.Friday == 0)
            {
                /* Örneğin normalde bir string dizisinde günleri tutmak yerine bu şekilde
                enum yapısında tutarak 'magic string' kavramının dezavantajını önlemiş oluyoruz.
                */
            }
            Console.WriteLine("Enum veri türünün 'cast' işlemi: ");
            Console.WriteLine((int)Days.Friday); // Normalde index numarasını ekrana yazdıracaktır.
            Console.WriteLine(Days.Tuesday);
            /* Ancak Tuesday değişkenine 55 değeri atandığı için o değeri C#
            başlangıç index'i kabul ediyor ve Friday için ekrana 58 sonucunu verecektir.
            */

            var number12 = 30;
            /* Var bir değer tipi değildir ancak var ile tanımlanan değişkene hangi türde              
            atama yapılırsa o türde bellekte yer alır.
            */
            Console.WriteLine(number12);
            number12 = 'A'; // Burada dönüşüme izin verilir ve ASCII değeri ekrana yazdırılır.
            // number12 = "Yasin Ramazan GÖK"; // Bu atamaya izin verilmez çünkü number12 değişkeni başlangıçta int olarak tanımlanmıştır.
            Console.WriteLine(number12);
            Console.ReadLine();


        }
    }

    enum Days
    {
        Monday, Tuesday=55, Wednesday, Thursday, Friday, Saturday, Sunday 
    }
}
