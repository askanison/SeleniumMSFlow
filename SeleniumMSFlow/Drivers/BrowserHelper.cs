using OpenQA.Selenium;
using SeleniumMSFlow.Helpers;
using System;

namespace SeleniumMSFlow.Drivers
{
    public class DriverHelper : TestData
    {
        [ThreadStatic] public static IWebDriver driver;
    }
}
