using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BBC_Testing_Framework.Steps
{
    [Binding]

    public sealed class TagsSteps
    {
        private readonly ScenarioContext context;

        public TagsSteps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        readonly NewsPage newsPage = new NewsPage();
        readonly SearchResultsPage searchResults = new SearchResultsPage();

        [Given(@"I have opened the bbc\.com/news web page")]
        public void GivenIHaveOpenedTheBbc_ComNewsWebPage()
        {
            WebDriver.IntializeBBCDriver();
        }

        [When(@"I copy the tag from the top story")]
        public void WhenICopyTheTagFromTheTopStory()
        {
            context["tempTag"] = newsPage.Tag.Text;
        }

        [When(@"I paste that tag into the search field")]
        public void IPasteThatTagIntoTheSearchField()
        {
            newsPage.SearchField.SendKeys(context["tempTag"].ToString());
        }

        [When(@"I click on the search")]
        public void WhenIClickOnTheSearchButton()
        {
            newsPage.SearchButton.Click();
        }

        [Then(@"the first search result should match")]
        public void ThenTheFirstSearchResultShouldMatch()
        {
            Assert.AreEqual(searchResults.TagAndSearchResultsPairs[context["tempTag"].ToString()], searchResults.FirstSearchResult.Text);
        }

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
        [Then(@"the '(.*)' should correspond with the Tag")]
        public void ThenTheShouldCorrespondWithThe(string searchResult)
        {
            Assert.AreEqual(searchResult, searchResults.FirstSearchResult.Text);
        }

    }
}
