using NUnit.Framework;
using Raindrops;

namespace RaindropsTest
{
    public class Method1Tests
    {
        [TestCase(28, "Plong")]
        [TestCase(30, "PlingPlang")]
        [TestCase(34, "34")]
        public void Method1_PositiveIntegers(int n, string expectedResult)
        {
            var result = RaindropsMethods.Method1(n);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}