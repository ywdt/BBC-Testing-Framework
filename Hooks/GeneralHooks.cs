using TechTalk.SpecFlow;

namespace BBC_Testing_Framework.Hooks
{
    [Binding]
    public sealed class GeneralHooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            WebDriver.InitializeChromeDriver();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            WebDriver.DriverQuit();
        }
    }
}
