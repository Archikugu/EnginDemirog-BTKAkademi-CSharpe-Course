using System;

namespace Loops
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();

            //WhileLoop();

            //DoWhileLoop();

            //ForeachLoop();

            if (IsPrimeNumber(4))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }

        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0 &&number >=2)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }

        private static void ForeachLoop()
        {
            //Foreach Loop

            string[] students = new string[] { "Gokhan", "Ali", "Veli" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            //Do-While Loop

            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }

        private static void WhileLoop()
        {
            //While Loop
            int number = 100;
            while (number > 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
        }

        private static void ForLoop()
        {
            //For Loop

            for (int i = 2; i <= 100; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished !");
            for (int i = 100; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished !");
        }
    }
}
