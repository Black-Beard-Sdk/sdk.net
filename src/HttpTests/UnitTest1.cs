using Bb;
using Bb.Extensions;
using Bb.Http;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Text.Json;

namespace HttpTests
{
    [TestClass]
    public class UnitTest1
    {


        public UnitTest1()
        {
            Environment.SetEnvironmentVariable("client_id", "urn:oauth:itl:prod:itlivemaps");
            Environment.SetEnvironmentVariable("client_secret", "ugiVZjSEeFTDsJg9H_C9atoEhzLG1dz1XN9eWaXy");
            Environment.SetEnvironmentVariable("username", "g.beard@pickup-services.com");
            Environment.SetEnvironmentVariable("password", null);
        }


        [TestMethod]
        public void TestUrl()
        {

            Url url1 = new Url("https://api.fr");
            Url url2 = "https://api.fr";

            Assert.AreEqual(url1.ToString(), url2.ToString());

            Url url3 = url2.WithPathSegment("adfs/oauth2/token");
            Url url4 = new Url(new Uri("https://api.fr:80"), "adfs", "oauth2", "token");
            Assert.AreEqual(url2.ToString(), url3.ToString());

        }


        [TestMethod]
        public void TestMethodPost1()
        {

            var token = "https://sts.pickup.fr"
                .WithPathSegment("adfs", "oauth2", "token")
                .PostUrlEncodedAsync(new
                {
                    grant_type = "password",
                    username = "@{username}",
                    password = "@{password}",
                    client_id = "@{client_id}",
                    client_secret = "@{client_secret}",
                    scope = "email"
                })
                .As<Oauth2Token>(messageFailed =>
                {

                })
                .Result;

            var datas = "https://pickup.itlivemaps.com"
                .WithPathSegment("oidc", "api", "graphql")
                .WithQueryParam("Instance", "CartographiePickup")
                .WithContentType(ContentType.ApplicationJson)
                .WithOAuthBearerToken(token.access_token)
                .PostAsync(new
                {
                    query = "{ objects( filter: { className:\"Application\", description:\"/(?i).*pudo.*/\" }) { ... on\r\nApplication { id name description } } }"
                })
                .AsString(messageFailed =>
                {

                })
                .Result;

        }


        public class Oauth2Token
        {
            public string access_token { get; set; }
            public string token_type { get; set; }
            public int expires_in { get; set; }
            public string resource { get; set; }
            public string refresh_token { get; set; }
            public int refresh_token_expires_in { get; set; }
            public string id_token { get; set; }
        }

    }


}