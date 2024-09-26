using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumTraining.NUNITTests
{
    
    internal class Assertions
    {
        [Test]
        public void TestAssertions()
        {
            string actual = "google";
            string expected = "yahoo";

            /*if (actual != expected)
            {
                Console.WriteLine("Not matching");
            }
            else
            {
                Console.WriteLine("Matching");
            }
            */

            //assert equal
            Assert.AreEqual(actual, expected);

            Assert.AreNotEqual(actual, expected);

            Assert.AreSame(actual, expected);

            Assert.AreNotSame(actual, expected);



            // assert that
            Assert.That(actual, Is.EqualTo(expected));

            Assert.That(actual,Is.Not.EqualTo(expected));



            //assert for strings ignore case
            Assert.That(actual,Is.EqualTo(expected).IgnoreCase);



            //string presence
            Assert.That(actual,Does.Contain("def").IgnoreCase);

            Assert.That(actual, Does.Not.Contain("def").IgnoreCase);



            //empty assertions
            Assert.IsEmpty(actual);

            Assert.That(actual,Is.Empty);

            Assert.IsTrue(actual.Equals(expected));

            Assert.IsNull(actual);

            Assert.IsNotNull(actual);


            //Collection constraints
            int[] array=new int[] {1,2,3,4,5};

            //not null
            Assert.NotNull(array);


            //greater than
            Assert.That(array,Is.All.GreaterThan(0));

            //empty
            Assert.That(array, Is.Empty);

            Assert.That(array, Is.Not.Empty);
            Assert.That(array, Is.Ordered.Ascending);

            int age = 17;
            if (age <= 18)
            {
                throw new AssertionException("user is not eligible for voting");
            }
        }
    }
}
