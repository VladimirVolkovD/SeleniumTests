using OpenQA.Selenium;
using SeleniumTests.Core.Selenium;
using SeleniumTests.Core.Selenium.Elements;

namespace SeleniumTests.SwagLabs.PageObject
{
    public class InventoryPage : BasePage
    {

        //public LeftMenu LeftMenu;
        private BaseElement CartLink = new(By.ClassName("shopping_cart_link"));

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

        public void ClickOnCartIcon()
        {
            CartLink.GetElement().Click();
        }

        //public LoginPAge Logout()
        //{
        //   LeftMenu.Logout()
        //   return new LoginPage();
        //}
    }
}
