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

        private By username_field = By.CssSelector("*[data-test=\"username\"]");
        private By password_field = By.CssSelector("*[data-test=\"password\"]");
        private By login_button = By.CssSelector("*[data-test=\"login-button\"]");
        private By add_button = By.CssSelector("*[data-test=\"add-to-cart-sauce-labs-backpack\"]");
        private By remove_button = By.CssSelector("*[data-test=\"remove-sauce-labs-backpack\"]");
        private By cartBadge = By.CssSelector("*[data-test=\"shopping-cart-badge\"]");

        public MainPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void LoginWithNameAndPassword(string username, string password)
        {

            Driver.FindElement(username_field).SendKeys(username);
            Driver.FindElement(password_field).SendKeys(password);
            Driver.FindElement(login_button).Click();
        }

        public void AddAnItem()
        {
            Driver.FindElement(add_button).Click();
        }

        public void RemoveAnItem()
        {
            Driver.FindElement(remove_button).Click();
        }

        public void CheckThatItemIsRemoved()
        {
            var badge = Driver.FindElements(cartBadge);
            Assert.AreEqual(0, badge.Count, "Badge that indicates the number of items present it the shopping cart is still present after removing items from cart.");
        }

    }
}