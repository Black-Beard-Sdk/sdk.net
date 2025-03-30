using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using Microsoft.AspNetCore.Builder;
using System.Text.Json;
using Bb.Services;
using Bb.ComponentModel.Loaders;
using Bb;


namespace Black.Beard.Rest.UnitTest
{
    public class UnitTest1
    {
        [Fact]    
        public void Test1()
        {

            var url = new Url("http://localhost", HttpHelper.GetAvailablePort(80));
            var url2 = "/api/sample";

            using (var web = new Bb.Services.WebService()
                .WithHttp(url.Port.Value)
                .UseStartup<Bb.Loaders.Startup>(c =>
                {
                    //c.UseStaticFiles = true;
                    //c.UseRouting = true;
                    //c.MapBlazorHub = true;
                    //c.MapFallbackToPage = "/Home";
                    c.UseCertificate = "";
                    c.UseSourceCertificate =  Bb.Loaders.SourceCertificate.File;
                    c.UsePasswordCertificate = "password";
                })
                )
            {

                web
                   .Build()
                   .RunAsync();

                var options = new OptionClientFactory();
                options.Configure(url, context =>
                {
                    
                });
                var factory = new RestClientFactory(options);

                factory.Create(url2);

            }

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