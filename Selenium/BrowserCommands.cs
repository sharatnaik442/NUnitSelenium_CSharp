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
    internal class BrowserCommands
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            //configure the web driver manager
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // initiialize web driver
            driver = new ChromeDriver();

        }
        [Test]
        public void Run()
        {
            //launch chrome browser
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            //get the title of the page
            string title=driver.Title;
            Console.WriteLine(title);

            //get current url
            string CurrentUrl=driver.Url;
            Console.WriteLine(CurrentUrl);    
            
            //get page source of html page
            string PageSource=driver.PageSource;
            Console.WriteLine(PageSource);
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
