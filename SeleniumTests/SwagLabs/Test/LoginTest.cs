using SeleniumTests.SwagLabs.PageObject;

namespace SeleniumTests.SwagLabs.Test
{
    internal class LoginTest : SwagLabBaseTest
    {

        [Test]
        public void Login_StandartUser()
        {
            var page = new LoginPage(driver);
            page.OpenPage();
            page.LoginAsStandartUser();

        }
    }
}
