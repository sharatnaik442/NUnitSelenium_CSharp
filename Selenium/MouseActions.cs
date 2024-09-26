using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace NUnitSeleniumTraining.Selenium
{
    internal class MouseActions
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
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            Thread.Sleep(3000);

            IWebElement deals = driver.FindElement(By.XPath("//a[contains(text(),\"Today's Deals\")]"));

            new Actions(driver)
                .DoubleClick(deals)
                .Perform();
            Thread.Sleep(2000);
            
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
