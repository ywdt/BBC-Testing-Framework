using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBC_Testing_Framework
{
    class LipsumHomePage
    {
        public const string URL = "https://lipsum.com";
        public const string InputBytes = "141";

        public LipsumHomePage()
        {
            PageFactory.InitElements(WebDriver.Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"bytes\"]")]
        public IWebElement BytesButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"amount\"]")]
        public IWebElement AmountField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"generate\"]")]
        public IWebElement GenerateButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"lipsum\"]")]
        public IWebElement GeneratedIpsum { get; set; }

        public void GenerateIpsumSteps()
        {
            WebDriver.IntializeIpsumDriver();
            LipsumHomePage generateIpsum = new LipsumHomePage();

            generateIpsum.BytesButton.Click();
            generateIpsum.AmountField.Clear();
            generateIpsum.AmountField.SendKeys(InputBytes);
            generateIpsum.GenerateButton.Click();
        }

        //public string GenerateValidIpsum(bool validInput)
        //{
        //    WebDriver.IntializeIpsumDriver();
        //    LipsumHomePage generateIpsum = new LipsumHomePage();

        //    generateIpsum.BytesButton.Click();
        //    generateIpsum.AmountField.Clear();
        //    generateIpsum.AmountField.SendKeys(InputBytes);
        //    generateIpsum.GenerateButton.Click();
        //    if (validInput == true)
        //    {
        //        string validData = generateIpsum.GeneratedIpsum.Text.Substring(0, 140);
        //        return validData;
        //    }
        //    else
        //    {
        //        string invalidData = generateIpsum.GeneratedIpsum.Text.Substring(0, 141);
        //        return invalidData;
        //    }
        //}
    }
}
