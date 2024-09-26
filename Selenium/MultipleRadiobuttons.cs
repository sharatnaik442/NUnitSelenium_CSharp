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
    internal class MultipleRadiobuttons
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

            IReadOnlyList<IWebElement> Radiobuttons = driver.FindElements(By.XPath("//input[@type='radio']"));

            foreach (IWebElement e in Radiobuttons)
            {
                Console.WriteLine(e.Text);
                Thread.Sleep(1000);
                e.Click();
            }
            Thread.Sleep(1000);
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
