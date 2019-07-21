using NUnit.Framework;

namespace BBC_Testing_Framework.Business_Logic
{
    public class ArticlesValidation
    {
        public ArticlesValidation()
        {
            WebDriver.IntializeDriver();
        }

        public void MainArticle()
        {
            //WebDriver.IntializeDriver();
            NewsPage mainHeader = new NewsPage();
            Assert.AreEqual(NewsPage.MainHeader, mainHeader.TopNewsHeader.Text);
        }

        public void SecondaryArticle()
        {
            //WebDriver.IntializeDriver();
            NewsPage secondaryHeader = new NewsPage();
            Assert.AreEqual(NewsPage.SecondaryHeader, secondaryHeader.SecondaryNewsHeader.Text);
        }

        [Test]
        public void BothArticlesValidation()
        {
            MainArticle();
            SecondaryArticle();
        }

        [OneTimeTearDown]
        public void DriverQuit()
        {
            WebDriver.DriverQuit();
        }

    }
}
