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
    internal class Locators
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
            driver.Navigate().GoToUrl("https://automationexercise.com/contact_us");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void TestCase1()
        {
            Thread.Sleep(3000);

            IWebElement Name = driver.FindElement(By.Name("name"));
            Name.SendKeys("Admin");

            Thread.Sleep(1000);

            IWebElement Email = driver.FindElement(By.Name("email"));
            Email.SendKeys("admin123@gmail.com");

            IWebElement Subject = driver.FindElement(By.Name("subject"));
            Subject.SendKeys("Server issue");

            IWebElement Message = driver.FindElement(By.Id("message"));
            Message.SendKeys("I am facing server down issue");

            Thread.Sleep(1000);

            IWebElement SubmitButton = driver.FindElement(By.Name("submit"));
            SubmitButton.Click();

        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
