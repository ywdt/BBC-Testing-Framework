using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace BBC_Testing_Framework
{
    class SearchResultsPage
    {
        public SearchResultsPage()
        {
            PageFactory.InitElements(WebDriver.Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@class=\"editors-choice results\"]//h1")]
        internal IWebElement FirstSearchResult { get; set; }

        public Dictionary<string, string> TagAndSearchResultsPairs = new Dictionary<string, string>()
        {
            ["UK Politics"] = "Politics",
            ["UK"] = "UK News",
            ["Europe"] = "Europe",
            ["US & Canada"] = "US & Canada",
            ["Asia"] = "Asia",
            ["China"] = "China"
        };
    }
}
