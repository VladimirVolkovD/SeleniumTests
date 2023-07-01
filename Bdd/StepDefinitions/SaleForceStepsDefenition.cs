using SeleniumTests.Core;
using SeleniumTests.SalesForce.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bdd.StepDefinitions
{
    [Binding]
    internal class SaleForceStepsDefenition
    {
        [Given(@"Login to the sale force like standart user")]
        public void GivenLoginToTheSaleForceLikeStandartUser()
        {

            var user = UserBuilder.GetSalesForceUser();

            new LoginPage()
                .OpenPage()
                .Login(user);                
        }

        [Given(@"Navigate to create new account page")]
        public void GivenNavigateToCreateNewAccountPage()
        {
            new LoginPage().OpenNewAccountModal();                
        }

        [When(@"Create account with ""([^""]*)"" name and ""([^""]*)"" Type")]
        public void WhenCreateAccountWithNameAndType(string user, string customer)
        {
           new NewAccountModal().CreateAccount(user, customer);
        }

        [Then(@"TODO")]
        public void ThenTODO()
        {
            throw new PendingStepException();
        }

    }
}
