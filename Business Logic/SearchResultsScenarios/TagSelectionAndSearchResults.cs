using NUnit.Framework;
using System.Threading;

namespace BBC_Testing_Framework.Business_Logic.SearchResultsScenarios
{
    class TagSelectionAndSearchResults
    {
        public TagSelectionAndSearchResults()
        {
            WebDriver.InitializeChromeDriver();
            WebDriver.IntializeBBCDriver();
        }

        [Test]
        public void TagSelectionAndSearchValidation()
        {
            NewsPage tagValue = new NewsPage();
            SearchResultsPage validationOfTheTag = new SearchResultsPage();
            //tag name string
            string tempTag = tagValue.Tag.Text;


            //tagValidation.InsertTagIntoSearchField();
            //string actualTag = tagValidation.ReturnTagName();
            //validation.TagInputAndClickOnTheSearchButton();
            Thread.Sleep(3000);
            //Assert.AreEqual(validation.TagNameAssertion(tagValidation), validation.FirstSearchResult.Text);
            //Assert.AreEqual(validation.TagAndSearchResultsPairs, validation.FirstSearchResult.Text);
            //Assert.AreEqual(validation.FirstSearchResult.Text, tagValidation.ReturnTagName());
        }

        [TearDown]
        public void DriverQuit()
        {
            WebDriver.DriverQuit();
        }
    }
}
