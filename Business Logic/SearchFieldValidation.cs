using NUnit.Framework;

namespace BBC_Testing_Framework.Business_Logic
{
    class SearchFieldValidation
    {
        public SearchFieldValidation()
        {
            WebDriver.IntializeBBCDriver();
        }

        public void SearchField()
        {
            SearchResultsPage searchResults = new SearchResultsPage();
            searchResults.TagInputAndClickOnTheSearchButton();
            Assert.AreEqual("UK", searchResults.Tag.Text);

        }

        [Test]
        public void ValidateTheSearchField()
        {
            SearchField();
        }

        [OneTimeTearDown]
        public void DriverQuit()
        {
            WebDriver.DriverQuit();
        }
    }
}
