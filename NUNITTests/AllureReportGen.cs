using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumTraining.NUNITTests
{
    [Allure.NUnit.AllureNUnit]
    internal class AllureReportGen
    {
        [Test, Order(1)]
        public void UserReg()
        {
            Console.WriteLine("user registraion");
        }
        [Test, Order(2)]
        public void Login()
        {
            Console.WriteLine("NUNIT");
        }
        
    }
}
