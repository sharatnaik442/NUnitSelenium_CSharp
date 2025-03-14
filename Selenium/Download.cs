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
    internal class Download
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            Thread.Sleep(3000);

            IWebElement Download = driver.FindElement(By.LinkText("Screenshot2.png"));
            Download.Click();

            Thread.Sleep(3000);
            
            string text = Download.Text;
            Console.WriteLine(text);
            string path = "C:\\Users\\shana\\Downloads\\" + text;
            Console.WriteLine(path);
            Assert.That(File.Exists(path));
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
