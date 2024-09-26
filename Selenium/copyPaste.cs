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
    internal class copyPaste
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
            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/single_text_input.html");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void copyTest()
        {
            Thread.Sleep(2000);

           new Actions(driver)
               .KeyDown(Keys.Control)
               .SendKeys("c")
               .KeyUp(Keys.Control)
               .Perform();

           
            Thread.Sleep(1000);

            
            

        }
        

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
