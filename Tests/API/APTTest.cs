using mvp_health.test.draft.Source.Driver;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvp_health.test.draft.Tests.API
{
    public class APTTest : TestBase
    {

        [Test]
        public void TestGetUsersApi()
        {
            var request = new RestRequest("/users");
            var response = client.Execute(request);
            // ... assertions on response status code, content parsing, etc. ...
        }
    }
}
