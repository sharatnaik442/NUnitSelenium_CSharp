using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumTraining.Selenium
{
    internal class RegularExp
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            //configure the web driver manager
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // initiialize web driver
            driver = new ChromeDriver();
            //launch chrome browser
            driver.Navigate().GoToUrl("https://www.cavai.com/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            Thread.Sleep(2000);

            IWebElement starts = driver.FindElement(By.XPath("//footer[starts-with(@class,'Footer')]"));
            Assert.That(starts, Is.Not.Null);

            IWebElement contains = driver.FindElement(By.XPath("//footer[contains(@class,'Footer')]"));
            Assert.That(contains, Is.Not.Null);

        }


        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
