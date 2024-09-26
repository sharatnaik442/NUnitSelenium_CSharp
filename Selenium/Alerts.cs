using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumTraining.Selenium
{
    internal class Alerts
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            Thread.Sleep(3000);

            IWebElement SimpleAlert = driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Alert')]"));
            SimpleAlert.Click();
            //simple alert

            // switch the control to alert or the pop up
            IAlert alt = driver.SwitchTo().Alert();

            // click on OK button

            alt.Accept();

            Thread.Sleep(3000);

            // confirmnational alert
            IWebElement ConfAlert = driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Confirm')]"));
            ConfAlert.Click();

            alt.Dismiss();

            Thread.Sleep(3000);

            // prompt alerts

            IWebElement PromptAlert = driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Prompt')]"));
            PromptAlert.Click();

            string alerttext = alt.Text;
            Console.WriteLine(alerttext);

            alt.SendKeys("Hello");
            Thread.Sleep(2000);
            alt.Accept();
            Thread.Sleep(1000);
        }    

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
