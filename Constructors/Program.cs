using System;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.List();

            CustomerManager customerManager1 = new CustomerManager(20);
            customerManager1.List();


            Product product = new Product { Id = 1, Name = "Laptop" };
            Product product1 = new Product { Id = 2, Name = "Computer" };

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 10;
            Utilities.Validate();

            Manager.DoSomething();

            Manager manager = new Manager();
            manager.DoSomething2();

        }
    }
    class CustomerManager
    {
        int _count = 15;
        public CustomerManager(int count)
        {
            _count = count;
        }
        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0} items ", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }

    class Product
    {
        public Product()
        {

        }
        int _id;
        string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            {
                Console.WriteLine("Logged to database");
            }
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            {
                Console.WriteLine("Logged to file");
            }
        }
    }

    class EmployeeManager
    {
        ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }
    class BaseClass
    {
        string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }
    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {

        }
        public void Add()
        {
            Console.WriteLine("Added.");
            Message();
        }
    }
    //static neslerin instance olmaz 
    static class Teacher
    {
        public static int Number { get; set; }
    }

    static class Utilities
    {
        static Utilities()
        {

        }
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }
    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }
        public void DoSomething2()
        {
            Console.WriteLine("Done2");
        }
    }

}

