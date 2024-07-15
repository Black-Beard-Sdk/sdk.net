using Bb;
using Bb.Extensions;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Text.Json;

namespace HttpTests
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestMethod1()
        {

            var adfsUrl = "https://sts.google.fr";          

            var token = adfsUrl.AppendPathSegment("adfs/oauth2/token")
            .PostUrlEncodedAsync(new
            {
                grant_type = "password",
                username = "@{username}",
                password = "@{password}",
                client_id = "@{client_id}",
                client_secret = "@{client_secret}",
                scope="email"
            })
            .MapJson<Oauth2Token>()
            .Result;


            var url = "https://sts.pickup.fr";


            var response = url    //.AppendPathSegment("")
                .WithOAuthBearerToken(token.access_token)
                .GetAsync()
                //.WithRefreshToken(token.refresh_token, ref token.access_token)
                ;

            //var result = response.Result;





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