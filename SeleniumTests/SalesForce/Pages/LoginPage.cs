using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using SeleniumTests.Core.Selenium;
using SeleniumTests.Core.Selenium.Elements;
using SeleniumTests.SwagLabs;

namespace SeleniumTests.SalesForce.Pages
{
    public class LoginPage
    {
        private Input userNameInput = new(By.XPath("//input[@name='username']"));
        private Input passwordInput = new(By.XPath("//input[@name='pw']"));
        private Button loginButton = new("Login");

        public LoginPage OpenPage()
        {
            Browser.Instance.NavigateToUrl("https://tms4.my.salesforce.com/");
            return this;
        }

        public NewAccountModal Login(UserModel user)
        {
            userNameInput.GetElement().SendKeys(user.Name);
            passwordInput.GetElement().SendKeys(user.Password);
            loginButton.GetElement().Click();

            Browser.Instance.NavigateToUrl("https://tms4.lightning.force.com/lightning/o/Account/list?filterName=Recent");
            new Button(By.XPath("//div[@title='New']")).GetElement().Click();
            return new NewAccountModal();
        }

    }
}
