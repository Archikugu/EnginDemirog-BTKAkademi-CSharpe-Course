using System;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.CustomerId = 1;
            customer.FirstName = "Gokhan";
            customer.LastName = "Gok";
            customer.City = "Ankara";

            Customer customer2 = new Customer { CustomerId = 2, FirstName = "Gokhan", LastName = "Gok", City = "Istanbul" };

          
            Console.WriteLine(customer2.FirstName);

        }
    }
}
