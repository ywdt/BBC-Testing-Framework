using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace BBC_Testing_Framework
{
    class SearchResultsPage
    {
        public Dictionary<string, string> TagAndSearchResultsPairs = new Dictionary<string, string>()
        {
            ["UK Politics"] = "Politics",
            ["UK"] = "UK News",
            ["Europe"] = "Europe",
            ["US & Canada"] = "US & Canada",
            ["Asia"] = "Asia"
        };

        public SearchResultsPage()
        {
            PageFactory.InitElements(WebDriver.Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@class=\"editors-choice results\"]//h1")]
        public IWebElement FirstSearchResult { get; set; }

        public string TagNameAssertion(NewsPage tag)
        {
            tag = new NewsPage();
            string tempValue = tag.ReturnTagName();
            string searchResultArticleName;
            //NewsPage getTagValue = new NewsPage();

            //getTagValue.InsertTagIntoSearchField();

            if (tempValue == "UK Politics")
                return searchResultArticleName = TagAndSearchResultsPairs["UK Politics"];

            else if (tempValue == "UK")
                return searchResultArticleName = TagAndSearchResultsPairs["UK"];

            else if (tempValue == "Europe")
                return searchResultArticleName = TagAndSearchResultsPairs["Europe"];

            else if (tempValue == "US & Canada")
                return searchResultArticleName = TagAndSearchResultsPairs["US & Canada"];

            else
                return searchResultArticleName = TagAndSearchResultsPairs["Asia"];
        }
    }
}
