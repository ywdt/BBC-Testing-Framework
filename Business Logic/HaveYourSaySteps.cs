using BBC_Testing_Framework.Pages.BBC_Pages;
using NUnit.Framework;

namespace BBC_Testing_Framework.Business_Logic
{
    class HaveYourSaySteps
    {
        public HaveYourSaySteps()
        {
            //WebDriver.IntializeIpsumDriver();
            WebDriver.IntializeBBCDriver();
        }

        public void HaveYourSayLogic()
        {
            HaveYourSayPage valid = new HaveYourSayPage();
            valid.ValidInputValue();
            Assert.That(valid.MessageInputBox.Text.Length == 140);
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
