using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Edge;

namespace NUnitSeleniumTraining.Selenium
{
    internal class LaunchEdge
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            //configure the web driver manager
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            // initiialize web driver
            driver = new EdgeDriver();

        }
        [Test]
        public void Run()
        {
            //launch chrome browser
            driver.Navigate().GoToUrl("https://www.selenium.dev/downloads/");
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
