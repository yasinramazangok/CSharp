using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicAndobjectfarkı
{
    class Program
    {
        static void Main(string[] args)
        {
           object o = "fatih";  
           int t = ((string)o).Length;// unboxing yapılıyor.
           Console.WriteLine(t);
           dynamic d = "Yasin Ramazan"; 
           int k = d.Length;
           Console.WriteLine(k);
            /* object Rakam = 10;
               Rakam = Rakam + 10; /// Derleme zamanı hatası. Çünkü derleme anında Rakam değişkeni System.Object tipinde */
           object Rakam = 10;
           Rakam = (int)Rakam + 10; /// Hatasız atama için, unboxing yapmamız gerekiyor 
           Console.WriteLine(Rakam);
           dynamic sayi = 5;
           sayi = sayi + 5;  /// Hata vermez
           Console.WriteLine(sayi);
           Console.ReadKey();
          
        }
    }
}
