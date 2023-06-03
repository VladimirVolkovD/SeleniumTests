using SeleniumTests.Core;
using SeleniumTests.SalesForce.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                .CreateAccount(user.Name, "Customer");

        }
    }
}
