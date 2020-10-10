using GoogleSearchAzureTest.Base;
using GoogleSearchAzureTest.Pages;
using NUnit.Framework;

namespace GoogleSearchAzureTest.TestCases
{
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
