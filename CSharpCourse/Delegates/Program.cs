using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        // Parametre almayan ve void olan metotlara delegelik yapıyor diyebiliriz.
        public delegate void MyDelegate(); // Burası bir elçiliktir.
        public delegate void MyDelegate2(string text); // Delegate ifadeleri parametre alabilir. 
        public delegate int MyDelegate3(int number1, int number2);

        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.SendMessage();
            customerManager.ShowAlert();


            MyDelegate myDelegate = customerManager.SendMessage; // myDelegate bir elçidir.
            myDelegate += customerManager.ShowAlert;
            myDelegate -= customerManager.SendMessage; // Delegate işlemlerin yapmak istemediğimiz bir işlemi geri alabiliriz.

            // Delegate ile projede yapılacak işler belirli bir sıraya konularak en sonunda bu sıraya göre yapılması amaçlanır.


            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            myDelegate2("Merhaba");

            myDelegate();

            Console.WriteLine("------------------------------");

            Math math = new Math();
            MyDelegate3 myDelegate3 = math.Sum;
            //var result =myDelegate3(3, 6);
            //Console.WriteLine(result);
            myDelegate3 += math.Multiplication;
            var result2 = myDelegate3(4, 9);
            // Delegate'lerde bir return type var ise delegate'e en son verilen işlemin sonucu döner. 
            // Yani yukarıda önce toplama verildi ancak ardından çarpma verildiği için ve ikisi de return type bir metot olduğu için çarpma işleminin sonucu döner.
            Console.WriteLine(result2);
            
            
            Console.ReadLine();
        }
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Bu bir delegate mesajıdır.");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    class Math
    {
        public int Sum(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Multiplication(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
