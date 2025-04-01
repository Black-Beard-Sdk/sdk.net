using Bb.Services;
using Bb;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Newtonsoft.Json;
using Bb.Extensions;
using RestSharp;
using Bb.Helpers;
using Bb.Interfaces;


namespace Black.Beard.Rest.UnitTest
{
    public class UnitTest1
    {

        [Fact]
        public async Task TestHttp()
        {

            var port = HttpHelper.GetAvailablePort(80);
            var url = new Url("http://localhost", port);
            var url2 = "/api/sample";

            using (var web = GetService(port).Build())
            {

                web.GetApplication().MapGet(url2, async (HttpContext context) =>
                {
                    var response = new { message = "Données reçues avec succès" };
                    context.Response.ContentType = "application/json";
                    await context.Response.WriteAsync(JsonConvert.SerializeObject(response));
                });

                web.RunAsync();

                var u = url.WithPathSegment(url2);

                var factory = web.GetService<IRestClientFactory>();
                var client = factory.Create(u);

                var o = await client.GetAsync(Method.Get.NewRequest(url2));

                

            }

        }



        public static WebService GetService(int port)
        {

            var web = new Bb.Services.WebService()
                .WithHttp(port)
                .UseStartup<Startup>(c =>
                {
                    //c.UseCertificate = "";
                    //c.UseSourceCertificate =  Bb.Loaders.SourceCertificate.File;
                    //c.UsePasswordCertificate = "password";
                });

            return web;

        }



    }
}


/*
       app.MapPost(url2, async (HttpContext context) =>
                       {
                           //var request = await JsonSerializer.DeserializeAsync<SampleRequest>(context.Request.Body);
                           //if (request == null)
                           //{
                           //    context.Response.StatusCode = 400;
                           //    await context.Response.WriteAsync("Invalid request body.");
                           //    return;
                           //}

                           var response = new { message = "Données reçues avec succès" };
                           context.Response.ContentType = "application/json";
                           await context.Response.WriteAsync(JsonSerializer.Serialize(response));
                       });



 */