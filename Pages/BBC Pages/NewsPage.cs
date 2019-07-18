using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBC_Testing_Framework
{
    class NewsPage
    {
        public static string MainHeader = "Suspected arson at Japan anime studio kills 26";
        public static string SecondaryHeader = "Time running out for missile treaty - Nato head";
        public static string TagName = "Europe";

        public NewsPage()
        {
            PageFactory.InitElements(WebDriver.Driver, this);
        }

        //TODO Check asterisks!
        //Practice #1
        [FindsBy(How = How.XPath, Using = "//h3[text()=\"Suspected arson at Japan anime studio kills 26\"]")]
        private IWebElement TopNews { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[text()=\"Time running out for missile treaty - Nato head\"]")]
        private IWebElement SecondaryNews { get; set; }
    }
}
