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
    internal class MultipleCheckboxes
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

            IReadOnlyList<IWebElement> Checkboxes = driver.FindElements(By.XPath("//input[@type='checkbox']"));

            foreach (IWebElement e in Checkboxes)
            {
                Console.WriteLine(e.Text);
                e.Click();
            }

        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }

    }
}
