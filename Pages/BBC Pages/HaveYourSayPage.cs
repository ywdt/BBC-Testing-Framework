using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;

namespace BBC_Testing_Framework.Pages.BBC_Pages
{
    class HaveYourSayPage
    {
        public string firstName = "John Brick";
        public string email = "john@john.com";
        public string age = "30";
        public string postcode = "010203";

        public HaveYourSayPage()
        {
            PageFactory.InitElements(WebDriver.Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"orb-modules\"]//span[text()=\"More\"]")]
        public IWebElement MoreButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"orb-modules\"]//div[2]//span[text()=\"Have Your Say\"]")]
        public IWebElement HaveYourSayLink { get; set; }

        //TODO Remake the QuestionLink Xpath
        [FindsBy(How = How.XPath, Using = "//*[@id=\"topos-component\"]/div[4]/div/div[1]/div/div[1]/div/div[2]/div[1]/a")]
        public IWebElement QuestionLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class=\"long-text-input-container\"]/textarea")]
        public IWebElement MessageInputBox { get; set; }

        [FindsBy(How = How.XPath, Using = "*//input[@placeholder=\"Name\"]")]
        public IWebElement NameInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "*//input[@placeholder=\"Email address\"]")]
        public IWebElement EmailInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "*//input[@placeholder=\"Age\"]")]
        public IWebElement AgeInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "*//input[@placeholder=\"Postcode\"]")]
        public IWebElement PostCodeInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "*//div[@class=\"checkbox\"][1]//input[@type = \"checkbox\"]")]
        public IWebElement CheckBoxDailyMails { get; set; }

        [FindsBy(How = How.XPath, Using = "*//div[@class=\"button-container\"]")]
        public IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.XPath, Using = "*//div[@class=\"input-error-message\"][text()=\"Name can't be blank\"]")]
        public IWebElement BlankNameErrorMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "*//div[@class=\"input-error-message\"][text()=\"Email address can't be blank\"]")]
        public IWebElement BlankEmailErrorMessage { get; set; }

        public void NavigateToTextForm()
        {
            WebDriver.IntializeBBCDriver();
            OpenQA.Selenium.Support.UI.WebDriverWait wait = new OpenQA.Selenium.Support.UI.WebDriverWait(WebDriver.Driver, TimeSpan.FromSeconds(30));

            MoreButton.Click();
            HaveYourSayLink.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(QuestionLink));
            QuestionLink.Click();
        }

        public void ValidInputValue()
        {
            LipsumHomePage valid = new LipsumHomePage();
            string validInput = valid.GenerateValidIpsum(true);
            NavigateToTextForm();

            MessageInputBox.SendKeys(validInput);
            NameInputField.SendKeys(firstName);
            EmailInputField.SendKeys(email);
            AgeInputField.SendKeys(age);
            PostCodeInputField.SendKeys(postcode);
            CheckBoxDailyMails.Click();
            Screenshot inputBoxScreenshot = ((ITakesScreenshot)WebDriver.Driver).GetScreenshot();
            inputBoxScreenshot.SaveAsFile(@"C:\Users\mayks\Desktop\Screenshots\validInputBoxScreenshot.png", ScreenshotImageFormat.Png);

        }

        public void InvalidInputValue()
        {
            LipsumHomePage invalid = new LipsumHomePage();
            string invalidInput = invalid.GenerateValidIpsum(false);
            NavigateToTextForm();

            MessageInputBox.SendKeys(invalidInput);
            NameInputField.SendKeys(firstName);
            EmailInputField.SendKeys(email);
            AgeInputField.SendKeys(age);
            PostCodeInputField.SendKeys(postcode);
            CheckBoxDailyMails.Click();

            Screenshot inputBoxScreenshot = ((ITakesScreenshot)WebDriver.Driver).GetScreenshot();
            inputBoxScreenshot.SaveAsFile(@"C:\Users\mayks\Desktop\Screenshots\invalidInputBoxScreenshot.png", ScreenshotImageFormat.Png);
        }

        public void EmptyNameField()
        {
            NavigateToTextForm();

            EmailInputField.SendKeys(email);
            AgeInputField.SendKeys(age);
            PostCodeInputField.SendKeys(postcode);
            CheckBoxDailyMails.Click();
            SubmitButton.Click();
        }

        public void EmptyEmailField()
        {
            NavigateToTextForm();

            NameInputField.SendKeys(firstName);
            AgeInputField.SendKeys(age);
            PostCodeInputField.SendKeys(postcode);
            CheckBoxDailyMails.Click();
            SubmitButton.Click();
        }
    }
}
