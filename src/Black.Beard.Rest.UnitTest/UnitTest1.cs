using Bb;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Newtonsoft.Json;
using Bb.Extensions;
using RestSharp;
using Bb.Helpers;
using Bb.Interfaces;
using Bb.Urls;
using Bb.Curls;

namespace Black.Beard.Rest.UnitTest
{


    public class UnitTest1
    {

        [Fact]
        public async Task TestHttpGet()
        {

            var url = new Url("http", "localhost", HttpHelper.GetAvailablePort(80),null, "api/sample");
            using (var web = Services.GetWebService(url.Port, c =>
            {
                
                c.GetApplication().MapGet(url.Path, async (HttpContext context)
                       => await context.SetResponse(new MessageResult { Message = "Ok" }));

            }).RunAsync())
            {                               

                var result = await $"curl -X GET {url}"
                    .CallRestAsync();
                var m = result.Content.Deserialize<MessageResult>();

                Assert.Equal(m.Message, "Ok");

            }

        }


        [Fact]
        public async Task TestHttpPost()
        {

            var url = new Url("http", "localhost", HttpHelper.GetAvailablePort(80), null, "api/sample");
            using (var web = Services.GetWebService(url.Port, c =>
            {

                c.GetApplication().MapPost(url.Path, async (HttpContext context)
                       => await context.SetResponse(new MessageResult { Message = "Ok" }));

            }).RunAsync())
            {

                var result = await $"curl -X POST {url}"
                    .CallRestAsync();
                var m = result.Content.Deserialize<MessageResult>();

                Assert.Equal(m.Message, "Ok");

            }

        }


        [Fact]
        public async Task TestHttpPu()
        {

            var url = new Url("http", "localhost", HttpHelper.GetAvailablePort(80), null, "api/sample");
            using (var web = Services.GetWebService(url.Port, c =>
            {

                c.GetApplication().MapPut(url.Path, async (HttpContext context)
                       => await context.SetResponse(new MessageResult { Message = "Ok" }));

            }).RunAsync())
            {

                var result = await $"curl -X PUT {url}"
                    .CallRestAsync();
                var m = result.Content.Deserialize<MessageResult>();

                Assert.Equal(m.Message, "Ok");

            }

        }

    }


    public class MessageResult
    {
        public string Message { get; set; }
    }


}

