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
    internal class VerticalScrolling
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
            //scroll down
            IJavaScriptExecutor js=(IJavaScriptExecutor)driver;

            js.ExecuteScript("window.scrollBy(0, 800)", "");

            Thread.Sleep(1000);

            js.ExecuteScript("window.scrollBy(0, -300)", "");

            Thread.Sleep(1000);

            js.ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");

            Thread.Sleep(1000);



        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
