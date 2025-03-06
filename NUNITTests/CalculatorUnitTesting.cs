using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumTraining.NUNITTests
{
    [Allure.NUnit.AllureNUnit]
    internal class CalculatorUnitTesting
    {
        calculator cl = new calculator();

        [Test]
        public void AddTest()
        {
            int result = cl.Add(2, 3);

            int result1=cl.Add(3, -4);

            //Assertion
            Assert.That(result, Is.EqualTo(5));

            Assert.That(result1, Is.EqualTo(-1));   
        }
        [Test]
        public void SubTest()
        {
            int result = cl.subtract(4, 3);

            

            //Assertion
            Assert.That(result, Is.EqualTo(1));

        }
    }
}
