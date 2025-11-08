using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject1.Base;
using TestProject1.Pages;

namespace TestProject1.Tests
{
    [TestClass]
    public class RemoveTest : TestBase
    {


        [TestMethod]
        public void WhenRemoveItem_BadgeShouldDisappear()
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