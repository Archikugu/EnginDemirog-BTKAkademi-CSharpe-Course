using System;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Customer { FirstName = "Gokhan" },
                new Student { FirstName = "Gok" } ,
                new Person{FirstName="GOKHAN"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Deparmant { get; set; }
    }
}
