using NUnitSelenium.Utilities;
using NUnitSeleniumTraining.NUNITTests;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumTraining.DataDrivenTesting
{
    class TestParLogin : Base
    {
            [TestCase("Admin", "admin123")]
            [TestCase("def.com", "gfyhjbn")]
            [TestCase("ghi.com", "gvhb")]
            public void testCaseLogin(string username, string password)
            {

                Thread.Sleep(2000);

                IWebElement UserName = driver.FindElement(By.Name("username"));
                UserName.SendKeys(username);

                IWebElement Password = driver.FindElement(By.Name("password"));
                Password.SendKeys(password);

                IWebElement LoginButton = driver.FindElement(By.XPath("//Button[@type='submit']"));
                LoginButton.Click();
            Thread.Sleep(2000);
            }
        }
    }


