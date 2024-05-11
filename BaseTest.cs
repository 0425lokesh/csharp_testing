namespace selenium_automation_testing
{

    using NUnit.Framework;
    public class BaseTest
    {
        [SetUp]
        public void OneTimeSetup()
        {
            BrowserManager.LaunchBrowser();
        }
        [TearDown]
        public void OneTimeTearDown()
        {
            BrowserManager.CloseBrowser();
        }
    }
}
