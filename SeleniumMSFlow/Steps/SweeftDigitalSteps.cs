using FluentAssertions;
using SeleniumMSFlow.Drivers;
using TechTalk.SpecFlow;
using static SeleniumMSFlow.Base;

namespace SeleniumMSFlow.Steps
{
    [Binding]
    public class SweeftDigitalSteps : DriverHelper
    {
        [When(@"I click (.*) on header navigation")]
        public void WhenIClickOnHeaderNavigation(string button)
        {
            ClickToElement(driver, $"//li[contains(@class,'nav__list__item')]/a[text()='{button}']", $"{button} button not found on header navigation");
        }


        [Given(@"Open SweeftDigital homepage")]
        public void GivenOpenSweeftDigitalHomepage()
        {
            driver.Navigate().GoToUrl("https://sweeftdigital.com/");
        }

        [Then(@"I am navigated to correct (.*)")]
        public void ThenIAmNavigatedToCorrect(string page)
        {
            (driver.Url == $"https://sweeftdigital.com/{page}").Should().BeTrue("after navigation from header, url wasn't changed");
        }
    }
}