// Ignore Spelling: Auth

using Bb.Curls;
using RestSharp;
using System.Net;
using WireMock.RequestBuilders;
using WireMock.ResponseBuilders;
using WireMock.Server;
using Xunit;

namespace Black.Beard.Rest.UnitTest
{

    namespace Black.Beard.Rest.UnitTest
    {

        public class ClientUnitTest
        {

            [Theory]
            [InlineData("--request", "POST")]
            [InlineData("-X", "GET")]
            [InlineData("--request", "PUT")]
            public void ParseCurlLine_Request(string option, string method)
            {

                var request = Request.Create().WithPath("/");
                if (method == "POST")
                    request.UsingPost();

                else if (method == "GET")
                    request.UsingGet();

                else if (method == "PUT")
                    request.UsingPut();

                var server = WireMockServer.Start();
                server.Given(request)
                    .RespondWith(Response.Create().WithStatusCode(HttpStatusCode.OK));

                // Arrange
                var response = $"curl {option} {method} http://example.com"
                    .AsCurl()
                    .CallAsync();

            }

            [Theory]
            [InlineData("--header", "Content-Type: application/json")]
            [InlineData("-H", "Authorization: Bearer token")]
            public void ParseCurlLine_Header(string option, string header)
            {
                // Arrange
                var curlLine = $"curl {option} \"{header}\" http://example.com".ParseCurlLine();
                
            }

            [Theory]
            [InlineData("--form", "file=@/path/to/file")]
            [InlineData("-F", "name=value")]
            public void ParseCurlLine_Form(string option, string formData)
            {
                // Arrange
                var curlLine = $"curl {option} \"{formData}\" http://example.com".ParseCurlLine();
                
            }

            [Theory]
            [InlineData("--data", "key1=value1&key2=value2")]
            [InlineData("-d", "key=value")]
            public void ParseCurlLine_Data(string option, string data)
            {
                // Arrange
                var curlLine = $"curl {option} \"{data}\" http://example.com".ParseCurlLine();

            }

            [Theory]
            [InlineData("--cookie", "name=value")]
            [InlineData("-b", "name=value")]
            public void ParseCurlLine_Cookie(string option, string cookie)
            {
                // Arrange
                var curlLine = $"curl {option} \"{cookie}\" http://example.com".ParseCurlLine();
                
            }

            [Theory]
            [InlineData("--cookie-jar", "/path/to/cookiejar")]
            [InlineData("-c", "/path/to/cookiejar")]
            public void ParseCurlLine_CookieJar(string option, string cookieJar)
            {
                // Arrange
                var curlLine = $"curl {option} \"{cookieJar}\" http://example.com".ParseCurlLine();
             
            }

            [Theory]
            [InlineData("--user", "user:password")]
            [InlineData("-u", "user:password")]
            public void ParseCurlLine_User(string option, string user)
            {
                // Arrange
                var curlLine = $"curl {option} \"{user}\" http://example.com".ParseCurlLine();
             
            }

            [Theory]
            [InlineData("--oauth2-bearer", "your_token_here")]
            public void ParseCurlLine_OAuth2Bearer(string option, string token)
            {
                // Arrange
                var curlLine = $"curl {option} \"{token}\" http://example.com".ParseCurlLine();
             
            }
        }
    
    }
}

