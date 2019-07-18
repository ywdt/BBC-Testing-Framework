using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBC_Testing_Framework
{
    class SearchResultsPage
    {
        public static string ResultHeader = "Africa";

        public SearchResultsPage()
        {
            PageFactory.InitElements(WebDriver.Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"news-top-stories-container\"]//span[text()=\"Europe\"]")]
        private IWebElement Tag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"orb-search-q\"]")]
        private IWebElement SearchField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"search-content\"]//a[text()=\"Africa\"]")]
        private IWebElement SearchResult { get; set; }

        public static void EnterSearchIntoTheSearchField()
        {
            SearchResultsPage search = new SearchResultsPage();
            search.SearchField.SendKeys(ResultHeader);
            search.SearchField.Click();
        }
    }
}
