using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumTraining.Selenium
{
    internal class makemytrip
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
            driver.Navigate().GoToUrl("https://www.makemytrip.com/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            try
            {
                Thread.Sleep(3000);
                IWebElement close = driver.FindElement(By.XPath("(//span[@class='commonModal__close'])[1]"));
                close.Click();

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured" + ex.Message);

            }
            Thread.Sleep(2000);

            IWebElement Click1 = driver.FindElement(By.XPath("//label[@for='departure']"));

            Click1.Click();
            Thread.Sleep(2000);

            IWebElement Click2 = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[3]/div[4]/div[7]/div[1]"));
            Click2.Click();
            Thread.Sleep(2000);

        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
