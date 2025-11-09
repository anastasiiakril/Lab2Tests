using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Lab2Tests.Pages
{

    public class LoginPage
    {
        private readonly IWebDriver Driver;

        [FindsBy(How = How.CssSelector, Using = "*[data-test=\"username\"]")]
        private IWebElement usernameField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "*[data-test=\"password\"]")]
        private IWebElement passwordField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "*[data-test=\"login-button\"]")]
        private IWebElement loginButton { get; set; }


        //private By username_field = By.CssSelector("*[data-test=\"username\"]");
        //private By password_field = By.CssSelector("*[data-test=\"password\"]");
        //private By login_button = By.CssSelector("*[data-test=\"login-button\"]");


        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void LoginWithNameAndPassword(string username, string password)
        {

            usernameField.SendKeys(username);
            passwordField.SendKeys(password);
            loginButton.Click();
        }

    

    }
}