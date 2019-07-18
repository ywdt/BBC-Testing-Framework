using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBC_Testing_Framework.Pages.BBC_Pages
{
    class HaveYourSayPage
    {
        public HaveYourSayPage()
        {
            PageFactory.InitElements(WebDriver.Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"orb-modules\"]//span[text()=\"More\"]")]
        public IWebElement MoreButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"orb-modules\"]//div[2]//span[text()=\"Have Your Say\"]")]
        public IWebElement HaveYourSayLink { get; set; }

        //Input Box elements:
        [FindsBy(How = How.XPath, Using = "//*[@id=\"topos-component\"]//div[4]//h3[text()=\"Do you have a question for BBC News?\"]")]
        public IWebElement QuestionLink { get; set; }

        [FindsBy(How = How.XPath, Using = "*//div[@class=\"long-text-input-container\"]")]
        public IWebElement MessageInputBox { get; set; }

        [FindsBy(How = How.XPath, Using = "*//div[@class=\"text-input\"]/div[1]")]
        public IWebElement NameInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "*//div[@class=\"text-input\"]/div[2]")]
        public IWebElement EmailInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "*//div[@class=\"text-input\"]/div[3]")]
        public IWebElement AgeInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"hearken-embed-module-3252-1fdaf\"]/div[1]/div[4]/label/input")]
        public IWebElement PostCodeInputField { get; set; }

        //TODO Specify. Currently - 2 elements.
        [FindsBy(How = How.XPath, Using = "*//input[@type=\"checkbox\"]")]
        public IWebElement CheckBoxDailyMails { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()=\"Submit\"]")]
        public IWebElement SubmitButton { get; set; }
    }
}
