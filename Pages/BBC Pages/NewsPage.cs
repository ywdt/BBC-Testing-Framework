using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBC_Testing_Framework
{
    class NewsPage
    {
        public NewsPage()
        {
            PageFactory.InitElements(WebDriver.Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@data-entityid=\"container-top-stories#1\"]")]
        internal IWebElement FirstTopStoryPresence { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-entityid=\"container-top-stories#2\"]")]
        internal IWebElement SecondTopStoryPresence { get; set; }

        [FindsBy(How = How.XPath, Using = "*//div/div/div/div[1]/div/div/div[1]/ul/li/a/span")]
        internal IWebElement Tag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"orb-search-q\"]")]
        internal IWebElement SearchField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"orb-search-button\"]")]
        internal IWebElement SearchButton { get; set; }
    }
}
