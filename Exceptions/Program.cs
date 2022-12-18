using System;
using System.Collections.Generic;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            try
            {
                CustomException();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }


            HandleException(() =>
            {
                CustomException();
            });




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
