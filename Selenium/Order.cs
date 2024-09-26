using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework;
using System.Xml.Linq;

namespace NUnitSeleniumTraining.Selenium
{
    internal class Order
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
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            Thread.Sleep(3000);

            IWebElement Username = driver.FindElement(By.Name("user-name"));
            Username.SendKeys("standard_user");

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys("secret_sauce");

            Thread.Sleep(1000);

            IWebElement LoginButton = driver.FindElement(By.Id("login-button"));
            LoginButton.Click();
            Thread.Sleep(1000);

            IWebElement addButton = driver.FindElement(By.XPath("(//button[@id='add-to-cart-sauce-labs-backpack'])[1]"));
            addButton.Click();
            Thread.Sleep(1000);

            IWebElement cart = driver.FindElement(By.XPath("(//a[@class='shopping_cart_link'])[1]"));
            cart.Click();
            Thread.Sleep(1000);

            IWebElement checkout = driver.FindElement(By.XPath("(//button[normalize-space()='Checkout'])[1]"));
            checkout.Click();
            Thread.Sleep(1000);

            IWebElement firstname = driver.FindElement(By.Id("first-name"));
            firstname.SendKeys("vinsmoke");
            Thread.Sleep(1000);

            IWebElement lastname = driver.FindElement(By.Id("last-name"));
            lastname.SendKeys("Sanji");
            Thread.Sleep(1000);

            IWebElement postal = driver.FindElement(By.Id("postal-code"));
            postal.SendKeys("287221");
            Thread.Sleep(1000);

            IWebElement continueButton = driver.FindElement(By.Id("continue"));
            continueButton.Click();
            Thread.Sleep(1000);

            IWebElement finishButton = driver.FindElement(By.Id("finish"));
            finishButton.Click();
            Thread.Sleep(1000);

            IWebElement thankYouText = driver.FindElement(By.ClassName("complete-header"));
            string got = thankYouText.Text;
            string expected = "Thank you for your order!";
            Assert.That(got, Is.EqualTo(expected));


        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
