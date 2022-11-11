using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        // Reflection pahalı(!) bir yapıdır ve çalışma zamanında doğru ihtiyaç anında uygulanması gereken bir yapıdır.
        // Aksi takdirde performans kaybına neden olabilir.
        static void Main(string[] args)
        {
            /*
            DortIslem dortIslem = new DortIslem(2, 5);
            int result = dortIslem.Multiplication(4, 9); // Constructor ile etkileşimde bulunmayan metot
            Console.WriteLine(result);
            int result2 = dortIslem.Multiplication2(); // Constructor ile set edilen değişkenleri kullanan metot
            Console.WriteLine(result2);
            */

            //var type = typeof(DortIslem);
            //Activator.CreateInstance(type);
            /*
             * Bu iki satırdaki kod aslında normalde;
             * DortIslem dortIslem = new DortIslem(); bu kodun yaptığı işi ÇALIŞMA ZAMANInda yapar.
             */

            var type2 = typeof(DortIslem);
            DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type2, 6, 8); // CreateInstance() bir nesne döndürür. Çalışma anında dinamik bir nesne üretir.
            //int result3 = dortIslem.Sum(2, 5);
            //int result4 = dortIslem.Sum2();
            //Console.WriteLine(result3);
            //Console.WriteLine(result4);

            var instance = (DortIslem)Activator.CreateInstance(type2, 3, 2);
            var result5 = instance.GetType().GetMethod("Sum2").Invoke(instance, null); // GetMethod() aslında sadece verilen parametrenin metadatasını döndürür.
            Console.WriteLine(result5);

            MethodInfo methodInfo = instance.GetType().GetMethod("Sum2");
            var result6 = methodInfo.Invoke(instance, null);
            Console.WriteLine(result6);

            // metotlara ulaşma
            var methods = type2.GetMethods();
            foreach (var item in methods)
            {
                Console.WriteLine("Metot adı: {0}",item.Name);
                foreach (var parameters in item.GetParameters())
                {
                    Console.WriteLine("Parametre: {0}",parameters.Name);
                }
                foreach (var attribute in item.GetCustomAttributes())
                {
                    Console.WriteLine("Attributes: {0}",attribute.GetType().Name);
                }
            }
            
            Console.ReadLine();

        }
    }
    class DortIslem
    {
        private int _sayi1;
        private int _sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public int Sum(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Multiplication(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        [MethodName("Toplama")]
        public int Sum2()
        {
            return _sayi1 + _sayi2;
        }
        public int Multiplication2()
        {
            return _sayi1 * _sayi2;
        }
    }

    public class MethodNameAttribute:Attribute
    {
        public MethodNameAttribute(string name)
        {
            // Attribute'lar ile aslında nesneye, metoda bir anlam yükleriz.
        }
    }
}
