using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsMetinIcerisindeKacTaneKelimeOldugunuBulanProgram
{
    class Program
    {
       
        static void Main(string[] args)
        {

            
            Console.WriteLine("Lütfen bir metin giriniz: ");
            string metin =  Console.ReadLine();
            int kelimeSayısı = kelimeSayisiniBul(metin);
            Console.WriteLine("Girdiğiniz metindeki kelime sayısı: {0}'dır.",kelimeSayısı);
            Console.ReadLine();
        }
        static int kelimeSayisiniBul(string metin)
        {
            int sayac = 1;
            foreach (char character in metin)
            {
                if (character ==' ')
                {
                    sayac++;
                }

            }
            return sayac;
        }
    }
}
