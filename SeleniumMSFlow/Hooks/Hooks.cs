using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumMSFlow.Drivers;
using SeleniumMSFlow.Helpers.Enums;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;
using static SeleniumMSFlow.Base;
[assembly: Parallelize(Scope = ExecutionScope.ClassLevel, Workers = 4)]

namespace SeleniumMSFlow.Hooks
{
    [Binding]
    public sealed class Hooks : DriverHelper
    {

        BrowserDrivers browserDrivers;
        private readonly ISpecFlowOutputHelper specFlowOutputHelper;
        ScenarioContext scenarioContext;



        public Hooks(BrowserDrivers browserDrivers, ISpecFlowOutputHelper specFlowOutputHelper, ScenarioContext scenarioContext)
        {
            this.browserDrivers = browserDrivers;
            this.specFlowOutputHelper = specFlowOutputHelper;
            this.scenarioContext = scenarioContext;
        }

        [BeforeScenario("Mobile")]
        public void BeforeMobileScenario()
        {
            //driver = browserDrivers.GetWebDriver(BrowserType.ChromeMobileLocal);
            driver = browserDrivers.GetWebDriver(BrowserType.ChromeMobileLocal);

        }

        [BeforeScenario("Desktop")]
        public void BeforeDesktopScenario()
        {
            //driver = browserDrivers.GetWebDriver(BrowserType.ChromeDesktopLocal);
            driver = browserDrivers.GetWebDriver(BrowserType.ChromeDesktopLocal);

        }

        [BeforeScenario("RemoteMobile")]
        public void BeforeRemoteScenario()
        {
            driver = browserDrivers.GetWebDriver(BrowserType.ChromeMobileRemote);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            FinishTest(driver);
        }


        [AfterStep]
        public void TakeScreenshotAfterStep()
        {
            if (scenarioContext.TestError != null)
                specFlowOutputHelper.AddAttachment(UploadImage(driver));
        }
    }
}
