using System;
using TechTalk.SpecFlow;

namespace SeleniumMSFlow.Steps
{
    [Binding]
    public class MobileTableGamesSteps
    {
        [When(@"I click '(.*)' button")]
        public void WhenIClickButton(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Table Game is launched")]
        public void ThenTableGameIsLaunched()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"'(.*)' is correct")]
        public void ThenIsCorrect(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
