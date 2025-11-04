using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestProject1
{
    [TestClass]
    public class RemoveTest:TestBase
    {


        [TestMethod]
        public void WhenRemoveItem_BadgeShouldDisappear()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.LoginWithNameAndPassword("problem_user", "secret_sauce");
            mainPage.AddAnItem();
            mainPage.RemoveAnItem();
            mainPage.CheckThatItemIsRemoved(); 
        }



    }
}