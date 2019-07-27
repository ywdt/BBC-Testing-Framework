using BBC_Testing_Framework.Pages.BBC_Pages;
using NUnit.Framework;

namespace BBC_Testing_Framework.Business_Logic.HaveYourSayScenarios.Screenshots
{
    class MessageBox
    {
        public MessageBox()
        {
        }

        [SetUp]
        public void Setup()
        {
            WebDriver.InitializeChromeDriver();
        }
        //TODO Assertion doesn't work. Couldn't store a value of lipsum to compare.
        [Test]
        public void ValidInputAndScreenshot()
        {
            HaveYourSayPage validation = new HaveYourSayPage();

            validation.ScreenshotAndInputValidation(true);
            //Assert.AreEqual(tempLipsum, validation.MessageInputBox.Text);
        }
        //TODO Assertion doesn't work. NameInputField: but string.Empty instead of JohnBrick.
        [Test]
        public void InvalidInputAndScreenshot()
        {
            HaveYourSayPage validation = new HaveYourSayPage();
            validation.ScreenshotAndInputValidation(false);
            Assert.AreEqual(validation.InputValues["FirstName"], validation.NameInputField.Text);
            Assert.AreEqual(validation.InputValues["Email"], validation.EmailInputField.Text);
            Assert.AreEqual(validation.InputValues["Age"], validation.AgeInputField.Text);
            Assert.AreEqual(validation.InputValues["Postcode"], validation.PostCodeInputField.Text);
        }

        [TearDown]
        public void DriverQuit()
        {
            WebDriver.DriverQuit();
        }
    }
}
