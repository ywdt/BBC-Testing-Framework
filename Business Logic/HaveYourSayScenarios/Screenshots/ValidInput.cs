using BBC_Testing_Framework.Pages.BBC_Pages;
using NUnit.Framework;

namespace BBC_Testing_Framework.Business_Logic.HaveYourSayScenarios.Screenshots
{
    class ValidInput
    {
        public ValidInput()
        {
            WebDriver.InitializeChromeDriver();
        }

        [Test]
        public void ValidInputAndScreenshot()
        {
            HaveYourSayPage validation = new HaveYourSayPage();
            validation.ScreenshotAndInputValidation(true);
            //Assert.AreEqual(validation.InputValues["FirstName"], validation.NameInputField.Text);
            //Assert.AreEqual(validation.InputValues["Email"], validation.EmailInputField.Text);
            //Assert.AreEqual(validation.InputValues["Age"], validation.AgeInputField.Text);
            //Assert.AreEqual(validation.InputValues["Postcode"], validation.PostCodeInputField.Text);
        }

        [TearDown]
        public void DriverQuit()
        {
            WebDriver.DriverQuit();
        }
    }
}
