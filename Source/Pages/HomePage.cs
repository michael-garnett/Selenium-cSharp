using mvp_health.test.draft.Source.Driver;
using OpenQA.Selenium;

namespace mvp_health.test.draft.Source.Pages
{
    public class HomePage : TestBase
    {
        private IWebElement searchBtn => GetDriver().FindElement(By.XPath("//section[@id='middle-header']//div//div//div//a[@href='#']"));
        private IWebElement searchTxt => GetDriver().FindElement(By.XPath("(//input[@placeholder='Search...'])[1]"));
        private IWebElement searchResults => GetDriver().FindElement(By.XPath("//div[@class='showing-reults-text']"));



        public void openApp()
        {
            GetDriver().Manage().Window.Maximize();
            GetDriver().Navigate().GoToUrl("https://www.mvphealthcare.com/");
        }

        public void search(string searchText)
        {
            searchBtn.JsClick();
            searchTxt.SendKeys(searchText + Keys.Enter);
            searchResults.WaitUntilVisible(5);
            Assert.That(searchResults.Text, Is.EqualTo("Showing results for 'Test'"));
            //Thread.Sleep(5000);
        }

    }
}
