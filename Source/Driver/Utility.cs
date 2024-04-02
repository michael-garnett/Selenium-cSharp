using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace mvp_health.test.draft.Source.Driver
{
    public static class Utility
    {
        public static void JsClick(this IWebElement element)
        {
            IWebDriver driver = webDriverManager.GetDriver();
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", element);
        }

        public static void WaitUntilVisible(this IWebElement element, int timeoutInSeconds)
        {
            IWebDriver driver = webDriverManager.GetDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(driver => element.Displayed);
        }
    }
}
