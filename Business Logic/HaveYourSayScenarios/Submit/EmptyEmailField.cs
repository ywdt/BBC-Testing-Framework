using BBC_Testing_Framework.Pages.BBC_Pages;
using NUnit.Framework;

namespace BBC_Testing_Framework.Business_Logic.HaveYourSayScenarios.Submit
{
    class EmptyEmailField
    {
        public EmptyEmailField()
        {
            WebDriver.InitializeChromeDriver();
        }

        [Test]
        public void EmptyEmail()
        {
            HaveYourSayPage validation = new HaveYourSayPage();
            validation.EmptyNameAndEmailField(false);
            Assert.AreEqual(validation.InputValues["EmptyEmailError"], validation.BlankEmailErrorMessage.Text);
        }

        [TearDown]
        public void DriverQuit()
        {
            WebDriver.DriverQuit();
        }
    }
}
