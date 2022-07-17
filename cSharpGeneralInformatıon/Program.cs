using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpGeneralInformatıon
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1234124313; // -2147483648 ile 2147483647 arası tam sayılar
            double b = 123121345235.1242353245345324634634; // ±5.0*10^-324, ..., ±1.7*10^308 arası reel sayılar
            double bc = 123121345235.1242353245345324634634d;
            double bcd = 123121345235.1242353245345324634634D;
            float c = 2.45f; // 	±1.5*10^45, ..., ±3.4*10^38 arası reel sayılar 
            float cd = 2.45F;
            string metin = "25"; // metinsel ifadeler
            string metin2 = "Yasin Ramazan GÖK";
            byte d = 123; // 0,...,255 arası tam sayılar ( 8 bit işaretsiz tamsayı ) 
            sbyte dd = 56; // -128,...,127 arası tam sayılar ( 8 bit işaretli tamsayı )
            short e = -23545; // -32768,...,32767 arası tam sayılar
            long f = 9852738459279043; // -9223372036854775808, ..., 9223372036854775807 arası tam sayılar
            decimal g = 283276283; // ±1.5*10-28, ..., ±7.9*1028 arası reel sayılar 
            bool h = true; // true ya da false değerlerini alan veri türü 
            char j = 'g'; // tek bir Unicode karakter tutar 
            var ı = 123; // veri tipine göre derleyici kendisi belirleyecektir. Örneğin bu int dir.
            object k = 123; // Boxing 
            int k1 = (int)k; // Unboxing
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(bc);
            Console.WriteLine(bcd);
            Console.WriteLine(c);
            Console.WriteLine(cd);
            Console.WriteLine(metin);
            Console.WriteLine(metin2);
            Console.WriteLine(d);
            Console.WriteLine(dd);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(j);
            Console.WriteLine(ı);
            Console.WriteLine(k);
            Console.WriteLine(k1);
            object k2 = 120984712340982345; // Tipi bilinmeyen bir değişken ise .GetType() özelliği kullanılarak değişkenin tipi bulunabilir.
            k2.GetType();
            Console.WriteLine(k2.GetType());
            Console.WriteLine(k2); // Çıktı ' System.Int64 ' ifadesi şeklinde olur.


        }
            {
                // ÖZEL KULLANIMLAR
                // Ters slaş (\) ve bir karakterden oluşur. Derleyiciye sonraki karakterin özel olarak algılanması işaretini verir.  
                // \n sonraki satıra geç
                // \t sonraki sekmeye geç
                // \r satır başına dön
                // \\ ters slaş karakteri
                // \’ tek tırnak
                // ” çift tırnak : çift tırnak ‘ ” ‘ şeklinde yazılabilir ancak string lerin içinde ” \” ” şeklinde yazılmalıdır.
                // bilinçli tür dönüşümü


            }
            {
                int a = 45;
    Console.WriteLine(a);
            }
{
    int a = 3;
    Console.WriteLine(a);
}
{
    const double pi = 3.14; // sabit veri türü içi ' const ' kullanılır.
    Console.WriteLine(pi);

}
{
    bool asd = new bool(); // asd değişkenine bool veri tipinin varsayılan değerini( false ) atama metodudur.
    Console.WriteLine(asd);
}
{
    // Bilinçli tür dönüşümü 
    int cd = 123;
    float cdf = 2.34f;
    double cdfg = 234.45;
    string metin3 = "222";
    int cds = (int)cdfg; // Örneğin cdfg ondalıklı sayısını integer a dönüştürürken ondalıklı kısım atılır ve tam kısım çıktı alınır.
    Console.WriteLine(cds);
    int qwerty = 65498;
    byte xtz = (byte)qwerty;
    Console.WriteLine(xtz); // Büyük türün bilinçli olarak küçük türe dönüştürülmesi ve veri kaybı yaşanır.

    // Bilinçsiz tür dönüşümü 
    int cdsa = 99;
    float cdfa = (float)cdsa; // burada (float)cdsa dememize gerek yoktur çünkü her int bir ondalıklı sayıdır ama hiçbir ondalıklşı sayı int değildir!
    Console.WriteLine(cdfa);
    byte a = 12; // Küçük türün büyük türe dönüşümü ve veri kaybı olmaz.
    int b;
    b = a;
    Console.WriteLine(b);


    // Parse 
    int cdq = int.Parse(metin3); // Metin içerisindeki ifadeyi tipi uygunsa tanımlanan değişkene atar.
    float cde = float.Parse(metin3);
    //string metin4 = string.Parse(); dönüşümünü yapamayız.

    // ToString metodu

    string metin5 = cd.ToString();
    Console.WriteLine("Bu bir metinsel ifadedir{0}", metin5); // {0} ile + aynı işlevi görür
    Console.WriteLine("Bu bir metinsel ifadedir" + metin5);
    //Console.ReadLine(); // Klavyeden girilen değeri okur
    //Console.ReadKey(); // Herhangi bir tuşa basınca çıktı kapanır

    int tamsayi = 5;
    float ondalikli = 2.5f;
    double bondalikli = 258.7894562;
    string metin = "789";
    bool aasdasd = new bool();


    // int toplam = tamsayi + metin; işlemini yapamayız ancak;
    string toplam = tamsayi.ToString() + metin;
    Console.WriteLine(toplam); // çıktı 5789 olur!
    float toplam1 = float.Parse(metin) + ondalikli;
    Console.WriteLine(toplam1);
    int toplam2 = (int)float.Parse(metin) + (int)ondalikli;
    Console.WriteLine(toplam2);



}
{
    Console.WriteLine("Bir sayı giriniz:");
    //int sayi = Console.ReadLine();  şeklinde alınmaz
    //string sayi = Console.ReadLine(); şeklinde olur
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("İkinci sayıyı giriniz:");
    int sayi2 = Convert.ToInt32(Console.ReadLine());

    double toplam = (double)sayi + sayi2; // (double)sayi+ (double)sayi2;
    Console.WriteLine(toplam);
    //Console.ReadKey();

    Console.WriteLine("Bir sayı giriniz:");

    string sayi1 = Console.ReadLine();

    Console.WriteLine("İkinci sayıyı giriniz:");
    string sayi3 = Console.ReadLine();

    string toplam2 = sayi1 + sayi3;
    Console.WriteLine(toplam2);
    //Console.ReadKey();


}
{
    int a = 5;
    float b = (float)a;

    int k = int.Parse("58");
    string s = a.ToString();


    Console.WriteLine("Bir sayı giriniz:");

    string sayi1 = Console.ReadLine();

    Console.WriteLine("İkinci sayıyı giriniz:");
    string sayi3 = Console.ReadLine();

    string toplam = sayi1 + sayi3;
    int toplam2 = Convert.ToInt32(toplam);
    Console.WriteLine(toplam2);
    Console.ReadKey();
}
    }
}
