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
    internal class Table2
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
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            Thread.Sleep(2000);

            //xpath of html table
            IWebElement table = driver.FindElement(By.XPath("//table[@id='product' and @name='courses']"));

            // Fetch all Row of the table
            List<IWebElement> tr = new List<IWebElement>(table.FindElements(By.XPath("/html/body/div[3]/div[1]/fieldset/table/tbody/tr[8]/td[2]")));
            int rowcount = tr.Count();
            Console.WriteLine(tr[0].Text);

            //fetch no of columns
            //List<IWebElement> td = new List<IWebElement>(table.FindElements(By.Name("//table[@name='courses']/tbody/tr/td")));
            //int colcount = td.Count();

            //cell data
            //IWebElement celldata = driver.FindElement(By.Name("//table[@name='courses']/tbody/tr[8]/td[2]"));
            //String text = celldata.Text;
            //Console.WriteLine(text);

            //Assert.AreEqual("QA Expert Course :Software Testing + Bugzilla + SQL + Agile", text);


        }


        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
