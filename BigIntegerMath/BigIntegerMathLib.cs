
namespace BigIntegerMath
{
    using System.Numerics;
    
    public class BigIntegerMathLib
    {
        public static BigInteger Factorial1(BigInteger n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Factorial1(n - 1);
        }

        public static BigInteger Factorial2(BigInteger n)
        {
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
    }
}
