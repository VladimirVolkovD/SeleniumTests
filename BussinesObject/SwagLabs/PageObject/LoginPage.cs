using NLog;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumTests.SwagLabs.PageObject
{
    public class LoginPage : BasePage
    {
        private By UserNameInput = By.Id("user-name");
        private By PasswordInput = By.XPath("//*[@data-test='password']");
        private By ErrorMessage = By.CssSelector(".error-message-container.error");
        private By LoginButton = By.CssSelector(".submit-button");

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public const string url = "https://www.saucedemo.com/";

        public const string STANDART_USER_NAME = "standard_user";
        public const string STANDART_USER_PASSWORD = "secret_sauce";

        [AllureStep]
        public override LoginPage OpenPage()
        {
            logger.Info($"Navigate to to url {url}");
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

        [AllureStep("Try to login")]
        public void TryToLogin(UserModel user)
        {
            logger.Info($"Try to login like user {user}");
            driver.FindElement(UserNameInput).SendKeys(user.Name);
            driver.FindElement(PasswordInput).SendKeys(user.Password);
            driver.FindElement(LoginButton).Click();
        }

        [AllureStep]
        public bool VerifyErrorMessage()
        {
            logger.Info($"Verify error message for inccoret data for login");
            //check display status for ErrorMessage 


            logger.Warn($"- warn");
            logger.Debug($"- debug");
            logger.Error("- error");
            logger.Fatal("- fatal");

            Assert.Fail();

            return false;
        }
    }
}
