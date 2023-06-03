using OpenQA.Selenium;

namespace SeleniumTests.SwagLabs.PageObject
{
    internal class LoginPage : BasePage
    {
        private By UserNameInput = By.Id("user-name");
        private By PasswordInput = By.XPath("//*[@data-test='password']");
        private By ErrorMessage = By.CssSelector(".error-message-container.error");
        private By LoginButton = By.CssSelector(".submit-button");

        public const string url = "https://www.saucedemo.com/";

        public const string STANDART_USER_NAME = "standard_user";
        public const string STANDART_USER_PASSWORD = "secret_sauce";

        public override LoginPage OpenPage()
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }

        public InventoryPage LoginAsStandartUser()
        {
            var user = new UserModel()
            {
                Name = STANDART_USER_NAME,
                Password = STANDART_USER_PASSWORD,
            };

            TryToLogin(user);

            return new InventoryPage();
        }

        public void TryToLogin(UserModel user)
        {
            driver.FindElement(UserNameInput).SendKeys(user.Name);
            driver.FindElement(PasswordInput).SendKeys(user.Password);
            driver.FindElement(LoginButton).Click();
        }

        internal bool VerifyErrorMessage()
        {
            //check display status for ErrorMessage 
            return false;
        }
    }
}
