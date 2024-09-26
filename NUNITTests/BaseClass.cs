 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumTraining.NUNITTests
{

    [SetUpFixture]
    internal class BaseClass
    {
        [OneTimeSetUp]
        public void dbconnectionopen()
        {
            TestContext.Progress.WriteLine("Opening the DB connection");
        }
        [OneTimeTearDown]
        public void dbconnectionclose()
        {
            TestContext.Progress.WriteLine("Closing the DB connection");
        }
    }
}
