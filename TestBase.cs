using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestProject1
{
    [TestClass]
    public class TestBase
    {

        protected IWebDriver driver;

        [TestInitialize]
        public void SetUp()
        {
            var options = new ChromeOptions();
            options.BinaryLocation = @"C:\Users\ANASTASIJA\Downloads\chrome-win64\chrome-win64\chrome.exe";

            var service = ChromeDriverService.CreateDefaultService(@"C:\Users\ANASTASIJA\Downloads\chromedriver-win64\chromedriver-win64\chromedriver.exe");
            driver = new ChromeDriver(service, options);

            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }


    }
}