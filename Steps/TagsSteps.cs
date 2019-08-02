﻿using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BBC_Testing_Framework.Steps
{
    [Binding]

    public class TagsSteps
    {
        //Disabled "ScenarioContext is obsolete" warning message.
#pragma warning disable 0618
        public TagsSteps()
        {
        }
        NewsPage newsPage = new NewsPage();
        SearchResultsPage searchResults = new SearchResultsPage();
        //TODO Consider remake it as mentioned in this article: https://cucumber.io/docs/gherkin/step-organization/
        [Given(@"I have opened the bbc\.com/news web page")]
        public void GivenIHaveOpenedTheBbc_ComNewsWebPage()
        {
            WebDriver.IntializeBBCDriver();
        }

        [When(@"I copy the tag from the top story")]
        public void WhenICopyTheTagFromTheTopStory()
        {
            ScenarioContext.Current["tempTag"] = newsPage.Tag.Text;
        }

        [When(@"I paste that tag into the search field")]
        public void IPasteThatTagIntoTheSearchField()
        {
            newsPage.SearchField.SendKeys(ScenarioContext.Current["tempTag"].ToString());
        }

        [When(@"I click on the search")]
        public void WhenIClickOnTheSearchButton()
        {
            newsPage.SearchButton.Click();
        }

        [Then(@"the first search result should match")]
        public void ThenTheFirstSearchResultShouldMatch()
        {
            Assert.AreEqual(searchResults.TagAndSearchResultsPairs[ScenarioContext.Current["tempTag"].ToString()], searchResults.FirstSearchResult.Text);
        }

        //"Validation of the search results" scenario
        [When(@"I have entered '(.*)' as search keyword")]
        public void GivenIHaveEnteredAsSearchKeyword(string tag)
        {
            newsPage.SearchField.SendKeys(tag);
        }

        [When(@"I press the search button")]
        public void WhenIPressTheSearchButton()
        {
            newsPage.SearchButton.Click();
        }
        [Then(@"the '(.*)' should correspond with the '(.*)'")]
        public void ThenTheShouldCorrespondWithThe(string searchResult, string tag)
        {
            Assert.AreEqual(searchResult, searchResults.FirstSearchResult.Text);
        }

    }
}
