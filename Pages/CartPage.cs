
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Lab2Tests.Pages
{

    public class CartPage
    {
        private readonly IWebDriver Driver;


        [FindsBy(How = How.CssSelector, Using = "*[data-test=\"remove-sauce-labs-backpack\"]")]
        private IWebElement removeButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "*[data-test=\"shopping-cart-badge\"]")]
        private IList<IWebElement> cartBadge { get; set; }

        //private By add_button = By.CssSelector("*[data-test=\"add-to-cart-sauce-labs-backpack\"]");
        //private By remove_button = By.CssSelector("*[data-test=\"remove-sauce-labs-backpack\"]");
        //private By cartBadge = By.CssSelector("*[data-test=\"shopping-cart-badge\"]");

        public CartPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void RemoveAnItem()
        {
            removeButton.Click();
        }

        public void CheckThatItemIsRemoved()
        {

            Assert.AreEqual(0, cartBadge.Count, "Badge that indicates the number of items present it the shopping cart is still present after removing items from cart.");
        }

    }
}