using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.Buildlist<string>("Ankara", "İzmir", "Adana");
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
            List<Customer> result2 = utilities.Buildlist<Customer>(new Customer { FirstName = "Gokhan" });
            foreach (Customer customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }
        }
    }
    class Utilities
    {
        public List<T> Buildlist<T>(params T[] items)
        {
            return new List<T>(items);
        }

    }
    class Product : IEntity
    {

    }
    interface IProductDal : IRepository<Product>
    {
        List<Product> GetAll();
        Product Get(int id);
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
    }
    class Customer : IEntity
    {
        public string FirstName { get; set; }
    }
    interface ICustomerDal : IRepository<Customer>
    {
        void Custom();
    }
    class Student : IEntity
    {

    }
    interface IEntity
    {

    }
    interface IStudentDal : IRepository<Student>
    {

    }
    // value type = interface IRepository<T> where T : struct
    interface IRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    class ProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Custom()
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
