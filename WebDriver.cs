using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BBC_Testing_Framework
{
    public static class WebDriver
    {
        public static IWebDriver Driver { get; set; }

        public static void InitializeChromeDriver()
        {
            Driver = new ChromeDriver();
        }

        public static void IntializeIpsumDriver()
        {
            Driver.Navigate().GoToUrl(LipsumHomePage.URL);
        }

        public static void IntializeBBCDriver()
        {
            Driver.Navigate().GoToUrl(HomePage.HomePageURL);
        }

        public static void DriverQuit()
        {
            Driver.Quit();
        }
    }
}
