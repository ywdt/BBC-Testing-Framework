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
        public IWebElement FirstTopStoryPresence { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-entityid=\"container-top-stories#2\"]")]
        public IWebElement SecondTopStoryPresence { get; set; }

        //[FindsBy(How = How.XPath, Using = "*//div[@data-entityid=\"container-top-stories#1\"]//a[@aria-label]")]
        [FindsBy(How = How.XPath, Using = "*//div/div/div/div[1]/div/div/div[1]/ul/li[2]/a/span")]
        public IWebElement Tag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"orb-search-q\"]")]
        public IWebElement SearchField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"orb-search-button\"]")]
        public IWebElement SearchButton { get; set; }

        //TODO Delete this method and replace with Tag.Text?
        public string ReturnTagName()
        {
            NewsPage tag = new NewsPage();
            string tagValue = tag.Tag.Text;
            return tagValue;
        }

        public string InsertTagIntoSearchField()
        {
            SearchField.SendKeys(ReturnTagName());
            SearchButton.Click();
            return Tag.Text;
        }
    }
}
