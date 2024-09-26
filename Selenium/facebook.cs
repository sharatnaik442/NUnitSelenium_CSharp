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
    internal class facebook
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
            driver.Navigate().GoToUrl("https://www.facebook.com/login/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            Thread.Sleep(3000);



            new Actions(driver)
                .KeyDown(Keys.Shift)
                .SendKeys("abcd@gmail")
                .KeyUp(Keys.Shift)
                .SendKeys(".")
                .KeyDown(Keys.Shift)
                .SendKeys("com")
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
