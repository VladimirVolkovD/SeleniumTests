using OpenQA.Selenium;
using SeleniumTests.Core.Selenium;
using SeleniumTests.SwagLabs.PageObject;

namespace SeleniumTests.SwagLabs.Test
{
    internal class LoginTest2 : BaseTest
    {

        [SetUp]
        public void SetUp()
        {
            new LoginPage()
               .OpenPage()
               .LoginAsStandartUser()
               .ClickOnCartIcon();
        }

        [Test]
        public void Login_StandartUser()
        {

            Browser.Instance.NavigateToUrl("asdasd");

            var price = "$9.99".Replace("$", string.Empty);

            var element = Browser.Instance.Driver.FindElement(By.XPath("(//div[@class='inventory_item'])[2]"));


            var buttons = element.FindElement(By.ClassName("input_error form_input"));
            //Css .input_error.form_input
            //Css .input_error
            //css .form_input

            buttons.Click();
          
        }

    
    }
}
