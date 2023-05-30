using OpenQA.Selenium;

namespace SeleniumTests.SwagLabs.PageObject
{
    internal class InventoryPage : BasePage
    {

        //public LeftMenu LeftMenu;

        private By ShoppingCartLink = By.ClassName("shopping_cart_link");


        public const string url = "https://www.saucedemo.com/inventory.html";

        public InventoryPage()
        {
            WaitHelper.WaitElement(driver, ShoppingCartLink);
            // LeftMenu = new LefMenu(driver);
        }

        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(url);

            return this;
        }

        //public LoginPAge Logout()
        //{
        //   LeftMenu.Logout()
        //   return new LoginPage();
        //}
    }
}
