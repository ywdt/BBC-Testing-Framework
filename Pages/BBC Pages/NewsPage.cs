using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBC_Testing_Framework
{
    class NewsPage
    {
        public static string MainHeader = "UK political storm over seized tanker";
        public static string SecondaryHeader = "Wildfires sweep through central Portugal";
        public static string TagName = "UK";

        public NewsPage()
        {
            PageFactory.InitElements(WebDriver.Driver, this);
        }
        //TODO Check asterisks!
        [FindsBy(How = How.XPath, Using = "//h3[text()=\"UK political storm over seized tanker\"]")]
        public IWebElement TopNewsHeader { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[text()=\"Wildfires sweep through central Portugal\"]")]
        public IWebElement SecondaryNewsHeader { get; set; }
    }
}
