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

        public LoginPage(WebDriver webDriver) : base(webDriver)
        {
        }

        public override void OpenPage()
        {
            driver.Navigate().GoToUrl(url);
        }

        public void LoginAsStandartUser()
        {
            driver.FindElement(UserNameInput).SendKeys(STANDART_USER_NAME);
            driver.FindElement(PasswordInput).SendKeys(STANDART_USER_PASSWORD);
            driver.FindElement(LoginButton).Click();
        }

    }
}
