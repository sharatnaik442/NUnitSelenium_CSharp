using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;

namespace NUnitSeleniumTraining.Selenium
{
    internal class Dropdown
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
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            Thread.Sleep(3000);

            IWebElement Dropdown= driver.FindElement(By.Id("dropdown-class-example"));
            Assert.That(Dropdown.Displayed, Is.True);

            var select = new SelectElement(Dropdown);

            //select by visible text    
            select.SelectByText("Option2");

            Thread.Sleep(1000);

            //select by index select option1
            select.SelectByIndex(1);

            Thread.Sleep(1000);
            //select by attribute value
            select.SelectByValue("option3");

            Thread.Sleep(2000);
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
