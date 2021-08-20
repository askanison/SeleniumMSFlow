using OpenQA.Selenium;
using System;

namespace SeleniumMSFlow.Drivers
{
    public class DriverHelper
    {
        [ThreadStatic] public static IWebDriver driver;
    }
}
