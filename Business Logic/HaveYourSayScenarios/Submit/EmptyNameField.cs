using BBC_Testing_Framework.Pages.BBC_Pages;
using NUnit.Framework;

namespace BBC_Testing_Framework.Business_Logic.HaveYourSayScenarios.Submit
{
    class EmptyNameField
    {
        public EmptyNameField()
        {
        }

        [SetUp]
        public void Setup()
        {
            WebDriver.InitializeChromeDriver();
        }

        [Test]
        public void EmptyName()
        {
            HaveYourSayPage validation = new HaveYourSayPage();
            validation.EmptyNameAndEmailField(true);
            Assert.AreEqual(validation.InputValues["EmptyNameError"], validation.BlankNameErrorMessage.Text);
        }

        [TearDown]
        public void DriverQuit()
        {
            WebDriver.DriverQuit();
        }
    }
}
