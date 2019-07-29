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

        [Test]
        public void ValidInputAndScreenshot()
        {
            HaveYourSayPage validation = new HaveYourSayPage();

            validation.ScreenshotAndInputValidation(true);
            Assert.IsTrue(validation.MessageInputBox.GetAttribute("value").Length == 140);
        }

        [Test]
        public void InvalidInputAndScreenshot()
        {
            HaveYourSayPage validation = new HaveYourSayPage();
            validation.ScreenshotAndInputValidation(false);

            Assert.AreEqual(validation.InputValues["FirstName"], validation.NameInputField.GetAttribute("value"));
            Assert.AreEqual(validation.InputValues["Email"], validation.EmailInputField.GetAttribute("value"));
            Assert.AreEqual(validation.InputValues["Age"], validation.AgeInputField.GetAttribute("value"));
            Assert.AreEqual(validation.InputValues["Postcode"], validation.PostCodeInputField.GetAttribute("value"));
        }

        [TearDown]
        public void DriverQuit()
        {
            WebDriver.DriverQuit();
        }
    }
}
