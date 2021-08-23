using System;
using TechTalk.SpecFlow;

namespace SeleniumMSFlow.Steps
{
    [Binding]
    public class MobileCasinoSteps
    {
        [Given(@"I click first mobile game in list")]
        public void GivenIClickFirstMobileGameInList()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click (.*) on filter")]
        public void WhenIClickOnFilter(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I check Mobile Casino search functional")]
        public void ThenICheckMobileCasinoSearchFunctional(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Mobile Casino game is opened")]
        public void ThenMobileCasinoGameIsOpened()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I check mobile casino filter")]
        public void ThenICheckMobileCasinoFilter(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"(.*) is changed")]
        public void ThenIsChanged(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"My Casino isn't available")]
        public void ThenMyCasinoIsnTAvailable()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
