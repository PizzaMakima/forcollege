using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Variant1;

namespace Variant1Tests
{
    [TestClass]
    public class GeometryTests1
    {
        [TestMethod]
        public void SumOfTwoNumbersTest()
        {
            int input = 23;
            int expected = 5;

            int actual = SumOfTwoNumbers.f(input);
            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class GeometryTests2
    {
        [TestMethod]
        public void PrimeCheckerTest()
        {
            int input = 7;
            string expected = "Простое число";

            string actual = PrimeChecker.IsPrime(input);
            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class GeometryTest3
    {
        [TestMethod]
        public void InternetCostTest_NoOverusage()
        {
            int a = 500;
            int b = 1000;
            int c = 10;
            int d = 800;
            int expected = 500;

            int actual = InternetCost.CalculateInternetCost(a, b, c, d);
            Assert.AreEqual(expected, actual);
 
        }
    }
}
