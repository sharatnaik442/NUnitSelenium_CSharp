using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumTraining.NUNITTests
{
    [Allure.NUnit.AllureNUnit]
    internal class SetUpTearDown
    {
        [SetUp]
        public void setup()
        {
            Console.WriteLine("Launching browser");
        }

        [TearDown]
        public void teardown()
        {
            Console.WriteLine("Closing browser");
        }




        [Test, Order(1)]
        public void login()
        {
            Console.WriteLine("logging into applicaton");
        }
        [Test, Order(2)]
        public void products()
        {
            Console.WriteLine("Selecting the products");
        }
        [Test, Order(3)]
        public void addtocart()
        {
            Console.WriteLine("Products added to the cart");
        }
    }
}
