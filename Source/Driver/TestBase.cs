using RestSharp;

namespace mvp_health.test.draft.Source.Driver
{
    public class TestBase : webDriverManager
    {
        public static RestClient client;

        [SetUp]
        public void setup()
        {

            InitializeDriver();
            client = new RestClient("https://api.example.com");
        }

        [TearDown]
        protected void cleanUp()
        {
            client.Dispose();
            DisableDriver();
        }

    }
}
