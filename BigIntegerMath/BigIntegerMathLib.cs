
namespace BigIntegerMath
{
    using System;
    using System.Numerics;
    
    public class BigIntegerMathLib
    {
        public static int Factorial0(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Argument must be greater than or equal to 0");
            }

            if (n == 0)
            {
                return 1;
            }

            return n * Factorial0(n - 1);
        }

        public static BigInteger Factorial1(BigInteger n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Argument must be greater than or equal to 0");
            }

            if (n == 0)
            {
                return 1;
            }

            return n * Factorial1(n - 1);
        }

        public static BigInteger Factorial2(BigInteger n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Argument must be greater than or equal to 0");
            }

            BigInteger factorial = 1;

            if (n == 0)
            {
                return factorial;
            }

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }

        //----------------------------------------------------------------------------

        public static int Fibonacci0(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Argument must be greater than or equal to 0");
            }

            if (n < 2)
            {
                return n;
            }

            return Fibonacci0(n - 1) + Fibonacci0(n - 2);
        }

        public static BigInteger Fibonacci1(BigInteger n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Argument must be greater than or equal to 0");
            }

            if (n < 2)
            {
                return n;
            }

            return Fibonacci1(n - 1) + Fibonacci1(n - 2);
        }

        public static BigInteger Fibonacci2(BigInteger n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Argument must be greater than or equal to 0");
            }

            if (n < 2)
            {
                return n;
            }

            BigInteger previousFibonacci = 1;
            BigInteger previousPreviousFibonacci = 0;
            BigInteger fibonacci = 0;

            for (BigInteger i = 1; i < n ; i++)
            {
                fibonacci = previousFibonacci + previousPreviousFibonacci;
                previousPreviousFibonacci = previousFibonacci;
                previousFibonacci = fibonacci;
            }

            return fibonacci;
        }
    }
}
