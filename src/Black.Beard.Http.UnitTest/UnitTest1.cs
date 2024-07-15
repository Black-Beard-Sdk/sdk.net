using Bb.Extensions;
using Bb.Http.Testing;
using System;

namespace Black.Beard.Http.UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public async Task TestMethod1Async()
        {

            var person = await "https://sts.pickup.fr"
                .AppendPathSegment("adfs/oauth2/token")
                //.SetQueryParams(new { a = 1, b = 2 })
                //.WithOAuthBearerToken("my_oauth_token")
                .PostUrlEncodedAsync(new
                {
                    grant_type = "password",
                    username = "g.beard@pickup-services.com",
                    password="Camille(31)+",
                    client_id= "urn:oauth:itl:prod:itlivemaps",
                    client_secret= "ugiVZjSEeFTDsJg9H_C9atoEhzLG1dz1XN9eWaXy"
                })
                .MapJson<Oauth2Token>();





        }
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