using NUnit.Framework;

namespace BBC_Testing_Framework.Business_Logic.NewsPageScenarios
{
    class PresenceOfTheArticles
    {
        public PresenceOfTheArticles()
        {
        }

        [SetUp]
        public void Setup()
        {
            WebDriver.InitializeChromeDriver();
            WebDriver.IntializeBBCDriver();
        }

        [Test]
        public void TopStoryPresenceValidation()
        {
            NewsPage validation = new NewsPage();
            Assert.IsTrue(validation.FirstTopStoryPresence.Displayed);
        }
        [Test]
        public void SecondStoryPresenceValidation()
        {
            NewsPage validation = new NewsPage();
            Assert.IsTrue(validation.SecondTopStoryPresence.Displayed);
        }

        [TearDown]
        public void DriverQuit()
        {
            WebDriver.DriverQuit();
        }
    }
}
