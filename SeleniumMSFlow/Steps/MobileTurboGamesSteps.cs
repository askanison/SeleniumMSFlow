using System;
using TechTalk.SpecFlow;

namespace SeleniumMSFlow.Steps
{
    [Binding]
    public class MobileTurboGamesSteps
    {
        [Given(@"I click '(.*)' button")]
        public void GivenIClickButton(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        
        
        [Then(@"Turbo Game is launched")]
        public void ThenTurboGameIsLaunched()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
