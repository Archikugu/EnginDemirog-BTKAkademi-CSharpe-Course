using System;

namespace AccessModifiers
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Customer
    {
        // private int Id { get; set; }
        protected int Id { get; set; }
        public void Save()
        {

        }
        public void Delete()
        {

        }
    }
    class Student : Customer
    {
        public void Save2()
        {

        }
    }
    public class Course
    {
        public string Name { get; set; }
        private class NestedClass
        {

        }
    }

}
