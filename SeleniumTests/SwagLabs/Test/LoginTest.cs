using SeleniumTests.SwagLabs.PageObject;

namespace SeleniumTests.SwagLabs.Test
{
    internal class LoginTest : SwagLabBaseTest
    {

        [Test]
        public void Login_StandartUser()
        {
            var inventoryPage = new LoginPage(driver)
                .OpenPage()
                .LoginAsStandartUser();
        }

        [Test]
        public void Login()
        {
            var user = new UserModel()
            {
                Password = "asdasdasd",
            };

            var page = new LoginPage(driver);

            page.OpenPage().TryToLogin(user);

            page.VerifyErrorMessage();
        }
    }
}
