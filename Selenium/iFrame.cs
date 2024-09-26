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
    internal class iFrame
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/iframe");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void copyTest()
        {
            Thread.Sleep(2000);

            IWebElement Frame1 = driver.FindElement(By.Id("mce_0_ifr"));

            driver.SwitchTo().Frame(Frame1);

            IWebElement click = driver.FindElement(By.TagName("p"));
            click.Clear();

            click.SendKeys("hello, good evening");


            Thread.Sleep(1000);




        }


        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
