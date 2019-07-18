using NUnit.Framework;

namespace BBC_Testing_Framework.Test_Scenarios
{
    class Validation_Of_The_Secondary_Article_Header
    {
        public Validation_Of_The_Secondary_Article_Header()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            WebDriver.IntializeDriver();
        }

        [Test]
        public void PresenceOfTheSecondaryHeader()
        {
            NewsPage secondaryHeader = new NewsPage();
            Assert.AreEqual(NewsPage.SecondaryHeader, secondaryHeader.SecondaryNews.Text);
        }

        [OneTimeTearDown]
        public void DriverQuit()
        {
            WebDriver.DriverQuit();
        }
    }
}
