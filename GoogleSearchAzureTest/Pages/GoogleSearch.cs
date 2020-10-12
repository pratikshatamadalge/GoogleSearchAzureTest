namespace GoogleSearchAzureTest.Pages
{
    using OpenQA.Selenium;
    using System.Threading;
    using SeleniumExtras.PageObjects;
    using System.Configuration;
    public class GoogleSearch
    {
        readonly string searchText = ConfigurationManager.AppSettings["SearchText"];
        public IWebDriver driver;

        public GoogleSearch(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='viewport']/div[@id='searchform']/form[@id='tsf']/div[2]/div[1]/div[1]/div[1]/div[2]/input[1]")]
        IWebElement Search { get; set; }

        public void SearchPage()
        {
            Thread.Sleep(3000);
            Search.SendKeys("Automation Testing"+Keys.Enter);
            Thread.Sleep(5000);
        }
    }
}
