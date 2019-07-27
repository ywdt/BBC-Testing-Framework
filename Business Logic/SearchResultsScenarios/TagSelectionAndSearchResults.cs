using NUnit.Framework;

namespace BBC_Testing_Framework.Business_Logic.SearchResultsScenarios
{
    class TagSelectionAndSearchResults
    {
        public TagSelectionAndSearchResults()
        {
        }

        [SetUp]
        public void Setup()
        {
            WebDriver.InitializeChromeDriver();
            WebDriver.IntializeBBCDriver();
        }


        [Test]
        public void TagSelectionAndSearchValidation()
        {
            NewsPage tagValue = new NewsPage();
            SearchResultsPage searchResults = new SearchResultsPage();
            string tempTagValue = tagValue.Tag.Text;

            tagValue.SelectTagAndPutItIntoTheSearchField();
            Assert.AreEqual(searchResults.TagAndSearchResultsPairs[tempTagValue], searchResults.FirstSearchResult.Text);

        }

        [TearDown]
        public void DriverQuit()
        {
            WebDriver.DriverQuit();
        }
    }
}
