using System;

namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[] { new SqlServerCustomerDal(), new OracleServerCustomerDal(),new MySqlServerCustomerDal() };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
           
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "Gokhan",
                LastName = "Gok",
                Adress = "Ankara"
            };
            personManager.Add(customer);
            Student student = new Student()
            {
                Id = 2,
                FirstName = "Gokhan",
                LastName = "Gok",
                Departmant = "Computer Engineering"
            };
            personManager.Add(student);
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Adress { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
