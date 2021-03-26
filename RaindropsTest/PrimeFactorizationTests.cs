using NUnit.Framework;
using Raindrops;

namespace RaindropsTest
{
    public class PrimeFactorizationTests
    {
        [TestCase(9, "Pling")]
        [TestCase(10, "Plang")]
        [TestCase(28, "Plong")]
        [TestCase(21, "PlingPlong")]
        [TestCase(30, "PlingPlang")]
        [TestCase(35, "PlangPlong")]
        [TestCase(105, "PlingPlangPlong")]
        [TestCase(1, "1")]
        [TestCase(34, "34")]
        [TestCase(101, "101")]
        public void PrimeFactorizationMethod_PositiveIntegers(int n, string expectedResult)
        {
            var result = RaindropsMethods.PrimeFactorizationMethod(n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(-9, "Pling")]
        [TestCase(-10, "Plang")]
        [TestCase(-28, "Plong")]
        [TestCase(-21, "PlingPlong")]
        [TestCase(-30, "PlingPlang")]
        [TestCase(-35, "PlangPlong")]
        [TestCase(-105, "PlingPlangPlong")]
        [TestCase(-1, "-1")]
        [TestCase(-34, "-34")]
        [TestCase(-101, "-101")]
        public void PrimeFactorizationMethod_NegativeIntegers(int n, string expectedResult)
        {
            var result = RaindropsMethods.PrimeFactorizationMethod(n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(0, "0")]
        public void PrimeFactorizationMethod_Zero(int n, string expectedResult)
        {
            var result = RaindropsMethods.PrimeFactorizationMethod(n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(1, "1")]
        [TestCase(-1, "-1")]
        public void PrimeFactorizationMethod_Ones(int n, string expectedResult)
        {
            var result = RaindropsMethods.NormalMethod(n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

    }
}