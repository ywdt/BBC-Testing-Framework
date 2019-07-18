using NUnit.Framework;

namespace BBC_Testing_Framework.Test_Scenarios
{
    class Tag_Validation_And_Search
    {
        public Tag_Validation_And_Search()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            WebDriver.IntializeDriver();
        }

        [Test]
        public void PresenceOfTheTag()
        {
            NewsPage tag = new NewsPage();
            Assert.AreEqual(NewsPage.TagName, tag.Tag.Text);
        }

        [Test]
        public void SearchResults()
        {
            NewsPage tag = new NewsPage();
            Assert.AreEqual(SearchResultsPage.ResultHeader, tag.Tag.Text);
        }

        [OneTimeTearDown]
        public void DriverQuit()
        {
            WebDriver.DriverQuit();
        }
    }
}
