using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestProject1
{
   
    public class MainPage
    {
        private IWebDriver Driver;
        public MainPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void LoginWithNameAndPassword(string username, string password)
        {

            Driver.FindElement(By.CssSelector("*[data-test=\"username\"]")).SendKeys(username);
            Driver.FindElement(By.CssSelector("*[data-test=\"password\"]")).SendKeys(password);
            Driver.FindElement(By.CssSelector("*[data-test=\"login-button\"]")).Click();
        }

        public void AddAnItem()
        {
            Driver.FindElement(By.CssSelector("*[data-test=\"add-to-cart-sauce-labs-backpack\"]")).Click();
        }

        public void RemoveAnItem()
        {
            Driver.FindElement(By.CssSelector("*[data-test=\"remove-sauce-labs-backpack\"]")).Click();
        }

        public void CheckThatItemIsRemoved()
        {
            var badge = Driver.FindElements(By.CssSelector("*[data-test=\"shopping-cart-badge\"]"));
            Assert.AreEqual(0, badge.Count, "Badge that indicates the number of items present it the shopping cart is still present after removing items from cart.");
        }

    }
}