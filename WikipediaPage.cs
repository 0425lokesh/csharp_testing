using OpenQA.Selenium;

public class WikipediaPage
{
    private static By TestDrivenDevelopmentSection = By.XPath("//span[@id='Test-driven_development']");

    public static string ExtractTextContentFromTestDrivenDevelopmentSection()
    {
        IWebElement sectionElement = BrowserManager.FindElement(TestDrivenDevelopmentSection);
        return sectionElement.Text;
    }
}
