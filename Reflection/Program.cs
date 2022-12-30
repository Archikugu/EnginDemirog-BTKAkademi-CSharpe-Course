using System;
using System.Linq;
using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FourTransactions fourTransactions = new FourTransactions(2, 3);
            //Console.WriteLine(fourTransactions.Plus2());
            //Console.WriteLine(fourTransactions.Plus(3, 4));

            var type = typeof(FourTransactions);

            //FourTransactions fourTransactions = (FourTransactions)Activator.CreateInstance(type,6,7);
            //Console.WriteLine(fourTransactions.Plus(4, 5));
            //Console.WriteLine(fourTransactions.Plus2());

            var instance = Activator.CreateInstance(type, 6, 5);
            MethodInfo methodInfo = instance.GetType().GetMethod("Plus2");
            Console.WriteLine( methodInfo.Invoke(instance, null));
            
            var methods = type.GetMethods();
            Console.WriteLine("-------");
            foreach (var info in methods)
            {
                Console.WriteLine("Method Name : {0}",info.Name );
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parameters : {0}",parameterInfo.Name);
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Atrribute Name : {0}",attribute.GetType().Name);
                }
            }


        }
    }
    class FourTransactions
    {
        int _number1;
        int _number2;
        public FourTransactions()
        {

        }
        public FourTransactions(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }
        public int Plus(int number1, int number2)
        {
            return number1 + number2;
        }
        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        public int Plus2()
        {
            return _number1 + _number2;
        }
        [MethodName("Multiply")]
        public int Multiply2()
        {
            return _number1 * _number2;
        }
    }
    class MethodNameAttribute:Attribute
    {
        public MethodNameAttribute(string name)
        {
            
        }
    }

}
