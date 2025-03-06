using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using AngleSharp;
using System.Configuration;

namespace NUnitSelenium.Utilities
{
    public class Base
    {
        protected IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            string browserName = ConfigurationManager.AppSettings["browser"];
            driver = InitBrowser(browserName); // Change this to return the driver
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        public IWebDriver InitBrowser(string browserName) // Change return type to IWebDriver
        {
            switch (browserName)
            {
                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    return new FirefoxDriver();
                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    return new EdgeDriver();
                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    return new ChromeDriver();
                default:
                    throw new ArgumentException("Browser not supported");
            }
        }

        [TearDown]
        public void tearDownBrowser()
        {
            driver?.Close(); // Ensure driver is not null before closing
        }
    }
}