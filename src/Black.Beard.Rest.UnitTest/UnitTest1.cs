using Bb.Services;
using Bb;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Newtonsoft.Json;
using Bb.Extensions;
using RestSharp;
using Bb.Helpers;
using Bb.Interfaces;
using System.Reflection;
using Bb.Configurations;
using Bb.Models;
using Bb.Urls;

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

            using var web = GetService(port).Build();

            web.GetApplication()
                .MapGet(url2, async (HttpContext context)
                    => await context.SetResponse(new MessageResult { Message = "Ok" })
                );
            web.RunAsync();


            var client = web
                .GetService<IRestClientFactory>()
                .Create(url.WithPathSegment(url2));

            var o = await client.GetAsync(Method.Get.NewRequest(url2));

            var m = o.Content.Deserialize<MessageResult>();
            Assert.Equal(m.Message, "Ok");

        }

        public class MessageResult
        {
            public string Message { get; set; }
        }

        public static WebService GetService(int port)
        {

            var name = Assembly.GetExecutingAssembly().GetName().Name;
            // create folder for config, schemas and .nugets
            var conf = StaticContainer.Set(new GlobalConfiguration())
                .SetRoot(name.GetTempPath())
                .WithRelatedDirectory(GlobalConfiguration.Configuration, "Configs")
                .WithRelatedDirectory(GlobalConfiguration.Schema, "Schemas")
                .WithRelatedDirectory(GlobalConfiguration.Nuget, ".nugets")
                .WithRelatedDirectory(GlobalConfiguration.Logs, "logs")
                ;

            conf.AppendDocument(GlobalConfiguration.Configuration,
                new StartupConfiguration()
                {
                    Packages = ["Black.Beard.ComponentModel"],
                });

            InitializerExtension.LoadAssemblies(null);

            var web = new WebService()
                            .WithHTTP(port)
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