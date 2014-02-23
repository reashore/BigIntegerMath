
namespace BigIntegerMath.Console
{
    using System;
    using System.IO;
    using System.Numerics;

    class Program
    {
        static void Main()
        {
            BigInteger factorial1000 = BigIntegerMathLib.Factorial2(1000);
            BigInteger fibonacci1000 = BigIntegerMathLib.Fibonacci2(1000);

            string message1 = string.Format("Factorial(1000) = {0}", factorial1000);
            Console.WriteLine(message1);

            string message2 = string.Format("Fibonacci(1000) = {0}", fibonacci1000);
            Console.WriteLine(message2);

            const string file = "FactorialAndFibonacci.txt";
            string contents = string.Format("{0}\r\n\r\n{1}", message1, message2);
            File.WriteAllText(file, contents);

            Console.ReadKey();
        }
    }
}
