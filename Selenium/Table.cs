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
    internal class Table
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/tables");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            Thread.Sleep(2000);

            //xpath of html table
            IWebElement table = driver.FindElement(By.XPath("//table[@id='table1']"));

            // Fetch all Row of the table
            List<IWebElement> tr = new List<IWebElement>(table.FindElements(By.XPath("//table[@id='table1']/tbody/tr")));
            int rowcount = tr.Count();

            //fetch no of columns
            List<IWebElement> td = new List<IWebElement>(table.FindElements(By.XPath("//table[@id='table1']/tbody/td")));
            int colcount = td.Count();


                //cell data
                IWebElement celldata = driver.FindElement(By.XPath("//table[@id='table1']/tbody/tr[2]/td[2]"));
            String text = celldata.Text;
            Console.WriteLine(text);

            Assert.AreEqual("Frank", text);


        }


        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
