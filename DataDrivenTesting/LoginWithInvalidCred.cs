using NUnitSelenium.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumTraining.DataDrivenTesting
{
    internal class LoginWithInvalidCred:Base
    {
        [TestCase("invalid", "admin123")]

        public void testCaseLogin(string username, string password)
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
            
            string txt= ErrMsg.Text;

            Assert.AreEqual("Invalid credentials", txt);
            

        }
    }
}
