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
    internal class Exercise2
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
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            Thread.Sleep(3000);

            IWebElement Username = driver.FindElement(By.Name("user-name"));
            Username.SendKeys("standard_user");

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys("secret_sauce");

            Thread.Sleep(1000);

            IWebElement LoginButton = driver.FindElement(By.Id("login-button"));
            LoginButton.Click();
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
