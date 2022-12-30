using System;
using System.Collections.Generic;
using System.Threading;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            // TryCatch();

            // ActionDemo();

            Func<int, int, int> add = Plus;
            Console.WriteLine(add(3, 5));

            //  Console.WriteLine(Plus(2, 3));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            
            Console.WriteLine(getRandomNumber());
            Thread.Sleep(1000);
            Func<int>getRandomNumber2=()=>new Random().Next(1,100);
            Console.WriteLine(getRandomNumber2());
        }
        static int Plus(int x, int y)
        {
            return x + y;
        }

        private static void ActionDemo()
        {
            HandleException(() =>
            {
                CustomException();
            });
        }

        private static void TryCatch()
        {
            try
            {
                CustomException();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }
        }

        private static void CustomException()
        {
            List<string> students = new List<string> { "Engin ", "veli", "Gokhan" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found");

            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Gokhan", "Gok", "GOKHAN" };

                //System.IndexOutOfRangeException
                students[3] = "Veli";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.InnerException);
            }
        }
    }
}
