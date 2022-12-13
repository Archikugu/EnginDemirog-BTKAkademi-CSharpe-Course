using System;

namespace InterfacesDemo
{
    public class Program
    {
        //SOLID , Interface Segregation

        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[] { new Manager(), new Worker(), new Robot() };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[] { new Worker(), new Manager() };
            foreach (var eat in eats)
            {
                eat.Eat();
            }

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
            Console.WriteLine("Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Get Salary");
        }

        public void Work()
        {
            Console.WriteLine("Work");
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Get Salary");
        }

        public void Work()
        {
            Console.WriteLine("Work");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Work");
        }
    }
}
