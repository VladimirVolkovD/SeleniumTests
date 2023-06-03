using OpenQA.Selenium;
using SeleniumTests.Core;
using SeleniumTests.Core.Selenium;
using SeleniumTests.SwagLabs.PageObject;

namespace SeleniumTests.SwagLabs.Test
{
    internal class LoginTest : BaseTest
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

        [Test]
        public void Login()
        {
            var user = new UserModel()
            {
                Password = " ",
                Name = " ",
            };

            var page = new LoginPage();

            page.OpenPage().TryToLogin(user);

            page.VerifyErrorMessage();
        }

        [Test]
        public void TestCheckOut()
        {
            var user = new UserModel()
            {
                Password = "asdasdasd",
                Name = " ",
            };

        }

        [Test]
        public void TestCheckOutNegative()
        {
            var user = new UserModel()
            {
                Name = "adsfadfgsh",
            };

        }

        [Test]
        public void TestCheckOutNegative1()
        {
            var user = UserBuilder.GetStandartUser();

        }

        [Test]
        public void TestCheckOutNegative11()
        {
            var user = UserBuilder.GetStandartUserWithoutName();

        }

        [Test]
        public void TestCheckOutNegative211()
        {
            var user = UserBuilder.GetRandomUserWithPassword("QAZ!@W");

        }


        public void GoToCartPage()
        {
           new LoginPage()
               .OpenPage()
               .LoginAsStandartUser()
               .ClickOnCartIcon();
        }
    }
}
