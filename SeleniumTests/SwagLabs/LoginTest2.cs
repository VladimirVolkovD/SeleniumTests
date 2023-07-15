using OpenQA.Selenium;
using SeleniumTests.Core.Selenium;
using SeleniumTests.SwagLabs.PageObject;

namespace SeleniumTests.SwagLabs.Test
{
    internal class LoginTest2
    {

        [Test]
        public void Login_StandartUser()
        {
            //Cart
            string subjectString = Enum.GetName(typeof(Pages), Pages.Home);

            //Cart Page
            var result = Pages.Home.GetString();
        }

    
    }
}
