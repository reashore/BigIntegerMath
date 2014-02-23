
using System.Diagnostics;

namespace BigIntegerMath.Test
{
    using System;
    using NUnit.Framework;
    using System.Numerics;
    using BigIntegerMath;

    [TestFixture]
    public class FactorialTests
    {
        [Test]
        public void TestFactorialBigIntegerEqualsFactorialInt()
        {
            for (int n = 0; n < 10; n++)
            {
                // act
                int factorial0 = BigIntegerMathLib.Factorial0(n);
                BigInteger factorial1 = BigIntegerMathLib.Factorial1(n);

                // assert
                Assert.AreEqual((BigInteger)factorial0, factorial1);
                Assert.AreEqual(factorial0, (int)factorial1);
            }
        }

        [Test]
        public void TestBothVersionsOfFactorialAreEqual()
        {
            for (BigInteger n = 0; n < 100; n++)
            {
                // act
                BigInteger factorial1 = BigIntegerMathLib.Factorial1(n);
                BigInteger factorial2 = BigIntegerMathLib.Factorial2(n);

                // assert
                Assert.AreEqual(factorial1, factorial2);
            }
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFactorial0OfNegativeNumberThrowsArgumentException()
        {
            // act
            int result = BigIntegerMathLib.Factorial0(-1);

            // assert
            // ArgumentException thrown
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFactorial1OfNegativeNumberThrowsArgumentException()
        {
            // act
            BigInteger result = BigIntegerMathLib.Factorial1(-1);

            // assert
            // ArgumentException thrown
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFactorial2OfNegativeNumberThrowsArgumentException()
        {
            // act
            BigInteger result = BigIntegerMathLib.Factorial2(-1);

            // assert
            // ArgumentException thrown
        }

        [Test]
        public void TestFactorialOfZeroIsOne()
        {
            // act
            BigInteger result1 = BigIntegerMathLib.Factorial1(0);
            BigInteger result2 = BigIntegerMathLib.Factorial2(0);

            // assert
            BigInteger one = 1;
            Assert.AreEqual(one, result1);
            Assert.AreEqual(one, result2);
        }

        [Test]
        public void TestFactorialOfOneIsOne()
        {
            // act
            BigInteger result1 = BigIntegerMathLib.Factorial1(1);
            BigInteger result2 = BigIntegerMathLib.Factorial2(1);

            // assert
            BigInteger one = 1;
            Assert.AreEqual(one, result1);
            Assert.AreEqual(one, result2);
        }
    }

    [TestFixture]
    public class FibonacciTests
    {
        [Test]
        public void TestFibonacciBigIntegerEqualsFibonacciInt()
        {
            for (int n = 0; n < 10; n++)
            {
                // arrange
                int fibonacci0 = BigIntegerMathLib.Fibonacci0(n);
                BigInteger fibonacci1 = BigIntegerMathLib.Fibonacci1(n);

                // assert
                Assert.AreEqual((BigInteger)fibonacci0, fibonacci1);
            }
        }
        
        [Test]
        public void TestBothVersionsOfFibonacciAreEqual()
        {
            for (BigInteger n = 0; n < 10; n++)
            {
                // arrange
                BigInteger fibonacci1 = BigIntegerMathLib.Fibonacci1(n);
                BigInteger fibonacci2 = BigIntegerMathLib.Fibonacci2(n);

                // assert
                Assert.AreEqual(fibonacci1, fibonacci2);
            }
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFibonacci1OfNegativeNumberThrowsArgumentException()
        {
            // act
            int result = BigIntegerMathLib.Fibonacci0(-1);

            // assert
            // ArgumentException thrown
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFibonacci11OfNegativeNumberThrowsArgumentException()
        {
            // act
            BigInteger result = BigIntegerMathLib.Fibonacci1(-1);

            // assert
            // ArgumentException thrown
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFibonacci2OfNegativeNumberThrowsArgumentException()
        {
            // act
            BigInteger result = BigIntegerMathLib.Fibonacci2(-1);

            // assert
            // ArgumentException thrown
        }

        [Test]
        public void TestFibonacciOfZeroIsZero()
        {
            // act
            BigInteger result1 = BigIntegerMathLib.Fibonacci1(0);
            BigInteger result2 = BigIntegerMathLib.Fibonacci2(0);

            // assert
            BigInteger zero = 0;
            Assert.AreEqual(zero, result1);
            Assert.AreEqual(zero, result2);
        }

        [Test]
        public void TestFibonacciOfOneIsOne()
        {
            // act
            BigInteger result1 = BigIntegerMathLib.Fibonacci1(1);
            BigInteger result2 = BigIntegerMathLib.Fibonacci2(1);

            // assert
            BigInteger one = 1;
            Assert.AreEqual(one, result1);
            Assert.AreEqual(one, result2);
        }


        //[Test]
        [Conditional("DEBUG")]
        public void DebugFibonacci()
        {
            for (int n = 0; n < 10; n++)
            {
                BigInteger result0 = BigIntegerMathLib.Fibonacci0(n);
                BigInteger result1 = BigIntegerMathLib.Fibonacci1(n);
                BigInteger result2 = BigIntegerMathLib.Fibonacci2(n);

                string message = string.Format("{0},  {1},  {2},  {3}", n, result0, result1, result2);
                Debug.WriteLine(message);
            }
        }

    }
}
