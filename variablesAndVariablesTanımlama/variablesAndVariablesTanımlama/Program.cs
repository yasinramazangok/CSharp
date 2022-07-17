using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variablesAndVariablesTanımlama
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            sayi = 5;
            long sayi1 = 1234123478918074;
            float sayi2 = 123.213423f; // Veya F de kullanılabilir.
            double sayi3;
            sayi3 = 128974693461471247814.234876124967;
            decimal moneyTL= 123412M; // Para birimlerinde kullanılır.
            char characterrr = 'a'; // Latin alfabesinde bir karakteri temsil eder.
            char characterrrr = '1'; // gibi!!!
            bool booleanMath = false; // Boolean matematiğinde mantıksal doğrulukları temsil eder.
            DateTime date = DateTime.Now; // Zaman değişkenlerini tanımlamada kullanılır.
            string worddd;
            worddd = "Yasin Ramazan"; // Karakter dizilerini tanımlamaya yarayan değişken tipidir.
            int a = new int(); // Değişkenlere ilk değer verme 
            a = 25;
            double c = new double();
            c = 254.23425d; // Veya c=124234.23423587D; şeklinde de yazılabilir.    
            Console.WriteLine(a);
            Console.WriteLine(c);
            Console.WriteLine(sayi);
            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
            Console.WriteLine(sayi3);
            Console.WriteLine(moneyTL);
            Console.WriteLine(characterrr);
            Console.WriteLine(characterrrr);
            Console.WriteLine(booleanMath);
            Console.WriteLine(date);
            Console.WriteLine(worddd+"\n");
            
            // Varsayılan Değerler Atama 
            char aa= new char();
            string a1;
            byte a2 = new byte();
            int a3 = new int();
            short a4 = new short();
            decimal a5 = new decimal();
            object a6 = new object();
            ushort a7 = new ushort();
            long a8 = new long();
            Console.WriteLine(aa);             
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);
            Console.WriteLine(a5);
            Console.WriteLine(a6);
            Console.WriteLine(a7);
            Console.WriteLine(a8);
            Console.ReadKey();






        }
    }
}
