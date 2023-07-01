using NUnit.Framework;

namespace Bdd.StepDefinitions
{
    [Binding]
    public class SecondDefinitions
    {
        protected ScenarioContext _ScenarioContext;
        
        public SecondDefinitions(ScenarioContext scenarioContext)
        {
            _ScenarioContext = scenarioContext;
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            var numberOne = _ScenarioContext.Get<int>("NumberOne");
            var numberTwo = _ScenarioContext.Get<int>("NumberTwo");

            Assert.AreEqual(numberOne + numberTwo, result);
        }
    }
}