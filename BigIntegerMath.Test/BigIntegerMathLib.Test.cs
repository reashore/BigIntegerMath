
namespace BigIntegerMath.Test
{
    using NUnit.Framework;
    using System.Numerics;
    using BigIntegerMath;

    [TestFixture]
    public class BigIntegerMathLib
    {
        //private BigIntegerMathLib _bigIntegerMathLib;

        //[SetUp]
        //public void TestSetup()
        //{
        //    _bigIntegerMathLib = new BigIntegerMathLib();
        //}

        [Test]
        public void TestBothVersionsOfFactorialAreEqual()
        {
            for (BigInteger n = 0; n < 100; n++)
            {
                // arrange
                BigInteger factorial1 = BigIntegerMath.BigIntegerMathLib.Factorial1(n);
                BigInteger factorial2 = BigIntegerMath.BigIntegerMathLib.Factorial2(n);

                // assert
                Assert.AreEqual(factorial1, factorial2);
            }
        }
    }
}
