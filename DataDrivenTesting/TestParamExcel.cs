using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSelenium.Utilities;
using NUnitSeleniumTraining.Utilities;
using OpenQA.Selenium;

namespace NUnitSeleniumTraining.DataDrivenTesting
{
    internal class TestParamExcel:Base
    {
        [Test, TestCaseSource(nameof(GetTestData))]
        public void LoginTest(string username, string password)
        {
            Thread.Sleep(2000);

            IWebElement UserName = driver.FindElement(By.Name("username"));
            UserName.SendKeys(username);

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys(password);

            IWebElement LoginButton = driver.FindElement(By.XPath("//Button[@type='submit']"));
            LoginButton.Click();
            Thread.Sleep(1000);

            IWebElement ErrMsg = driver.FindElement(By.XPath("//div[@class='oxd-alert-content oxd-alert-content--error']"));

            string txt = ErrMsg.Text;

            Assert.AreEqual("Invalid credentials", txt);

        }
        public static IEnumerable<TestCaseData> GetTestData()
        {
            var columns = new List<string> { "username", "password" };
            return ExcelRead.GetTestDataFromExcel("C:\\Users\\shana\\source\\repos\\NUnitSeleniumTraining\\testdata.xlsx","Sheet1",columns);
        }

    }
}