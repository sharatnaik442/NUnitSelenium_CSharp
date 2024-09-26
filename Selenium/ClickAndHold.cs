using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumTraining.Selenium
{
    internal class ClickAndHold
    {
        WebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            //configure the web driver manager
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // initiialize web driver
            driver = new ChromeDriver();
            //launch chrome browser
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            Thread.Sleep(3000);

            IWebElement prime = driver.FindElement(By.XPath("//span[normalize-space()='Prime']"));

            IWebElement LatestMovies = driver.FindElement(By.XPath("//img[@id='multiasins-img-link']"));

            new Actions(driver)
                .ClickAndHold(prime)
                .MoveToElement(LatestMovies)
                .Perform();
            Thread.Sleep(2000);

           // Assert.AreEqual("Prime", driver.FindElement(By.XPath("//span[normalize-space()='Prime']")).Text);

        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
