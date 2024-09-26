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
    internal class WindowHandling
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
            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/window_switching_tests/page_with_frame.html");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            Thread.Sleep(2000);
            
            //fetch the handle of current page
            string curHandle=driver.CurrentWindowHandle;
            Assert.IsNotNull(curHandle);

            //click on the link tp open new window
            IWebElement open = driver.FindElement(By.XPath("//a[@id='a-link-that-opens-a-new-window']"));
            open.Click();

            //fetch the windpw handles of all windows there will be two windows opened
            IList<string> windowHandles=new List<string>(driver.WindowHandles);

            //the control is moved to child window  
            driver.SwitchTo().Window(windowHandles[1]);

            Thread.Sleep(1000);
            string title = driver.Title;
            Console.WriteLine(title);

            Assert.AreEqual("Simple Page", title);

            //closing child window
            driver.Close();
            Thread.Sleep(1000);
            driver.SwitchTo().Window(windowHandles[0]);

            string title1 = driver.Title;
            Console.WriteLine(title1);
            Thread.Sleep(1000);
            Assert.AreEqual("Test page for WindowSwitchingTest.testShouldFocusOnTheTopMostFrameAfterSwitchingToAWindow", title1);

        }


        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }

    }
}
