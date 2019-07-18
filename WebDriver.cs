using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BBC_Testing_Framework
{
    public static class WebDriver
    {
        public static IWebDriver Driver { get; set; }

        //public static void WaitForPageToLoad()
        //{
        //    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Config.PageLoadingTimeout);
        //}

        public static void IntializeDriver()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(HomePage.HomePageURL);
            HomePage BBChomePage = new HomePage();
            BBChomePage.HomePageHeader.Click();
            //WebDriver.WaitForPageToLoad();
        }

        public static void DriverQuit()
        {
            Driver.Quit();
        }
    }
}
