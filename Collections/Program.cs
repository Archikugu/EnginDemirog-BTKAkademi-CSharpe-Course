using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  ArrayList();
            //  List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            Console.WriteLine(dictionary["table"]);
            // Console.WriteLine(dictionary["glass"]); 
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));
            Console.WriteLine(dictionary.ContainsValue("tablo"));
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            // Console.WriteLine(cities.Contains("Ankara"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, Name = "Gokhan" });
            //customers.Add(new Customer { Id = 2, Name = "Gok" });

            List<Customer> customers = new List<Customer>
            {
               new Customer { Id= 1 ,Name="Gokhan"},
               new Customer { Id= 2 ,Name="Gok"}
            };


            var customers2 = new Customer
            {
                Id = 3,
                Name = "GOKHAN"
            };
            customers.Add(customers2);
            customers.AddRange(new Customer[2]
            {
                new Customer {Id=4,Name="Ali"},
                new Customer {Id=5,Name="Ayşe"}
            }
            );
            //Console.WriteLine(customers.Contains(new Customer { Id=1,Name="Gokhan"}));
            Console.WriteLine(customers.Contains(customers2));


            // customers.Clear();

            var index = customers.IndexOf(customers2);
            Console.WriteLine(index);

            customers.Add(customers2);
            var index2 = customers.LastIndexOf(customers2);
            Console.WriteLine(index2);


            customers.Insert(0, customers2);

            customers.Remove(customers2);
            customers.RemoveAll(c => c.Name == "GOKHAN");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
            var count = customers.Count;
            Console.WriteLine("Count : {0}", count);
        }

        private static void ArrayList()
        {

            //string[] cities = new string[2] { "Ankara", "İstanbul" };
            //cities = new string[3];
            //cities[2] = "Adana";
            //Console.WriteLine(cities[0]);

            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            cities.Add("Adana");
            cities.Add(1);
            cities.Add('A');
            Console.WriteLine(cities[2]);

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
