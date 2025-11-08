
using OpenQA.Selenium;


namespace TestProject1.Pages
{

    public class LoginPage
    {
        private IWebDriver Driver;

        private By username_field = By.CssSelector("*[data-test=\"username\"]");
        private By password_field = By.CssSelector("*[data-test=\"password\"]");
        private By login_button = By.CssSelector("*[data-test=\"login-button\"]");
    

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void LoginWithNameAndPassword(string username, string password)
        {

            Driver.FindElement(username_field).SendKeys(username);
            Driver.FindElement(password_field).SendKeys(password);
            Driver.FindElement(login_button).Click();
        }

    

    }
}