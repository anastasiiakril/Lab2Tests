
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1.Pages
{

    public class InventoryPage
    {
        private IWebDriver Driver;

       
        private By add_button = By.CssSelector("*[data-test=\"add-to-cart-sauce-labs-backpack\"]");
        private By remove_button = By.CssSelector("*[data-test=\"remove-sauce-labs-backpack\"]");
        private By cartBadge = By.CssSelector("*[data-test=\"shopping-cart-badge\"]");

        public InventoryPage(IWebDriver driver)
        {
            Driver = driver;
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