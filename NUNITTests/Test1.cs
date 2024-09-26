using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumTraining.NUNITTests
{
    [Allure.NUnit.AllureNUnit]
    internal class Test1
    {
        [Description("Testcase verifies the valid functionality with valid credentials")]
        [Test]
        public void testcase1()
        {
            Console.WriteLine("This is the first Testcase");
        }
    }
}
