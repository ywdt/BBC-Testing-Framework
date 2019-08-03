using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using TechTalk.SpecFlow;

namespace BBC_Testing_Framework.Steps
{
    [Binding]
    public sealed class TopStoriesSteps
    {
        public TopStoriesSteps()
        {
        }

        [Given(@"I have opened bbc\.com/news web page")]
        public void GivenIHaveOpenedBbc_ComNewsWebPage()
        {
            WebDriver.IntializeBBCDriver();
        }

        [When(@"News page is opened")]
        public void WhenNewsPageIsOpened()
        {
            OpenQA.Selenium.Support.UI.WebDriverWait wait = new OpenQA.Selenium.Support.UI.WebDriverWait(WebDriver.Driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"responsive-news\"]/body")));
        }

        [Then(@"the '(.*)' should be present")]
        public void ThenTheShouldBePresent(string storyXpath)
        {
            var xPath = WebDriver.Driver.FindElement(By.XPath(storyXpath));
            Assert.IsTrue(xPath.Displayed);
        }
    }
}
