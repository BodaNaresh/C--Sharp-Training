using FactorialandPrimewithUTs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactanPrimeTest
{
    [TestClass]
    public class PrimenFactTest
    {
        [TestMethod]
        public void FactTest()
        {
            int n = 4;
            Factorial fa = new Factorial();
            int actual = fa.fact(n);

            Assert.AreEqual(actual, 24);
        }

        [TestMethod]
        public void FactTestwithzero()
        {
            int n = 0;
            Factorial fa = new Factorial();
            int actual = fa.fact(n);

            Assert.AreEqual(1, actual);
        }
        [TestMethod]
        public void FactTestwithnegativevalue()
        {
            int num = -2;
            Factorial fa = new Factorial();
            PrimeNumber pr = new PrimeNumber();
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => pr.IsPrimeNumber(num));
        }

        [TestMethod]
        public void PrimeNumberTest()
        {
            int num = 19;
            PrimeNumber pr = new PrimeNumber();
            bool actual = pr.IsPrimeNumber(num);

            bool expected = true;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Testr_Notprime()
        {
            int n = 10;
            PrimeNumber pr = new PrimeNumber();
            bool actual = pr.IsPrimeNumber(n);

            bool expected = false;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void primewithnegativenumexception()
        {
            int num = -1;
            PrimeNumber pr = new PrimeNumber();
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => pr.IsPrimeNumber(num));
        }

    }
}
