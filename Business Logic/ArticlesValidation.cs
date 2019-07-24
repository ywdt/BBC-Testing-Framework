using NUnit.Framework;

namespace BBC_Testing_Framework.Business_Logic
{
    public class ArticlesValidation
    {
        public ArticlesValidation()
        {
            WebDriver.InitializeChromeDriver();
            WebDriver.IntializeBBCDriver();
        }

        public static void MainArticle()
        {
            NewsPage mainHeader = new NewsPage();
            Assert.AreEqual(NewsPage.MainHeader, mainHeader.TopNewsHeader.Text);
        }

        public static void SecondaryArticle()
        {
            NewsPage secondaryHeader = new NewsPage();
            Assert.AreEqual(NewsPage.SecondaryHeader, secondaryHeader.SecondaryNewsHeader.Text);
        }

        [Test]
        public void BothArticlesValidation()
        {
            MainArticle();
            SecondaryArticle();
        }

        [TearDown]
        public void DriverQuit()
        {
            WebDriver.DriverQuit();
        }

    }
}
