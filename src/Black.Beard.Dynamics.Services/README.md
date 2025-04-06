# sdk.net
provide a service


```chsarp

int port = 8080;


// create folder for config, schemas and .nugets
var conf = StaticContainer.Set(new GlobalConfiguration())
    .SetRoot(Assembly.GetExecutingAssembly().GetName().Name.GetTempPath())
    .WithDirectory(GlobalConfiguration.Configuration, "Configs")
    .WithDirectory(GlobalConfiguration.Schema, "Schemas")
    .WithDirectory(GlobalConfiguration.Nuget, ".nugets");


conf.AppendDocument(GlobalConfiguration.Configuration,
    new StartupConfiguration()
    {
        Packages = ["Black.Beard.ComponentModel"],
    });

InitializerExtension.LoadAssemblies(null);

var web = new WebService()
                .WithHttp(port)
                .UseStartup<Startup>(c =>
                {
                    //c.UseCertificate = "";
                    //c.UseSourceCertificate =  Bb.Loaders.SourceCertificate.File;
                    //c.UsePasswordCertificate = "password";
                });

```


