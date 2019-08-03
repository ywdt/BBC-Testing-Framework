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
        private readonly ScenarioContext context;
        NewsPage newsPage = new NewsPage();

        public TopStoriesSteps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Given(@"I have opened bbc\.com/news web page")]
        public void GivenIHaveOpenedBbc_ComNewsWebPage()
        {
            WebDriver.IntializeBBCDriver();
        }

        [When(@"News page is opened")]
        public void WhenNewsPageIsOpened()
        {
            //OpenQA.Selenium.Support.UI.WebDriverWait wait = new OpenQA.Selenium.Support.UI.WebDriverWait(WebDriver.Driver, TimeSpan.FromSeconds(3));
            //wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@data-entityid=\"container-top-stories#1\"]")));
        }

        [Then(@"the top story should be present")]
        public void ThenTheTopStoryShouldBePresent()
        {
            Assert.IsTrue(newsPage.FirstTopStoryPresence.Displayed);
        }

        [Then(@"the second top story should be present")]
        public void ThenTheSecondTopStoryShouldBePresent()
        {
            Assert.IsTrue(newsPage.SecondTopStoryPresence.Displayed);
        }

    }
}
