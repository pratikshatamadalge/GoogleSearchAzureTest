namespace GoogleSearchAzureTest.TestCases
{
    using GoogleSearchAzureTest.Base;
    using GoogleSearchAzureTest.Pages;
    using NUnit.Framework;
    public class GoogleTest:BaseClass
    {
       [Test]
       public void SearchTest()
        {
            GoogleSearch search = new GoogleSearch(driver);
            search.SearchPage();
        }
    }
}
