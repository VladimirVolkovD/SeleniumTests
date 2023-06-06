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
        
        private Button ContactTab = new(By.XPath("//*[@data-id='Contact']//span"));
        
        public LoginPage OpenPage()
        {
            Browser.Instance.NavigateToUrl("https://ivaonvoooo3-dev-ed.develop.lightning.force.com/");
            return this;
        }

        public LoginPage Login(UserModel user)
        {
            userNameInput.GetElement().SendKeys(user.Name);
            passwordInput.GetElement().SendKeys(user.Password);
            loginButton.GetElement().Click();

            return this;
        }

        public NewAccountModal OpenNewAccountModal()
        {
            Browser.Instance.NavigateToUrl("https://ivaonvoooo3-dev-ed.develop.lightning.force.com/lightning/o/Account/list?filterName=Recent");
            new Button(By.XPath("//div[@title='New']")).GetElement().Click();
            return new NewAccountModal();
        }

        public NewContactModal OpenNewContactModal()
        {
            // Browser.Instance.NavigateToUrl("https://ivaonvoooo3-dev-ed.develop.lightning.force.com/lightning/o/Contact/list?filterName=Recent");
            var contactTab = Browser.Instance.Driver.FindElement(By.XPath("//*[@data-id='Contact']//span"));

            ContactTab.ClickElementViaJs();
            new Button(By.XPath("//div[@title='New']")).GetElement().Click();

            return new NewContactModal();
        }
    }
}
