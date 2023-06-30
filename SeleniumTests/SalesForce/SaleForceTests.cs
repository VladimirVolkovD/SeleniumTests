using SeleniumTests.Core;
using SeleniumTests.SalesForce.Pages;

namespace SeleniumTests.SalesForce
{
    public class SaleForceTests
    {
        [Test]
        public void CreateAccount()
        {
            var user = UserBuilder.GetSalesForceUser();

            new LoginPage()
                .OpenPage()
                .Login(user)
                .OpenNewAccountModal()
                .CreateAccount(user.Name, "Customer");
        }

        [Test]
        public void CreateContact()
        {
            var user = UserBuilder.GetSalesForceUser();

            new LoginPage()
                .OpenPage()
                .Login(user)
                .OpenNewContactModal()
                .CreateContact(user.Name, "Customer");
        }
    }
}
