using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Threading;

namespace BBC_Testing_Framework.Pages.BBC_Pages
{
    class HaveYourSayPage
    {
        public Dictionary<string, string> InputValues = new Dictionary<string, string>()
        {
            ["FirstName"] = "JohnBrick",
            ["Email"] = "john@john.com",
            ["Age"] = "30",
            ["Postcode"] = "010203",
            ["EmptyNameError"] = "Name can't be blank",
            ["EmptyEmailError"] = "Email address can't be blank"
        };

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

            MoreButton.Click();
            HaveYourSayLink.Click();
            QuestionLink.Click();
        }

        public void NameEmailAgePostCheckboxInputFields(bool validInput)
        {
            NameInputField.SendKeys(InputValues["FirstName"]);
            EmailInputField.SendKeys(InputValues["Email"]);
            AgeInputField.SendKeys(InputValues["Age"]);
            PostCodeInputField.SendKeys(InputValues["Postcode"]);
            CheckBoxDailyMails.Click();

            if (validInput == true)
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

        public void AgePostCheckboxSumbit()
        {
            AgeInputField.SendKeys(InputValues["Age"]);
            PostCodeInputField.SendKeys(InputValues["Postcode"]);
            CheckBoxDailyMails.Click();
            SubmitButton.Click();
            Thread.Sleep(1000);
        }

        public void ScreenshotAndInputValidation(bool ValidInput)
        {
            LipsumHomePage ipsum = new LipsumHomePage();

            ipsum.GenerateIpsumSteps();
            string generatedIpsum = ipsum.GeneratedIpsum.Text;
            NavigateToTextForm();

            if (ValidInput == true)
            {
                generatedIpsum.Substring(0, 140);
                MessageInputBox.SendKeys(generatedIpsum);
                NameEmailAgePostCheckboxInputFields(true);
            }
            else
            {
                MessageInputBox.SendKeys(generatedIpsum);
                NameEmailAgePostCheckboxInputFields(false);
            };
        }

        public void EmptyNameAndEmailField(bool emptyNameField)
        {
            NavigateToTextForm();
            if (emptyNameField == true)
            {
                EmailInputField.SendKeys(InputValues["Email"]);
                AgePostCheckboxSumbit();
            }
            else
            {
                NameInputField.SendKeys(InputValues["FirstName"]);
                AgePostCheckboxSumbit();
            }
            Thread.Sleep(3000);
        }
    }
}
