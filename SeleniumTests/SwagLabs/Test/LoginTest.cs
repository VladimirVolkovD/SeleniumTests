using SeleniumTests.Core;
using SeleniumTests.SwagLabs.PageObject;

namespace SeleniumTests.SwagLabs.Test
{
    internal class LoginTest : SwagLabBaseTest
    {

        [Test]
        public void Login_StandartUser()
        {

            Browser.Instance.NavigateToUrl("asdasd");

            var inventoryPage = new LoginPage()
                .OpenPage()
                .LoginAsStandartUser();
        }

        [Test]
        public void Login()
        {
            var user = new UserModel()
            {
                Password = "asdasdasd",
                Name = " ",
            };

            var page = new LoginPage();

            page.OpenPage().TryToLogin(user);

            page.VerifyErrorMessage();
        }
    }
}
