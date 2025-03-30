using Bb.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Bb.Services;

namespace Bb.Loaders
{


    public class Startup
    {

        public Startup(IConfiguration configuration, WebService service)
        {
            _configuration = configuration;
            _service = service;
        }

        public void ConfigureServices(WebApplicationBuilder builder, IServiceCollection services)
        {

            bool useHttps = _service._hosts.Any(c => c.Item1.ToLower() == "https");

            if (useHttps)
            {
                builder.WebHost.ConfigureKestrel(options =>
                {
                    options.ConfigureHttpsDefaults(httpsOptions =>
                    {
                        httpsOptions.ServerCertificate = LoadCertificate();
                    });
                });
            }

        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {

            bool useHttps = _service._hosts.Any(c => c.Item1.ToLower() == "https");


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
                app.UseDeveloperExceptionPage();

            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            if (useHttps)
                app.UseHttpsRedirection();

            if (UseStaticFiles)
            {
                app.UseStaticFiles();
                app.UseAntiforgery();
            }

            if (UseRouting || MapBlazorHub)
            {
                app.UseRouting();

                if (MapBlazorHub)
                {
                    app.MapBlazorHub();
                }
            }



            app.MapFallbackToPage("/Home");

            if (_service._hosts.Count > 0)
            {

                int port = 5000;

                foreach (var item in _service._hosts)
                {

                    if (item.Item3 == null)
                    {
                        if (item.Item1.ToLower() == "http")
                            app.Urls.AddLocalhostUrlWithDynamicPort(item.Item2, ref port);
                        else
                            app.Urls.AddLocalhostSecureUrlWithDynamicPort(item.Item2, ref port);
                    }
                    else
                        app.Urls.AddUrl(item.Item1, item.Item2, item.Item3.Value);

                }

            }
        }



        public bool UseStaticFiles { get; set; } = false;

        public bool UseRouting { get; set; } = false;

        public bool MapBlazorHub { get; set; } = false;

        public string MapFallbackToPage { get; set; } = "/Home";

        public string UseCertificate { get; set; }

        public string UsePasswordCertificate { get; set; } = "password";

        public SourceCertificate UseSourceCertificate { get; set; } = SourceCertificate.File;

        private X509Certificate2 LoadCertificate()
        {

            X509Certificate2 cert;

            if (!string.IsNullOrEmpty(UseCertificate))
            {

                if (UseSourceCertificate == SourceCertificate.Store)
                    cert = CertificateHelpers.LoadCertificateFromStore(UseCertificate);

                else
                {
                    var file = UseCertificate.AsFile();
                    if (file.Exists)
                        cert = CertificateHelpers.LoadCertificateFromFile(file, UsePasswordCertificate);
                    else
                        throw new FileNotFoundException(file.FullName);
                }

            }
            else
            {

                var files = StartingConfiguration.Folders.GetFiles("*.pfx").ToList();
                if (files.Any())
                {
                    cert = CertificateHelpers.LoadCertificateFromFile(files[0], UsePasswordCertificate);
                    return cert;
                }

                var path = ConfigurationFolder.GetPaths().First().Combine("localhost.pfx");
                cert = CertificateHelpers.CreateSelfSignedCertificate("localhost", UsePasswordCertificate);
                CertificateHelpers.SaveCertificateToFile(cert, path, UsePasswordCertificate);
            }

            if (cert == null)
                throw new Exception("Certificate not found");

            return cert;

        }

        protected readonly IConfiguration _configuration;
        protected readonly WebService _service;

    }

    public enum SourceCertificate
    {
        File,
        Store
    }

}
