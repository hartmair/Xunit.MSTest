using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            // see https://stackoverflow.com/a/15743238/1220972
            if (candidate <= 1) return false;
            if (candidate == 2) return true;
            if (candidate % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(candidate));
            for (int i = 3; i <= boundary; i += 2)
                if (candidate % i == 0)
                    return false;

            return true;
        }
    }

    // see https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest
    [TestClass]
    public class SampleTest
    {
        private readonly PrimeService _primeService;

        public SampleTest()
        {
            _primeService = new PrimeService();
        }

        [TestMethod]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.IsFalse(result, $"{value} should not be prime");
        }
    }
}