using mvp_health.test.draft.Source.Driver;
using mvp_health.test.draft.Source.Pages;


namespace mvp_health.test.draft.Tests.Ui
{
    public class HomeTest : TestBase
    {
        [Test]
        public void simpleSearch()
        {
            HomePage homepage = new HomePage();
            homepage.openApp();
            homepage.search("Test");
        }

    }
}
