using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBC_Testing_Framework
{
    class SearchResultsPage
    {
        public SearchResultsPage()
        {
            PageFactory.InitElements(WebDriver.Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"news-top-stories-container\"]//span[text()=\"UK\"]")]
        public IWebElement Tag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"orb-search-q\"]")]
        public IWebElement SearchField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"search-content\"]//a[text()=\"UK News\"]")]
        public IWebElement SearchResult { get; set; }

        public void TagInputAndClickOnTheSearchButton()
        {
            SearchResultsPage newTag = new SearchResultsPage();
            newTag.SearchField.SendKeys(Tag.Text);
            newTag.SearchField.Click();
        }
    }
}
