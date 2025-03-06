using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumTraining.NUNITTests
{
    [Allure.NUnit.AllureNUnit]
    internal class FactorialUnitTest
    {
        Factorial f = new Factorial();

        [Test]
        public void FactorialTest()
        {
            int result = f.Fact(4);

            Assert.That(result, Is.EqualTo(24));
        }
    }
}
