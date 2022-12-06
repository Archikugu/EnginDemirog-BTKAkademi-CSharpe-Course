using System;
using System.Linq;

namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            //DRY - Don't Repeat Yourself !

            Add();
            Add();

            Console.WriteLine("---Parametreli---");
            var result = Add2(4, 5);
            Console.WriteLine(result);

            Console.WriteLine("---Default Parametreli");
            var result2 = Add3(4);
            Console.WriteLine(result2);

            Console.WriteLine("---Challenge Ref Keyword---");
            int number1 = 20;
            int number2 = 100;
            var result3 = Add4(ref number1, number2);
            Console.WriteLine(number1);
            Console.WriteLine(result3);

            Console.WriteLine("---Challenge Out Keyword---");
            int number3;
            int number4 = 100;
            var result4 = Add5(out number3, number4);
            Console.WriteLine(number1);
            Console.WriteLine(result3);

            Console.WriteLine("---Method Overloading---");
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));

            Console.WriteLine("---Challenge Params Keyword---");
            Console.WriteLine(Add6(1,2,3,4,5,6));

        }
        static void Add()
        {
            Console.WriteLine("Added !!!");
        }
        //Parametreli Method
        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }
        //Default Parametreli Method
        static int Add3(int number1, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }
        //Ref
        static int Add4(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        //Out
        static int Add5(out int number3, int number4)
        {
            number3 = 30;
            return number3 + number4;
        }
        //Method overloading
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        //Challenge Params Keyword

        static int Add6(params int[] numbers)
        {
            return numbers.Sum();
        }
       
    }
}
