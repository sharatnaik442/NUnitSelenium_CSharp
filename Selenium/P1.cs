using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumTraining.Selenium
{
    internal class P1
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void run()
        {
            IWebElement userr = driver.FindElement(By.Id("user-name"));
            userr.SendKeys("standard_user");

            Thread.Sleep(2000);
            IWebElement pass = driver.FindElement(By.Id("password"));
            pass.SendKeys("secret_sauce");

            Thread.Sleep(2000);
            IWebElement CC = driver.FindElement(By.Id("login-button"));
            CC.Click();

            Thread.Sleep(2000);
            /*var scrollOrigin = new WheelInputDevice.ScrollOrigin
            {
                Viewport = true,
                XOffset = 10,
                YOffset = 10
            };
            new Actions(driver)
                .ScrollFromOrigin(scrollOrigin, 0, 200)
                .Perform();*/

            /* IWebElement iframe = driver.FindElement(By.TagName("iframe"));
             new Actions(driver)
                 .ScrollToElement(iframe)
                 .Perform();*/
            IWebElement footer = driver.FindElement(By.TagName("footer"));
            int deltaY = footer.Location.Y;
            new Actions(driver)
                .ScrollByAmount(0, deltaY)
                .Perform();

            Thread.Sleep(2000);

        }
        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
