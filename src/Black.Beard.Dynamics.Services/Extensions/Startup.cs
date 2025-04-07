using Bb.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Bb.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Bb.Models;
using Bb.Interfaces;
using Bb.Configurations;


namespace Bb.Extensions
{

    /// <summary>
    /// Represents the startup configuration for a web application.
    /// </summary>
    public class Startup
    {

        public Startup(IConfiguration configuration, WebService service)
        {
            _configuration = configuration;
            _service = service;

            Configuration = configuration.Get<StartupConfiguration>();

        }


        #region services

        /// <summary>
        /// Configures services for the web application.
        /// </summary>
        /// <param name="builder">The <see cref="WebApplicationBuilder"/> instance to configure. Must not be null.</param>
        /// <param name="services">The <see cref="IServiceCollection"/> to add services to. Must not be null.</param>
        /// <remarks>
        /// This method configures various services such as HTTPS, REST clients, bearer authentication, and policies based on the startup configuration.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var builder = WebApplication.CreateBuilder(args);
        /// var startup = new Startup(builder.Configuration, new WebService());
        /// startup.ConfigureServices(builder, builder.Services);
        /// var app = builder.Build();
        /// app.Run();
        /// </code>
        /// </example>
        public virtual void ConfigureServices(WebApplicationBuilder builder, IServiceCollection services)
        {

            bool useHttps = _service._hosts.Any(c => c.Item1.ToLower() == "https");

            if (useHttps)
                ManageCertificate(builder.WebHost);

            if (Configuration != null)
            {

                if (Configuration.RestClient != null)
                {

                    var c = Configuration.RestClient;

                    if (c.ClientActivated || c.UseApiKey)
                    {
                        services.AddRestClient();
                        if (c.UseApiKey && !string.IsNullOrEmpty(c.TokenUrl) && !string.IsNullOrEmpty(c.TokenClientId))
                            services.AddTokenProvider();
                    }
                }

                if (Configuration.BearerOptions != null && Configuration.BearerOptions.Any())
                    ManageBearer(services);

                foreach (var item in Configuration.PolicyFiles)
                    builder.AddPolicy(item);

            }

            if (!builder.Services.TestExist<IVaultSecretResolver>())
                services.AddSingleton<IVaultSecretResolver, VaultEas256Resolver>();

        }

        /// <summary>
        /// Manages bearer authentication for the application.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to configure authentication for. Must not be null.</param>
        /// <remarks>
        /// This method configures JWT bearer authentication using the options specified in the startup configuration.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if the configuration for bearer options is null.
        /// </exception>
        private void ManageBearer(IServiceCollection services)
        {
            var auth = services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            });

