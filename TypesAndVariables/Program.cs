using System;

namespace TypesAndVariables
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            byte number1 = 255;
            short number2 = -32768;
            int number3 = 2147483647;
            long number4 = -9223372036854775808;
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);

            bool condition = true;

            char character = 'A';
            Console.WriteLine("Character is :{0}", (int)character);

            double number5 = 10.4;
            Console.WriteLine("Number5 is {0}", number5);

            decimal number6 = 10.4m;
            Console.WriteLine("Number6 is {0}", number6);

            Console.WriteLine((int)Days.Friday);

            var number7 = 10;
            number7 = 'A';
            Console.WriteLine("Number7 is {0}", number7);
        }
    }
    enum Days
    {
        Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
