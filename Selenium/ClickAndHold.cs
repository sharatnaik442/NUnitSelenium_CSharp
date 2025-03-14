using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumTraining.Selenium
{
    internal class ClickAndHold
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            //configure the web driver manager
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // initiialize web driver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //launch chrome browser
            driver.Navigate().GoToUrl("https://www.amazon.in/");
        }
        [Test]
        public void Run()
        {
            Thread.Sleep(3000);

            IWebElement prime = driver.FindElement(By.XPath("//span[normalize-space()='Prime']"));

            Actions actions = new Actions(driver);
            actions.MoveToElement(prime)  // Move the cursor to the 'prime' element
                   .Perform();  // Execute the action
            Thread.Sleep(2000);

            IWebElement LatestMovies = driver.FindElement(By.XPath("//img[@id='multiasins-img-link']"));
            new Actions(driver)
                .MoveToElement(LatestMovies)
                .Perform();

            // Assert.AreEqual("Prime", driver.FindElement(By.XPath("//span[normalize-space()='Prime']")).Text);

        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
