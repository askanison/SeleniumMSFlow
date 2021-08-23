using System;
using TechTalk.SpecFlow;

namespace SeleniumMSFlow.Steps
{
    [Binding]
    public class MobilePokerSteps
    {
        [Given(@"I click Play New Poker button")]
        public void GivenIClickPlayNewPokerButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click Play New Poker button")]
        public void WhenIClickPlayNewPokerButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Mobile Poker game is launched")]
        public void ThenMobilePokerGameIsLaunched(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
