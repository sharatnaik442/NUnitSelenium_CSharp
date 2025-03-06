using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;

namespace NUnitSeleniumTraining.Parallel
{
    [TestFixture(typeof(ChromeDriver))]

    [Parallelizable(ParallelScope.Children)]
    internal class parallel<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            //if (typeof(TWebDriver) == typeof(ChromeDriver))
            //{
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                driver = new ChromeDriver();
            /*}
            else if (typeof(TWebDriver) == typeof(FirefoxDriver))
            {
                new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                driver = new FirefoxDriver();
            }
            else if (typeof(TWebDriver) == typeof(EdgeDriver))
            {
                new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                driver = new EdgeDriver();
            }*/

            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            driver.Manage().Window.Maximize();
        }

        [Test, TestCaseSource(nameof(GetTestData))]
        public void LoginTest(string username, string password)
        {
            DateTime currentTime = DateTime.Now;
            string time = currentTime.ToString("yyyy-MM-dd-_HH-mm-ss");
            Console.WriteLine(username + ":" + password + "......." + time);

            // Find the element using the By class locators 
            IWebElement Username = driver.FindElement(By.XPath("//input[@placeholder='Username']"));
            // Inputting text using send keys 
            Username.SendKeys(username);

            // Use WebDriverWait instead of Thread.Sleep
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.Name("password")));

            IWebElement Password = driver.FindElement(By.Name("password"));
            // Inputting text using send keys 
            Password.SendKeys(password);

            IWebElement LoginButton = driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
            LoginButton.Click();

            wait.Until(d => d.FindElement(By.XPath("//p[@class='oxd-text oxd-text--p oxd-alert-content-text']")));
            IWebElement Errmsg = driver.FindElement(By.XPath("//p[@class='oxd-text oxd-text--p oxd-alert-content-text']"));
            string errmsg = Errmsg.Text;

            Console.WriteLine(errmsg);

            Assert.That(errmsg, Is.EqualTo("Invalid credentials"));
        }

        [TearDown]
        public void TearDown()
        {
            driver?.Close();
        }

        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData("abc.com", "ghhjj");
            yield return new TestCaseData("ghh.com", "fghhj");
            yield return new TestCaseData("mkk.com", "ddffg");
        }
    }
}