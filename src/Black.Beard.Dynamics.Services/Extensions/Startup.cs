using Bb.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Bb.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Bb.Models;
using Bb.Interfaces;
using Bb.Configurations;
using Bb.Exceptions;


namespace Bb.Extensions
{

    /// <summary>
    /// Represents the startup configuration for a web application.
    /// </summary>
    /// <remarks>
    /// This class is responsible for configuring services, middleware, and the HTTP request pipeline for the application.
    /// </remarks>
    public class Startup
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class with the specified configuration and web service.
        /// </summary>
        /// <param name="configuration">configuration object</param>
        /// <param name="service">service to initialize</param>
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

            InitializeRestClient(services);

            if (Configuration != null)
            {

                if (Configuration.BearerOptions != null && Configuration.BearerOptions.Any())
                    ManageBearer(services);

                foreach (var item in Configuration.PolicyFiles)
                    builder.AddPolicy(item);

            }

            if (!builder.Services.TestExist<IVaultSecretResolver>())
                services.AddSingleton<IVaultSecretResolver, VaultEas256Resolver>();

        }

        private void InitializeRestClient(IServiceCollection services)
        {
            if (Configuration !=null && Configuration.RestClient != null)
            {

                var c = Configuration.RestClient;

                if (c.ClientActivated || c.UseApiKey)
                {
                    services.AddRestClient();
                    if (c.UseApiKey && !string.IsNullOrEmpty(c.TokenUrl) && !string.IsNullOrEmpty(c.TokenClientId))
                        services.AddTokenProvider();
                }
            }
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
        /// <param name="application">The <see cref="WebApplication"/> instance to configure. Must not be null.</param>
        /// <param name="environment">The <see cref="IWebHostEnvironment"/> representing the hosting environment. Must not be null.</param>
        /// <remarks>
        /// This method sets up middleware such as exception handling, HTTPS redirection, static files, routing, authentication, and authorization.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var builder = WebApplication.CreateBuilder(args);
        /// var application = builder.Build();
        /// var startup = new Startup(builder.Configuration, new WebService());
        /// startup.Configure(application, builder.Environment);
        /// application.Run();
        /// </code>
        /// </example>
        public virtual void Configure(WebApplication application, IWebHostEnvironment environment)
        {

            GlobalSettings.ServiceProvider = application.Services;
            bool useHttps = _service._hosts.Any(c => c.Item1.ToLower() == "https");

            InitializeLogAndExceptions(application);

            if (useHttps)
                application.UseHttpsRedirection();

            if (Configuration != null && Configuration.UseStaticFiles)
            {
                application.UseStaticFiles();
                application.UseAntiforgery();
            }

            if (Configuration != null && Configuration.UseRouting || Configuration != null && Configuration.MapBlazorHub)
            {
                application.UseRouting();
                if (Configuration.MapBlazorHub)
                    application.MapBlazorHub();
            }

            
            InitializeSecurity(application);


            application.UseRouteListing();


            if (_service._hosts.Count > 0)
                InitializeHostAddress(application);

        }

        private static void InitializeSecurity(WebApplication application)
        {
            application.UseAuthentication();
            application.UseAuthorization();
        }

        private void InitializeLogAndExceptions(WebApplication application)
        {
            if (Configuration == null || Configuration.LogExceptions)
                application.UseHttpExceptionInterceptor();

            if (Configuration == null || Configuration.LogInfo)
                application.UseHttpInfoLogger();

            if (Configuration != null && Configuration.RestClient != null && Configuration.RestClient.UseApiKey)
                application.WithApiKeyAuthentication();

            // Configure the HTTP request pipeline.
            if (application.Environment.IsDevelopment())
                application.UseDeveloperExceptionPage();

            else
            {
                application.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                application.UseHsts();
            }

            if (Configuration != null && !string.IsNullOrEmpty(Configuration.MapFallbackToPage))
                application.MapFallbackToPage(Configuration.MapFallbackToPage);

        }

        private void InitializeHostAddress(WebApplication application)
        {

            int port = 5000;
            foreach (var item in _service._hosts)
            {

                if (item.Item3 == null)
                {
                    if (item.Item1.ToLower() == "http")
                        application.Urls.AddLocalhostUrlWithDynamicPort(item.Item2, ref port);
                    else
                        application.Urls.AddLocalhostSecureUrlWithDynamicPort(item.Item2, ref port);
                }
                else
                {
                    int v = GetPort(item);
                    application.Urls.AddUrl(item.Item1, item.Item2, v);
                }

            }
        }

        private static int GetPort((string, string, int?) item)
        {
            var v = item.Item3.Value;
            if (v == -1)
            {

                if (item.Item1.ToLower() == "http")
                    v = 80;

                else if (item.Item1.ToLower() == "https")
                    v = 443;
            }

            return v;
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

            X509Certificate2? cert = null;

            if (Configuration != null)
            {

                var certificate = Configuration.HTTPSCertificate;

                
                if (certificate == null)
                    certificate = new Certificate();

                if (!string.IsNullOrEmpty(certificate.SourcePath))
                    cert = LoadFromFile(certificate);
                
                else
                    cert = LoadFromFile2(certificate);

            }

            if (cert == null)
                throw new CertificateNotFoundException("Certificate not found");

            return cert;

        }

        /// <summary>
        /// Loads a certificate from a file or creates a self-signed certificate if no file is found.
        /// </summary>
        /// <param name="certificate">The <see cref="Certificate"/> object containing certificate details. Must not be null.</param>
        /// <returns>The loaded or created <see cref="X509Certificate2"/> instance.</returns>
        /// <remarks>
        /// This method checks for existing certificate files in a folder and creates a self-signed certificate if none are found.
        /// </remarks>
        /// <exception cref="Exception">
        /// Thrown if the certificate cannot be created.
        /// </exception>
        private static X509Certificate2 LoadFromFile2(Certificate certificate)
        {

            X509Certificate2 cert;

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

            return cert;

        }

        /// <summary>
        /// Loads a certificate from a specified file or store.
        /// </summary>
        /// <param name="certificate">The <see cref="Certificate"/> object containing certificate details. Must not be null.</param>
        /// <returns>The loaded <see cref="X509Certificate2"/> instance.</returns>
        /// <remarks>
        /// This method loads a certificate from a file or the certificate store based on the specified source type.
        /// </remarks>
        /// <exception cref="FileNotFoundException">
        /// Thrown if the specified file does not exist.
        /// </exception>
        private static X509Certificate2 LoadFromFile(Certificate certificate)
        {

            X509Certificate2 cert;
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

            return cert;

        }

        #endregion configurations


        /// <summary>
        /// The configuration object for the application.
        /// </summary>
        protected readonly IConfiguration _configuration;

        /// <summary>
        /// service
        /// </summary>
        protected readonly WebService _service;

        /// <summary>
        /// Gets the startup configuration for the application.
        /// </summary>
        /// <value>
        /// The <see cref="StartupConfiguration"/> instance containing the application's configuration settings.
        /// </value>
        public StartupConfiguration? Configuration { get; private set; }
    
    }
}
