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
    internal class WindowHandling2
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            //fetch the handle of current page
            string curHandle = driver.CurrentWindowHandle;
            Assert.IsNotNull(curHandle);

            //click on the link tp open new window
            IWebElement open = driver.FindElement(By.LinkText("Click Here"));
            open.Click();

            //fetch the windpw handles of all windows there will be two windows opened
            IList<string> windowHandles = new List<string>(driver.WindowHandles);

            //the control is moved to child window  
            driver.SwitchTo().Window(windowHandles[1]);

            Thread.Sleep(1000);
            string title = driver.Title;
            Console.WriteLine(title);

            Assert.AreEqual("New Window", title);

            //closing child window
            driver.Close();
            Thread.Sleep(1000);
            driver.SwitchTo().Window(windowHandles[0]);

            string title1 = driver.Title;
            Console.WriteLine(title1);
            Thread.Sleep(1000);
            Assert.AreEqual("The Internet", title1);

        }


        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }

    }
}

