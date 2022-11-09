using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    // Abstract class'lar interface'ler ile virtual metotların birleşimi gibi düşünülebilir.
    // Abstract class'larda bir inheritance'dır ve C#'daçoklu kalıtımı desteklemezler.
    class Program
    {
        static void Main(string[] args)
        {
            // Database database = new Database(); // Hata verir çünkü abstract class'lar da interface'ler gibi new'lenemezler. 
            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database database1 = new MySql();
            database1.Add();
            database1.Delete();

            Console.ReadLine();
        }
    }
    abstract class Database
    {
        // Ekleme işlemi her yerde aynıdır. 
        // Bu tamamlanmış metottur.
        public void Add()
        {
            Console.WriteLine("Added.");
        }
        public abstract void Delete(); // Bu şekilde abtract metotlar ise tamamlanmamış metottur.
        // Abtract metot aslında içi dolu olmayan virtual metottur.
    }
    class MySql : Database
    {

        public override void Delete()
        {
            Console.WriteLine("MySql deleted.");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Oracle deleted.");
        }
    }
}