            if (Configuration != null)
                foreach (var item in Configuration.BearerOptions)
                    auth.AddJwtBearer(item.Name, options =>
                    {
                        options.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidateIssuer = item.ValidateIssuer,
                            ValidateAudience = item.ValidateAudience,
                            ValidateLifetime = item.ValidateLifetime,
                            ValidateIssuerSigningKey = item.ValidateIssuerSigningKey,
                            ValidIssuer = item.ValidIssuer,
                            ValidAudience = item.ValidAudience,
                            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(item.IssuerSigningKey))
                        };
                    });
        }

        /// <summary>
        /// Configures HTTPS settings for the application.
        /// </summary>
        /// <param name="webHost">The <see cref="ConfigureWebHostBuilder"/> to configure HTTPS for. Must not be null.</param>
        /// <remarks>
        /// This method sets up HTTPS defaults and loads the server certificate.
        /// </remarks>
        /// <exception cref="Exception">
        /// Thrown if the certificate cannot be loaded.
        /// </exception>
        private void ManageCertificate(ConfigureWebHostBuilder webHost)
        {
            webHost.ConfigureKestrel(options =>
            {
                options.ConfigureHttpsDefaults(httpsOptions =>
                {
                    httpsOptions.ServerCertificate = LoadCertificate();
                });
            });
        }

        #endregion services


        #region configurations

        /// <summary>
        /// Configures the HTTP request pipeline for the web application.
        /// </summary>
        /// <param name="app">The <see cref="WebApplication"/> instance to configure. Must not be null.</param>
        /// <param name="env">The <see cref="IWebHostEnvironment"/> representing the hosting environment. Must not be null.</param>
        /// <remarks>
        /// This method sets up middleware such as exception handling, HTTPS redirection, static files, routing, authentication, and authorization.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var builder = WebApplication.CreateBuilder(args);
        /// var app = builder.Build();
        /// var startup = new Startup(builder.Configuration, new WebService());
        /// startup.Configure(app, builder.Environment);
        /// app.Run();
        /// </code>
        /// </example>
        public virtual void Configure(WebApplication app, IWebHostEnvironment env)
        {

            bool useHttps = _service._hosts.Any(c => c.Item1.ToLower() == "https");

            if (Configuration == null || Configuration.LogExceptions)
                app.UseHttpExceptionInterceptor();

            if (Configuration == null || Configuration.LogInfo)
                app.UseHttpInfoLogger();

            if (Configuration != null && Configuration.RestClient != null && Configuration.RestClient.UseApiKey)
                app.WithApiKeyAuthentication();

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

            if (Configuration != null && Configuration.UseStaticFiles)
            {
                app.UseStaticFiles();
                app.UseAntiforgery();
            }

            if (Configuration != null && Configuration.UseRouting || Configuration != null && Configuration.MapBlazorHub)
            {

                app.UseRouting();

                if (Configuration.MapBlazorHub)
                {
                    app.MapBlazorHub();
                }
            }

            app.UseAuthentication();
            app.UseAuthorization();


            app.UseRouteListing();

            if (Configuration != null && !string.IsNullOrEmpty(Configuration.MapFallbackToPage))
                app.MapFallbackToPage(Configuration.MapFallbackToPage);

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

        /// <summary>
        /// Loads the server certificate for HTTPS.
        /// </summary>
        /// <returns>The loaded <see cref="X509Certificate2"/> instance.</returns>
        /// <remarks>
        /// This method attempts to load the certificate from the specified path or creates a self-signed certificate if none is found.
        /// </remarks>
        /// <exception cref="FileNotFoundException">
        /// Thrown if the certificate file is not found.
        /// </exception>
        /// <exception cref="Exception">
        /// Thrown if the certificate cannot be loaded or created.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var certificate = LoadCertificate();
        /// Console.WriteLine($"Certificate loaded: {certificate.Subject}");
        /// </code>
        /// </example>
        private X509Certificate2 LoadCertificate()
        {

            X509Certificate2 cert = null;

            if (Configuration != null)
            {

                var certificate = Configuration.HttpsCertificate;

                if (certificate == null)
                    certificate = new Certificate();

                if (!string.IsNullOrEmpty(certificate.SourcePath))
                {

                    if (certificate.TypeSource == SourceCertificate.Store)
                        cert = CertificateHelpers.LoadCertificateFromStore(certificate.SourcePath);

                    else
                    {
                        var file = certificate.SourcePath.AsFile();
                        if (file.Exists)
                            cert = CertificateHelpers.LoadCertificateFromFile(file, certificate.Password);
                        else
                            throw new FileNotFoundException(file.FullName);
                    }

                }
                else
                {

                    var folder = StaticContainer.Get<GlobalConfiguration>()[GlobalConfiguration.Configuration];
                    var files = folder.GetFiles("*.pfx").ToArray();

                    if (files.Any())
                    {
                        cert = CertificateHelpers.LoadCertificateFromFile(files[0], certificate.Password);
                        return cert;
                    }

                    var path = folder.GetPaths().First().Combine("localhost.pfx");
                    cert = CertificateHelpers.CreateSelfSignedCertificate("localhost", certificate.Password);
                    CertificateHelpers.SaveCertificateToFile(cert, path, certificate.Password);
                }

            }

            if (cert == null)
                throw new Exception("Certificate not found");

            return cert;



        }

        #endregion configurations


        protected readonly IConfiguration _configuration;
        protected readonly WebService _service;

        public StartupConfiguration? Configuration { get; private set; }
    }
}
