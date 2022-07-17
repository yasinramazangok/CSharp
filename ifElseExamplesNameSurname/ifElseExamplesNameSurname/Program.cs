using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseExamplesNameSurname
{
    class Program
    {
        static void Main(string[] args)
        {
            string kulad = "";
            string sifre = "";
            Console.WriteLine("Kullanıcı adınızı giriniz:");
            kulad = Convert.ToString(Console.ReadLine());
            if (kulad != "yrg00")
            {
                Console.WriteLine("Hatalı kullanıcı adı!");
                Console.WriteLine("Kullanıcı girişi yapamazsınız. Çıkmak için Enter tuşuna basınız!");
                while (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    
                    Environment.Exit(0);
                }
                
                 
            }
            //else if (Console.ReadKey().Key == ConsoleKey.BURASININ METODU ARAŞTIRILACAK)
            //{

            //}
            else
            {
                Console.WriteLine("Lütfen şifrenizi giriniz:");
                sifre = Convert.ToString(Console.ReadLine());
            }
             
           
            /*if (kulad == "yrg00" && sifre == "123456")
            {
                Console.WriteLine("Giriş başarılı!");
            }*/
            if (sifre != "123456")
            {
                Console.WriteLine("Hatalı şifre!");
                
            }
            else if (kulad == "yrg00" && sifre == "123456")
            {
                Console.WriteLine("Giriş başarılı!");
            }
             

            Console.ReadKey();
        }
    }
}
