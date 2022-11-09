using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    // BİR CLASS BİRDEN FAZLA INTERFACE'İ IMPLEMENTE EDEBİLİR. AŞAĞIDA BU ÖRNEKLENMİŞTİR.
    // Aşağıda interface'lerin doğru planlanması örneklenmiştir. Bu SOLID prensiplerinden Interface Segregation Principle'dır.
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }

            ISalary[] salaries = new ISalary[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }

            Console.ReadLine();
        }
    }
    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager eated.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager got salary.");
        }

        public void Work()
        {
            Console.WriteLine("Manager worked.");
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker eated.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker got salary.");
        }

        public void Work()
        {
            Console.WriteLine("Worker worked.");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot worked.");
        }
    }
}
