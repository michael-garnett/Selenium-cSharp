using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace mvp_health.test.draft.Source.Driver
{
    public class webDriverManager
    {
        private static IWebDriver driver;

        public static void InitializeDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }

        public static void DisableDriver()
        {
            driver.Dispose();
            driver.Quit();
        }

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                throw new InvalidOperationException("Driver has not been initialized. Call InitializeDriver method first.");
            }
            return driver;
        }
    }
}
