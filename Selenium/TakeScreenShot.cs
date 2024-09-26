using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.Extensions;

namespace NUnitSeleniumTraining.Selenium
{
    internal class TakeScreenShot
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
            driver.Navigate().GoToUrl("https://www.selenium.dev/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            Screenshot ss=driver.TakeScreenshot();

            ss.SaveAsFile("C:\\Users\\shana\\source\\repos\\NUnitSeleniumTraining\\Screenshot\\err.jpeg");
            Thread.Sleep(1000);

        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
