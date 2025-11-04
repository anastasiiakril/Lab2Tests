using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestProject1
{
    [TestClass]
    public class Test1
    {

        private IWebDriver driver;

        [TestInitialize]
        public void SetUp()
        {
            var options = new ChromeOptions();
            options.BinaryLocation = @"C:\Users\ANASTASIJA\Downloads\chrome-win64\chrome-win64\chrome.exe";

            var service = ChromeDriverService.CreateDefaultService(@"C:\Users\ANASTASIJA\Downloads\chromedriver-win64\chromedriver-win64\chromedriver.exe");
            driver = new ChromeDriver(service, options);
        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }



        [TestMethod]
        public void RemovingItemFromInventory()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.FindElement(By.CssSelector("*[data-test=\"username\"]")).SendKeys("problem_user");
            driver.FindElement(By.CssSelector("*[data-test=\"password\"]")).SendKeys("secret_sauce");
            driver.FindElement(By.CssSelector("*[data-test=\"login-button\"]")).Click();
            driver.FindElement(By.CssSelector("*[data-test=\"add-to-cart-sauce-labs-backpack\"]")).Click();


            Assert.AreEqual("1", (string)driver.FindElement(By.CssSelector("*[data-test=\"shopping-cart-badge\"]")).Text);
            driver.FindElement(By.CssSelector("*[data-test=\"remove-sauce-labs-backpack\"]")).Click();
            var badge = driver.FindElements(By.CssSelector("*[data-test=\"shopping-cart-badge\"]"));
            Assert.AreEqual(0, badge.Count, "Badge that indicates the number of items present it the shopping cart is still present after removing items from cart.");

        }
    }
}