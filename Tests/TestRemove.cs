using Lab2Tests.Base;
using Lab2Tests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2Tests.Tests
{
    [TestClass]
    public class RemoveTest : TestBase
    {


        [TestMethod]
        public void WhenRemoveItem_Inventory()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginWithNameAndPassword("problem_user", "secret_sauce");

            InventoryPage inventoryPage = new InventoryPage(driver);
            inventoryPage.AddAnItem();
            inventoryPage.RemoveAnItem();
            inventoryPage.CheckThatItemIsRemoved();
        }

        public void WhenRemoveItem_Cart()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginWithNameAndPassword("problem_user", "secret_sauce");

            InventoryPage inventoryPage = new InventoryPage(driver);
            inventoryPage.AddAnItem();
            inventoryPage.RemoveAnItem();
            inventoryPage.CheckThatItemIsRemoved();
        }


    }
}