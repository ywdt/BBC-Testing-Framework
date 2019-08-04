using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace BBC_Testing_Framework.Pages.BBC_Pages
{
    class HaveYourSayPage
    {
        internal readonly Dictionary<string, string> InputValues = new Dictionary<string, string>()
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
        internal IWebElement MoreButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"orb-modules\"]//div[2]//span[text()=\"Have Your Say\"]")]
        internal IWebElement HaveYourSayLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"topos-component\"]/div[4]/div/div[1]/div/div[1]/div/div[2]/div[1]/a")]
        internal IWebElement QuestionLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class=\"long-text-input-container\"]/textarea")]
        internal IWebElement MessageInputBox { get; set; }

        [FindsBy(How = How.XPath, Using = "*//input[@placeholder=\"Name\"]")]
        internal IWebElement NameInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "*//input[@placeholder=\"Email address\"]")]
        internal IWebElement EmailInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "*//input[@placeholder=\"Age\"]")]
        internal IWebElement AgeInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "*//input[@placeholder=\"Postcode\"]")]
        internal IWebElement PostCodeInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "*//div[@class=\"checkbox\"][1]//input[@type = \"checkbox\"]")]
        internal IWebElement CheckBoxDailyMails { get; set; }

        [FindsBy(How = How.XPath, Using = "*//div[@class=\"button-container\"]")]
        internal IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.XPath, Using = "*//div[@class=\"input-error-message\"][text()=\"Name can't be blank\"]")]
        internal IWebElement BlankNameErrorMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "*//div[@class=\"input-error-message\"][text()=\"Email address can't be blank\"]")]
        internal IWebElement BlankEmailErrorMessage { get; set; }
    }
}
