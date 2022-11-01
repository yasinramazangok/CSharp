using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string'ler esasında bir char array'dir. Ve index'lerindeki değerlere erişilebilir.

            //StringIntro();

            string sentence = "Benim adım Yasin Ramazan GÖK, .NET ile yazılım geliştiriyorum.";
            var result = sentence.Length; // Karakter sayısı
            Console.WriteLine("Karakter sayısı: "+result);
            var result2 = sentence.Clone(); // Burada yeni bir referans oluşturuyoruz.******
            sentence = "My name is Yasin Ramazan GOK, I'm developing with .NET"; // result2 değişmeyecektir.
            Console.WriteLine("Değiştirilmiş metin: "+sentence);
            Console.WriteLine("Kopyalanmış metin: "+result2);

            bool result3 = sentence.EndsWith("t"); // İlgili değişken verilen parametre ile bitiyor mu? Sonuç bool türündedir. 
            bool result4 = sentence.StartsWith("M");
            Console.WriteLine(result3);
            Console.WriteLine(result4);

            var result5 = sentence.IndexOf("Ramazan"); // Bir string dizisinde belirli bir karakteri veya ifadeyi aramak için kullanılır.
            // IndexOf() metodu verilen parametrenin bulduğu ilk yerde kaçıncı karakterden başladığını int türünde döndürür. Bulamadığında ise -1 döndürür.
            Console.WriteLine("Aranan kelime {0}. index'ten başlıyor!",result5);
            var result6 = sentence.LastIndexOf("Yasin"); // Aramaya son index'ten başlar. Ancak baştan kaçıncı index olduğu bilgisini döndürür.
            Console.WriteLine(result6);

            var result7 = sentence.Insert(3,"Bu Insert() metodu ile eklenen cümledir."); // Başlangıç index'ini vermemiz gerekir.
            Console.WriteLine(result7);

            var result8 = result7.Substring(3); // Verilen başlangıç index'inden itibaren dizideki elemanları almaya yarar.
            Console.WriteLine(result8);
            var result9 = result7.Substring(3,10); // Verilen başlangıç index'inden itibaren  2. parametre kadar karakteri alır ve geri döndürür.
            Console.WriteLine(result9);

            var result10 = sentence.ToLower(); // Dizideki karakterleri küçük harfe çevirir.
            Console.WriteLine(result10);
            var result11 = sentence.ToUpper(); // Dizideki karakterleri büyük harfe çevirir.
            Console.WriteLine(result11);

            var result12 = sentence.Replace(" ", "***"); // Dizide birinci parametredeki karakterleri ikinci parametredeki karakterlere çevirir.
            Console.WriteLine(result12);

            var result13 = sentence.Remove(15); // Parametre olarak verilen index'ten itibaren karakterleri kaldırır.
            Console.WriteLine(result13);
            var result14 = sentence.Remove(15,10); // Birinci parametreden itibaren ikinci parametre kadar karakteri kaldırır.
            Console.WriteLine(result14);

            Console.ReadLine();

        }

        private static void StringIntro()
        {
            string name = "Yasin Ramazan";
            Console.WriteLine(name[10]); // bir string'in herhangi bir index'indeki değere erişim
            Console.WriteLine("---------------------");
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            string name2 = "Ali"; // Stringler toplanabilir yani yan yana getirilebilir.
            string sum = name + " " + name2;
            Console.WriteLine(sum);

            string sum2 = String.Format("{0} {1}", name, name2);
            Console.WriteLine("String sınıfının Format() metodu ile stringleri birleştirme: " + sum2);
            Console.WriteLine(String.Format("{0} {1}", name, name2)); // Aslında Console.WriteLine() metodu da formatlıdır.
        }
    }
}
