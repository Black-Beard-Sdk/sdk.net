using Bb.Services;
using Bb;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Newtonsoft.Json;
using Bb.Extensions;
using RestSharp;
using Bb.Helpers;
using Bb.Interfaces;
using NLog.Targets;
using System.Reflection;
using Bb.Loaders;
using Bb.Configurations;
using Bb.ComponentModel.Loaders;
using Bb.Models;


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
                    var response = new { message = "Donn�es re�ues avec succ�s" };
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

            // create folder for config, schemas and .nugets
            var conf = StaticContainer.Set(new GlobalConfiguration())
                .SetRoot(Assembly.GetExecutingAssembly().GetName().Name.GetTempPath())
                .WithDirectory(GlobalConfiguration.Configuration, "Configs")
                .WithDirectory(GlobalConfiguration.Schema, "Schemas")
                .WithDirectory(GlobalConfiguration.Nuget, ".nugets")
                ;

            conf.AppendDocument(GlobalConfiguration.Configuration,
                new StartupConfiguration()
                {
                    Packages = ["Black.Beard.ComponentModel"],
                });

            var web = new WebService()
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

                           var response = new { message = "Donn�es re�ues avec succ�s" };
                           context.Response.ContentType = "application/json";
                           await context.Response.WriteAsync(JsonSerializer.Serialize(response));
                       });



 */