using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumTraining.DataDrivenTesting
{
    internal class TestParUsingTestcaseSource
    {
        [Test, TestCaseSource("GetTestData")]
        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username + " : " + password);

        }
        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData("Admin", "admin123");
            yield return new TestCaseData("def.com", "gfyhjbn");
            yield return new TestCaseData("ghi.com", "gvhb");
           
        }
    }
}
