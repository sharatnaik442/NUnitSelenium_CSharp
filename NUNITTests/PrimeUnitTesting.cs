using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumTraining.NUNITTests
{
    [Allure.NUnit.AllureNUnit]
    internal class PrimeUnitTesting
    {
        PrimeNumber prime=new PrimeNumber();

        [Test]
        public void IsPrimeTest()
        {
            bool result = prime.IsPrime(3);
            bool result1= prime.IsPrime(4);

            Assert.AreEqual(true,result);
            Assert.AreEqual(false,result1);
        }
    }
}
