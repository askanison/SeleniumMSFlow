using System;
using TechTalk.SpecFlow;

namespace SeleniumMSFlow.Steps
{
    [Binding]
    public class MobileSlotsSteps
    {
        [Given(@"I choose '(.*)' from mobile filter")]
        public void GivenIChooseFromMobileFilter(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I check Mobile Slots search functional")]
        public void ThenICheckMobileSlotsSearchFunctional(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I check mobile Slots My Casino subfilter")]
        public void ThenICheckMobileSlotsMyCasinoSubfilter(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"EGT mobile game is launched")]
        public void ThenEGTMobileGameIsLaunched()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
