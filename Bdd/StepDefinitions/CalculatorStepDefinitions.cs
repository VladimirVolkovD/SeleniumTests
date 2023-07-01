using NUnit.Framework;

namespace Bdd.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        protected ScenarioContext _ScenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _ScenarioContext = scenarioContext;
        }

        [Given(@"the first number is (.*)")]
        public void GetFirstNumber(int number)
        {
            _ScenarioContext["NumberOne"] = number;         
        }

        [Given(@"the second number is (.*)")]
        public void GetSecondNumber(int number)
        {
            _ScenarioContext["NumberTwo"] = number;
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Console.WriteLine("Added numbers!");
        }
              

        [Given(@"the following users exist:")]
        public void GivenTheFollowingUsersExist(Table table)
        {
            Console.WriteLine(table.ToString());
        }

    }
}