using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using FluentAssertions;
using static SeleniumMSFlow.Base;
using SeleniumMSFlow.Drivers;
using SeleniumMSFlow.Helpers;

namespace SeleniumMSFlow.Steps
{
    [Binding]
    public class CheckSlotProviderPart1Steps : DriverHelper
    {
        [Given(@"I navigate to desktop '(.*)' page")]
        public void GivenINavigateToDesktopPage(string page)
        {
            string currentUrl = driver.Url;
            DesktopHeaderNavigation(driver, page);
            WaitUntilUrlChanges(driver, currentUrl);
            (driver.Url == currentUrl).Should().BeFalse($"Desktop header {page} buton didn't work or redirected to different page");
        }
        
        [When(@"I choose (.*) from desktop filter")]
        public void WhenIChooseFromDesktopFilter(string provider)
        {
            ClickToElement(driver, $"//span[@data-id='slot-navigation'][text() = ' {provider} ']");
        }
        
        [When(@"I open random slot game")]
        public void WhenIOpenRandomSlotGame()
        {
            int gamesCount = FindElements(driver, "//div[@data-id='game-element']//button").Count;
            Random random = new();
            ClickToElement(driver, $"(//div[@data-id='game-element']//button)[{random.Next(1, gamesCount)}]");
        }
        
        [When(@"I choose (.*) from mobile filter")]
        public void WhenIChooseFromMobileFilter(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The Title is changed to (.*)")]
        public void ThenTheTitleIsChangedTo(string providerName)
        {
            FindElement(driver, "//adj-game-bar//span[@class='_s_label _s_label-md']").Text.Should().Be($"{providerName}", $"After choosing {providerName} from filter, gamebar name wasn't changed");
        }
        
        
        [Then(@"Correct (.*) is opened")]
        public void ThenCorrectIsOpened(string provider)
        {
            var gameData = new ProvidersInfo(provider);

            ElementExists(driver, "//adj-in-games//iframe", timer: 10000).Should().BeTrue("Game iframe not found");

            int counter = 0;
            string source = "";
            do
            {
                source = FindElement(driver, "//adj-in-games//iframe").GetAttribute("src");
                counter++;
                if (counter == 10)
                    HardReload(driver);
            }
            while (source.Length < 15 || source == "about:blank");

            source.Contains(gameData.GameInfo.ProviderUrl).Should().BeTrue("Opened game iframe url is incorrect");
            //SwitchToFrame(driver, FindElement(driver, "//adj-in-games//iframe", timer: 20000));
            
            //if (provider.Key == "EGT")
            //{
            //    driver.SwitchTo().Frame(FindElement(driver, "//iframe", timer: 20000));
            //    FindElement(driver, provider.Value.GameValidator, timer: 20000, error: "first");
            //    driver.SwitchTo().ParentFrame();
            //}
            //else
            //{
            //    FindElement(driver, provider.Value.GameValidator, timer: 20000, error: "second");
            //}            

        }
    }
}
