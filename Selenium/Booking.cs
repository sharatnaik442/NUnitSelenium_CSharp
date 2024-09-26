using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;

namespace NUnitSeleniumTraining.Selenium
{
    internal class Booking
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
            driver.Navigate().GoToUrl("https://www.booking.com/index.en-gb.html?aid=2369661&pagename=en-in-booking-desktop&label=msn-HiTydpHndf_KligNqm9Sgw-79852220055838:tikwd-79852393960302:loc-90:neo:mte:lp116072:dec:qsBooking.com)&utm_campaign=English_India%20EN%20IN&utm_medium=cpc&utm_source=bing&utm_term=HiTydpHndf_KligNqm9Sgw&msclkid=576d951af0441a9cdb5bf3f79ce6dbdd&utm_content=Booking%20-%20Desktop");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void SearchFunctionality()
        {
            Thread.Sleep(2000);

            
            

            IWebElement location = driver.FindElement(By.Name("ss"));
            location.SendKeys("Goa, India");
            IWebElement checkin = driver.FindElement(By.XPath("(//span[normalize-space()='Check-in date'])[1]"));
            checkin.Click();
            IWebElement flexible = driver.FindElement(By.XPath("(//span[@class='ac2e4f2389'])[1]"));
            flexible.Click();
            IWebElement weekend = driver.FindElement(By.XPath("(//span[@class='c907c67d20'])[1]"));
            weekend.Click();
            IWebElement month = driver.FindElement(By.XPath("(//div[@class='bb227126eb'])[4]"));
            month.Click();
            IWebElement guest = driver.FindElement(By.XPath("(//span[@class='a8887b152e c7ce171153'])[1]"));
            guest.Click();
            IWebElement Dropdown = driver.FindElement(By.XPath("(//select[@id=':r4l:'])[1]"));
            Assert.IsNotNull(Dropdown);

            var select = new SelectElement(Dropdown);

            //select by visible text    
            select.SelectByText("10 years old");

            IWebElement done = driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[2]/div[1]/form[1]/div[1]/div[3]/div[1]/div[1]/div[1]/button[1]"));
            done.Click();

            IWebElement search = driver.FindElement(By.XPath("(//span[normalize-space()='Search'])[1]"));
            search.Click();
            



        }


        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
