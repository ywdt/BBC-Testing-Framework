using NUnit.Framework;

namespace BBC_Testing_Framework.Test_Scenarios
{
    class Validation_Of_The_Main_Article_Header
    {
        public Validation_Of_The_Main_Article_Header()
        {
        }

        [OneTimeSetUp]
        public void Intialize()
        {
            WebDriver.IntializeDriver();

        }

        [Test]
        public void PresenceOfTheMainHeader()
        {
            NewsPage mainHeader = new NewsPage();
            Assert.AreEqual(NewsPage.MainHeader, mainHeader.TopNews.Text);
        }

        [OneTimeTearDown]
        public void DriverQuit()
        {
            WebDriver.DriverQuit();
        }
    }
}
