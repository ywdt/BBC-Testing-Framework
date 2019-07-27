using BBC_Testing_Framework.Pages.BBC_Pages;
using NUnit.Framework;

namespace BBC_Testing_Framework.Business_Logic.HaveYourSayScenarios.Submit
{
    class InputFields
    {
        public InputFields()
        {
        }

        [SetUp]
        public void Setup()
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
