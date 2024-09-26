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
    internal class Login
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            //configure the web driver manager
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // initiialize web driver
            driver = new ChromeDriver();
            //launch chrome browsers
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            Thread.Sleep(3000);

            IWebElement Username=driver.FindElement(By.Name("username"));
            Username.SendKeys("Admin");

            IWebElement Password=driver.FindElement(By.Name("password"));
            Password.SendKeys("admin123");

            IWebElement LoginButton=driver.FindElement(By.XPath("//button[@type='submit']"));
            LoginButton.Click();
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }   
    }
}
