using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchCaseExamplesIllereGoreGeziRehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen gezmek istediğiniz ili listeden seçip yazınız:");
            Console.WriteLine("Ankara\nİstanbul\nİzmir\nBursa\nHatay\nGaziantep\nTrabzon ");
            string secilenIl;
            secilenIl = Convert.ToString(Console.ReadLine());
            switch (secilenIl)
            {
                case "Ankara":
                    Console.WriteLine("Ankara'da mutlaka Anıtkabir'e gitmelisin!");
            break;
                case "İstanbul":
                    Console.WriteLine("İstanbul'da Kız Kulesi'ne gitmeyi unutma!");
                    break;
                case "İzmir":
                    Console.WriteLine("İzmir'de mutlaka Cumhuriyet Meydanı'na git!");
                    break;
                case "Bursa":
                    Console.WriteLine("Bursa'da Nilüfer'i gezmeyi unutma!");
                    break;
                case "Hatay":
                    Console.WriteLine("Hatay döner ve künefenin diyarıdır. Unutma!");
                    break;
                case "Gaziantep":
                    Console.WriteLine("Gaziantep'te baklava var. Daha ne olsun!");
                    break;
                case "Trabzon":
                    Console.WriteLine("Trabzon'da yeşilliklerin büyüsüne kapıl!");
                    break;

                default:
                    Console.WriteLine("Lütfen listedeki illerden birisini seçiniz!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
