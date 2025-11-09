
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace Lab2Tests.Pages
{

    public class InventoryPage
    {
        private readonly IWebDriver Driver;

        [FindsBy(How = How.CssSelector, Using = "*[data-test=\"add-to-cart-sauce-labs-backpack\"]")]
        private IWebElement addButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "*[data-test=\"remove-sauce-labs-backpack\"]")]
        private IWebElement removeButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "*[data-test=\"shopping-cart-badge\"]")]
        private IList<IWebElement> cartBadge { get; set; }

        [FindsBy(How = How.CssSelector, Using = "*[data-test=\"shopping-cart-badge\"]")]
        private IWebElement badge { get; set; }

        [FindsBy(How = How.CssSelector, Using = "*[data-test=\"shopping-cart-link\"]")]
        private IWebElement cartLink { get; set; }

        //private By add_button = By.CssSelector("*[data-test=\"add-to-cart-sauce-labs-backpack\"]");
        //private By remove_button = By.CssSelector("*[data-test=\"remove-sauce-labs-backpack\"]");
        //private By cartBadge = By.CssSelector("*[data-test=\"shopping-cart-badge\"]");

        public InventoryPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void AddAnItem()
        {
            addButton.Click();
            Assert.AreEqual("1", badge.Text, "Expected cart badge text to be '1' after adding an item, but got '{badge.Text}'.");
        }

        public void RemoveAnItem()
        {
            removeButton.Click();
        }

        public void CheckThatItemIsRemoved()
        {
           
            Assert.AreEqual(0, cartBadge.Count, "Badge is still present after removing items from inventory.");
        }

        public void NavigateToCartPage()
        {
            cartLink.Click();
        }

    }
}