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
    internal class Frameseg
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
            driver.Navigate().GoToUrl("https://jqueryui.com/checkboxradio/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            IWebElement Frame1 = driver.FindElement(By.XPath("//iframe[@class='demo-frame']"));

            //select frame using xpath
            driver.SwitchTo().Frame(Frame1);

            Thread.Sleep(2000);

            //select frame using index
           // driver.SwitchTo().Frame(1);

            IWebElement radio = driver.FindElement(By.XPath("(//span[@class='ui-checkboxradio-icon ui-corner-all ui-icon ui-icon-background ui-icon-blank'])[1]"));
            radio.Click();

            Thread.Sleep(2000);

        }
        

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
