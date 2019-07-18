using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBC_Testing_Framework
{
    class LipsumHomePage
    {
        public const string InputBytes = "141";

        public LipsumHomePage()
        {
            PageFactory.InitElements(WebDriver.Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"bytes\"]")]
        private IWebElement BytesButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"amount\"]")]
        private IWebElement AmountField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"generate\"]")]
        private IWebElement GenerateButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"lipsum\"]")]
        private IWebElement GeneratedIpsum { get; set; }

        public static string GenerateIpsum(bool validInput)
        {
            LipsumHomePage generateIpsum = new LipsumHomePage();

            generateIpsum.BytesButton.Click();
            generateIpsum.AmountField.Clear();
            generateIpsum.AmountField.SendKeys(LipsumHomePage.InputBytes);
            generateIpsum.GenerateButton.Click();

            if (validInput == true)
            {
                string validData = generateIpsum.GeneratedIpsum.Text.Substring(0, 140);
                return validData;
            }
            else
            {
                string invalidData = generateIpsum.GeneratedIpsum.Text.Substring(0, 141);
                return invalidData;
            }
        }
    }
}
