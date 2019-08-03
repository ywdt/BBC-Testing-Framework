using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBC_Testing_Framework
{
    class HomePage
    {
        public const string HomePageURL = "https://bbc.com/news";

        public HomePage()
        {
            PageFactory.InitElements(WebDriver.Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"orb-nav-links\"]//a[text() = \"News\"]")]
        internal IWebElement NewsTab { get; set; }
    }
}