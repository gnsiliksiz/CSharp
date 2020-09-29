using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemoApp
{
    class Program
    {
        //SOLID-Interface  Segregation Prensibi kullanıldı.
        static void Main(string[] args)
        {
            //Work için dizi tanımlama ve dolasma
            IWorker[] workers = new IWorker[]
            {
                new Manager(),
                new Worker(),
                new Robot()

            };
            foreach(var worker in workers)
            {
                worker.Work();

            }
            //yemek için dizi tanımlama ve dolaşma
            IEat[] eats = new IEat[]
            {
                new Worker(),
                new Manager()

            };
            foreach(var eat in eats)
            {
                eat.Eat();
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
            Console.WriteLine("Manager yemek ");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager maas ");
        }

        public void Work()
        {
            Console.WriteLine("Manager iş ");
        }
    }

    class Worker : IWorker ,IEat,ISalary//implemente edildi.
    {
        public void Eat()
        {
            Console.WriteLine("Worker yemek ");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker maas");
        }

        public void Work()
        {
            Console.WriteLine("Worker is");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot iş");
        }
    }
}
