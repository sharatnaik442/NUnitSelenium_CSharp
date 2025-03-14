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
    internal class FileUpload
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/upload");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            Thread.Sleep(3000);

            IWebElement ChooseFile = driver.FindElement(By.XPath("//input[@id='file-upload']"));
            ChooseFile.SendKeys("C:\\Users\\shana\\Downloads\\shana_Sharat_Naik.jpeg");//give the path of the file here


            IWebElement Upload = driver.FindElement(By.XPath("//input[@id='file-submit']"));
            Upload.Click();

            Thread.Sleep(1000);

            IWebElement FileUploadMsg = driver.FindElement(By.XPath("//h3[contains(text(),'File Uploaded!')]"));

            string textmsg = FileUploadMsg.Text;

            string expectedtext = "File Uploaded!";

            Console.WriteLine(textmsg);

            Assert.That(textmsg, Is.EqualTo(expectedtext));
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
