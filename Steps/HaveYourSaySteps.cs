using BBC_Testing_Framework.Pages.BBC_Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using TechTalk.SpecFlow;

namespace BBC_Testing_Framework.Steps
{
    [Binding]
    public sealed class HaveYourSaySteps
    {
        private readonly ScenarioContext context;

        public HaveYourSaySteps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            WebDriver.IntializeIpsumDriver();
            LipsumHomePage generateIpsum = new LipsumHomePage();

            generateIpsum.BytesButton.Click();
            generateIpsum.AmountField.Clear();
            generateIpsum.AmountField.SendKeys(LipsumHomePage.InputBytes);
            generateIpsum.GenerateButton.Click();

            context["generatedIpsum"] = generateIpsum.GeneratedIpsum.Text;
        }

        //TODO https://specflow.org/documentation/Context-Injection/
        HaveYourSayPage sayPage = new HaveYourSayPage();

        [When(@"I click on More")]
        public void WhenIClickOnMore()
        {
            sayPage.MoreButton.Click();
        }

        [When(@"I click on HaveYourSay")]
        public void WhenIClickOnHaveYourSay()
        {
            sayPage.HaveYourSayLink.Click();
        }

        [When(@"I click on question link")]
        public void WhenIClickOnQuestionLink()
        {
            sayPage.QuestionLink.Click();
        }

        [When(@"have your say page is opened")]
        public void WhenHaveYourSayPageIsOpened()
        {
            OpenQA.Selenium.Support.UI.WebDriverWait wait = new OpenQA.Selenium.Support.UI.WebDriverWait(WebDriver.Driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"asset-type-sty\"]")));
        }

        [When(@"Message input box is filled with the '(.*)'")]
        public void WhenMessageInputBoxIsFilledWithThe(string inputData)
        {
            if (inputData == "Valid Input")
            {
                sayPage.MessageInputBox.SendKeys(context["generatedIpsum"].ToString().Substring(0, 140));
            }
            else
            {
                sayPage.MessageInputBox.SendKeys(context["generatedIpsum"].ToString());
            }
        }

        [When(@"I filled other input fields")]
        public void WhenIFilledOtherInputFields()
        {
            //TODO https://specflow.org/documentation/FeatureContext/
            sayPage.NameInputField.SendKeys(sayPage.InputValues["FirstName"]);
            sayPage.EmailInputField.SendKeys(sayPage.InputValues["Email"]);
            sayPage.AgeInputField.SendKeys(sayPage.InputValues["Age"]);
            sayPage.PostCodeInputField.SendKeys(sayPage.InputValues["Postcode"]);
        }

        [When(@"checked that I signed up for daily news")]
        public void WhenCheckedThatISignedUpForDailyNews()
        {
            sayPage.CheckBoxDailyMails.Click();
        }


        [Then(@"the length of the message input box should equals '(.*)'")]
        public void ThenTheLengthOfTheMessageInputBoxShouldEquals(int generatedTextLength)
        {
            if (generatedTextLength == 140)
            {
                Assert.IsTrue(sayPage.MessageInputBox.GetAttribute("value").Length == generatedTextLength);
            }
            else
            {
                Assert.AreEqual(sayPage.InputValues["FirstName"], sayPage.NameInputField.GetAttribute("value"));
                Assert.AreEqual(sayPage.InputValues["Email"], sayPage.EmailInputField.GetAttribute("value"));
                Assert.AreEqual(sayPage.InputValues["Age"], sayPage.AgeInputField.GetAttribute("value"));
                Assert.AreEqual(sayPage.InputValues["Postcode"], sayPage.PostCodeInputField.GetAttribute("value"));
            }
        }

        [Then(@"'(.*)' is taken")]
        public void ThenIsTaken(string validInput)
        {
            if (validInput == "ValidInputScreenshot")
            {
                Screenshot inputBoxScreenshot = ((ITakesScreenshot)WebDriver.Driver).GetScreenshot();
                inputBoxScreenshot.SaveAsFile(@"C:\Users\mayks\Desktop\Screenshots\validInputBoxScreenshot.png", ScreenshotImageFormat.Png);
            }
            else
            {
                Screenshot inputBoxScreenshot = ((ITakesScreenshot)WebDriver.Driver).GetScreenshot();
                inputBoxScreenshot.SaveAsFile(@"C:\Users\mayks\Desktop\Screenshots\invalidInputBoxScreenshot.png", ScreenshotImageFormat.Png);
            }

        }
    }
}