using NUnit.Framework;

namespace BBC_Testing_Framework.Business_Logic.SearchResultsScenarios
{
    class InputTagFromTheDictValidatePresence
    {
        public InputTagFromTheDictValidatePresence()
        {
        }

        [SetUp]
        public void Setup()
        {
            WebDriver.InitializeChromeDriver();
            WebDriver.IntializeBBCDriver();
        }

        //TODO Посмотреть, можно ли как-то переделать методы, чтобы не дублировать один и тот же код.
        //Как идея - каким-то образом создать метод, который подставляет значения в поля в методы исходя из входных данных.
        [Test]
        public void ValidationOfTheUKPoliticsTag()
        {
            NewsPage tagValue = new NewsPage();
            SearchResultsPage tagValidation = new SearchResultsPage();

            tagValue.InsertTagIntoTheSearchField("UK Politics");
            Assert.AreEqual(tagValidation.TagAndSearchResultsPairs["UK Politics"], tagValidation.FirstSearchResult.Text);
        }

        [Test]
        public void ValidationOfTheUKTag()
        {
            NewsPage tagValue = new NewsPage();
            SearchResultsPage tagName = new SearchResultsPage();

            tagValue.InsertTagIntoTheSearchField("UK");
            Assert.AreEqual(tagName.TagAndSearchResultsPairs["UK"], tagName.FirstSearchResult.Text);
        }

        [Test]
        public void ValidationOfTheEuropeTag()
        {
            NewsPage tagValue = new NewsPage();
            SearchResultsPage tagName = new SearchResultsPage();

            tagValue.InsertTagIntoTheSearchField("Europe");
            Assert.AreEqual(tagName.TagAndSearchResultsPairs["Europe"], tagName.FirstSearchResult.Text);
        }

        [Test]
        public void ValidationOfTheUSandCanadaTag()
        {
            NewsPage tagValue = new NewsPage();
            SearchResultsPage tagName = new SearchResultsPage();

            tagValue.InsertTagIntoTheSearchField("US & Canada");
            Assert.AreEqual(tagName.TagAndSearchResultsPairs["US & Canada"], tagName.FirstSearchResult.Text);
        }

        [Test]
        public void ValidationOfTheAsiaTag()
        {
            NewsPage tagValue = new NewsPage();
            SearchResultsPage tagName = new SearchResultsPage();

            tagValue.InsertTagIntoTheSearchField("Asia");
            Assert.AreEqual(tagName.TagAndSearchResultsPairs["Asia"], tagName.FirstSearchResult.Text);
        }

        [OneTimeTearDown]
        public void DriverQuit()
        {
            WebDriver.DriverQuit();
        }
    }
}
