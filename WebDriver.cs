using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BBC_Testing_Framework
{
    public static class WebDriver
    {
        public static IWebDriver Driver { get; set; }

        public static void IntializeBBCDriver()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(HomePage.HomePageURL);
        }

        public static void IntializeIpsumDriver()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(LipsumHomePage.URL);
        }

        public static void DriverQuit()
        {
            Driver.Quit();
        }
    }
}
