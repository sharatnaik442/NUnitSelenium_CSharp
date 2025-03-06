using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumTraining.Selenium
{
    internal class Myntra
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.w3schools.com/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void run()
        {
            IWebElement profile = driver.FindElement(By.Id("search2"));
            profile.SendKeys("HTML");

            IWebElement clise = driver.FindElement(By.XPath("//i[@id='learntocode_searchicon']"));
            clise.Click();

           /* IWebElement footer = driver.FindElement(By.Id("spacemyfooter"));
            int deltaY = footer.Location.Y;
            new Actions(driver)
                .ScrollByAmount(0, deltaY)
                .Perform();
*/

            IWebElement userr = driver.FindElement(By.XPath("//i[contains(text(),'')]"));
            userr.Click();

            /*IWebElement userrr = driver.FindElement(By.XPath("//span[normalize-space()='Continue']"));
            userrr.Click();

            Thread.Sleep(2000);
            IWebElement pass = driver.FindElement(By.Id("password"));
            pass.SendKeys("secret_sauce");

            Thread.Sleep(2000);
            IWebElement CC = driver.FindElement(By.Id("login-button"));
            CC.Click();*/

            Thread.Sleep(2000);

            IWebElement userrr = driver.FindElement(By.XPath("//i[contains(text(),'')]"));
            userrr.Click();
            Thread.Sleep(2000);

            IWebElement userrrr = driver.FindElement(By.XPath("//i[contains(text(),'')]"));
            userrrr.Click();
            Thread.Sleep(2000);
            IWebElement userrrrr = driver.FindElement(By.XPath("//i[contains(text(),'')]"));
            userrrrr.Click();
            Thread.Sleep(2000);
            IWebElement useerr = driver.FindElement(By.XPath("//i[contains(text(),'')]"));
            useerr.Click();
            Thread.Sleep(2000);
        }
        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
