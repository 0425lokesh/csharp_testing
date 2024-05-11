using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class BrowserManager
{
    private static IWebDriver driver;

    public static void LaunchBrowser()
    {
        driver = new ChromeDriver();
    }

    public static void CloseBrowser()
    {
        driver.Quit();
    }

    public static void NavigateToUrl(string url)
    {
        driver.Navigate().GoToUrl(url);
    }

    public static IWebElement FindElement(By locator)
    {
        return driver.FindElement(locator);
    }
}
