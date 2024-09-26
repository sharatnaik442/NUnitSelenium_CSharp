using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace NUnitSeleniumTraining.Selenium
{
    internal class DragAndDrop
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            Thread.Sleep(3000);

            IWebElement Source = driver.FindElement(By.Id("column-a"));

            IWebElement Dest = driver.FindElement(By.Id("column-b"));

            new Actions(driver)
                .DragAndDrop(Source, Dest)
                .Perform();

            Thread.Sleep(2000);
            
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
