using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using FluentAssertions;
using static SeleniumMSFlow.Base;
using SeleniumMSFlow.Drivers;

namespace SeleniumMSFlow.Steps
{
    [Binding]
    public class MobileAviatorSteps : DriverHelper
    {
        [Given(@"I open Adjarabet.com home page")]
        [Given(@"I have opened Adjarabet.com home page")]
        public void GivenIHaveOpenedAdjarabetHomePage()
        {
            GoToUrl(driver, $"https://{Branch}.adjarabet.com/");
        }
        
        [Given(@"I log in using '(.*)' and '(.*)' credentials")]
        [When(@"I log in using '(.*)' and '(.*)' credentials")]
        public void GivenILogInUsingAndCredentials(string username, string password)
        {
            ClickToElement(driver, "//a[@data-id='mobile-login']", "Mobile header authorization button not found");
            SendKeys(driver, "//input[@data-id='username']", username, "Mobile authorization form username input not found");
            SendKeys(driver, "//input[@data-id='password']", password, "Mobile authorization form password input not found");
            ClickToElement(driver, "//button[@data-id='mobile-login-btn']", "Mobile authorization form Login button not found");
            WaitUntilElementVanishes(driver, "//adj-login-mobile");
            ElementExists(driver, "//adj-login-mobile").Should().BeFalse("Mobile login for didn't vanish after authorization, or login process failed");
        }
        
        [Given(@"I navigate to mobile '(.*)' page")]
        [When(@"I navigate to mobile '(.*)' page")]
        public void GivenINavigateToMobilePage(string page)
        {
            string currentUrl = driver.Url;
            MobileHeaderNavigation(driver, page);
            WaitUntilUrlChanges(driver, currentUrl);
            (driver.Url == currentUrl).Should().BeFalse($"Mobile header {page} buton didn't work or redirected to different page");
        }


        [When(@"I clik Play Mobile Aviator button")]
        [Given(@"I clik Play Mobile Aviator button")]
        public void WhenIClikPlayMobileAviatorButton()
        {
            string currentUrl = driver.Url;
            ClickToElement(driver, "//adj-aviator//span[contains(@class,'aviator')]", $"Can't click or find Play Mobile Aviator element");
            WaitUntilElementVanishes(driver, "//adj-aviator//span[contains(@class,'aviator')]");
            ElementExists(driver, "//adj-aviator//span[contains(@class,'aviator')]").Should().BeFalse("After clicking Play Mobile Aviator button, nothing happened as the button is still visible");
            (driver.Url == currentUrl).Should().BeFalse("After clicking Play Mobile Aviator button, nothing happened as the Url didn't change");
            (driver.Url.Length > 20).Should().BeTrue("After clicking Play Mobile Aviator button Url is incorrect");
        }




        [When(@"I log in using '(.*)' and '(.*)' from opened login form")]
        public void WhenILogInUsingAndFromOpenedLoginForm(string username, string password)
        {
            SendKeys(driver, "//input[@data-id='username']", username, "Mobile authorization form username input not found");
            SendKeys(driver, "//input[@data-id='password']", password, "Mobile authorization form password input not found");
            ClickToElement(driver, "//button[@data-id='mobile-login-btn']", "Mobile authorization form Login button not found");
            WaitUntilElementVanishes(driver, "//adj-login-mobile");
            ElementVisible(driver, "//adj-login-mobile").Should().BeFalse("Mobile login for didn't vanish after authorization, or login process failed");
        }

        [Then(@"Mobile Aviator game is loaded")]
        public void ThenMobileAviatorGameIsLoaded()
        {
            FindElement(driver, "//div[@class='play-board-wrapper']", "Mobile Aviator not launched, game element not found/loaded");
        }

    }
}
