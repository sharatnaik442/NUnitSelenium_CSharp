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
    internal class Exercise1
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
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/register");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            Thread.Sleep(3000);

            IWebElement Gender = driver.FindElement(By.Id("gender-male"));
            Gender.Click();

            IWebElement FirstName = driver.FindElement(By.Id("FirstName"));
            FirstName.SendKeys("Roronova");

            IWebElement LastName = driver.FindElement(By.Name("LastName"));
            LastName.SendKeys("Zoro");

            IWebElement Email = driver.FindElement(By.Name("Email"));
            Email.SendKeys("zoro@gmail.com");

            IWebElement Password = driver.FindElement(By.Name("Password"));
            Password.SendKeys("zoro12345");

            IWebElement Confirm = driver.FindElement(By.Name("ConfirmPassword"));
            Confirm.SendKeys("zoro12345");

            Thread.Sleep(1000);

            IWebElement RegisterButton = driver.FindElement(By.Id("register-button"));
            RegisterButton.Click();
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
