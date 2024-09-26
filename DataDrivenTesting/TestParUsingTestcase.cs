using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumTraining.DataDrivenTesting
{
    internal class TestParUsingTestcase
    {
        [Test]
        [TestCase("abc.com","ssajh")]
        [TestCase("def.com", "jkanc")]
        [TestCase("ghi.com", "zkjzxk")]

        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username+" : "+password);
        }
    }
}
