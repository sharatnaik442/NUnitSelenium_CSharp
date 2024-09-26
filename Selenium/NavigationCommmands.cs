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
    internal class NavigationCommmands
    {
        WebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            //configure the web driver manager
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // initiialize web driver
            driver = new ChromeDriver();

        }
        [Test]
        public void TestCase1()
        {
            //launch chrome browser
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            driver.Manage().Window.Maximize();

            Thread.Sleep(2000);
            driver.Navigate().Back();

            Thread.Sleep(2000);
            driver.Navigate().Forward();

            Thread.Sleep(2000);
            driver.Navigate().Refresh();
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
