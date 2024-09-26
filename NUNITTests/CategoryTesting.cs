using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumTraining.NUNITTests
{
    [Allure.NUnit.AllureNUnit]
    internal class CategoryTesting
    {
        [Test, Category("Regression")]
        public void login()
        {
            Console.WriteLine("logging into applicaton");
        }
        [Test, Category("Sanity")]
        public void products()
        {
            Console.WriteLine("Selecting the products");
        }
        [Test, Ignore("Defect ID #6565")]
        public void addtocart()
        {
            Console.WriteLine("Products added to the cart");
        }
    }
}
