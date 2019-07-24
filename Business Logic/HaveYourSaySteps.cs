using BBC_Testing_Framework.Pages.BBC_Pages;
using NUnit.Framework;

namespace BBC_Testing_Framework.Business_Logic
{
    class HaveYourSaySteps
    {
        public HaveYourSaySteps()
        {
            WebDriver.InitializeChromeDriver();
        }

        public void HaveYourSayLogic()
        {
            HaveYourSayPage valid = new HaveYourSayPage();
            valid.ValidInputValue();
            Assert.AreEqual(140, valid.MessageInputBox.Text.Length);
        }

        [Test]
        public void ValidAssertion()
        {
            HaveYourSayLogic();
        }

        [OneTimeTearDown]
        public void DriverQuit()
        {
            WebDriver.DriverQuit();
        }
    }
}
