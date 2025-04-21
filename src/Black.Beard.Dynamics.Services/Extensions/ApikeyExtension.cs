// Ignore Spelling: Apikey Api

using Bb.Interfaces;
using Bb.Models;
using Bb.Services;
using Bb.Urls;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Primitives;
using System.Linq;

namespace Bb.Extensions
{

    /// <summary>
    /// Class containing extension methods for configuring API key authentication and REST client services in a web application.
    /// </summary>
    public static class ApikeyExtension
    {

        /// <summary>
        /// Adds API key authentication middleware to the application.
        /// </summary>
        /// <param name="application">The <see cref="WebApplication"/> instance to configure. Must not be null.</param>
        /// <returns>The configured <see cref="WebApplication"/> instance.</returns>
        /// <remarks>
        /// This method adds middleware to validate API key authentication. If the API key is valid, it adds an authorization header to the request.
        /// </remarks>
        /// <exception cref="UnauthorizedAccessException">
        /// Thrown if the provided API key is invalid.
        /// </exception>
        /// <exception cref="Exception">
        /// Thrown if an unexpected error occurs during authentication.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var builder = WebApplication.CreateBuilder(args);
        /// var app = builder.Build();
        /// app.WithApiKeyAuthentication();
        /// app.Run();
        /// </code>
        /// </example>
        public static WebApplication WithApiKeyAuthentication(this WebApplication application)
        {

            var apiName = application.Configuration.GetValue<string>("ApiKey") ?? "X-API-KEY";

            application.Use(async (context, next) =>
            {

                if (!context.Request.Headers.TryGetValue(apiName, out StringValues extractedApiKey))
                {
                    context.Response.StatusCode = 401;
                    await context.Response.WriteAsync("API Key was not provided.");
                    return;
                }

                var tokenProvider = application.Services.GetRequiredService<TokenProvider>();
                try
                {
                    var token = await tokenProvider.GetTokenAsync(extractedApiKey);
                    if (!string.IsNullOrEmpty(token))
                    {
                        var headers = context.Request.Headers;
                        if (headers.ContainsKey(Authorization))
                            headers[Authorization] = $"Bearer {token}";
                        else
                            headers.TryAdd(Authorization, $"Bearer {token}");
                    }
                    await next();
                }
                catch (UnauthorizedAccessException ex)
                {
                    context.Response.StatusCode = 401;
                    await context.Response.WriteAsync(ex.Message);
                }
                catch (Exception ex)
                {
                    context.Response.StatusCode = 500;
                    await context.Response.WriteAsync($"authentication error : {ex.Message}");
                }
            });

            return application;

        }

        /// <summary>
        /// Adds the token provider service to the dependency injection container.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to add the service to. Must not be null.</param>
        /// <returns>The updated <see cref="IServiceCollection"/> instance.</returns>
        /// <remarks>
        /// This method registers the necessary services for token management, including memory caching and token resolution.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var services = new ServiceCollection();
        /// services.AddTokenProvider();
        /// var serviceProvider = services.BuildServiceProvider();
        /// </code>
        /// </example>
        public static IServiceCollection AddTokenProvider(this IServiceCollection services)
        {

            services.AddMemoryCache();
            services.AddSingleton<TokenResolver>();
            services.AddSingleton(sp => new TokenProvider
            (
                sp.GetRequiredService<IMemoryCache>(),
                sp.GetRequiredService<TokenResolver>()
            ));

            return services;
        }

        /// <summary>
        /// Adds a REST client factory to the dependency injection container.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to add the service to. Must not be null.</param>
        /// <returns>The updated <see cref="IServiceCollection"/> instance.</returns>
        /// <remarks>
        /// This method registers the REST client factory and its configuration, allowing for the creation of REST clients with specific options.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var services = new ServiceCollection();
        /// services.AddRestClient();
        /// var serviceProvider = services.BuildServiceProvider();
        /// var restClientFactory = serviceProvider.GetRequiredService&lt;IRestClientFactory&gt;();
        /// </code>
        /// </example>
        public static IServiceCollection AddRestClient(this IServiceCollection services)
        {

            services.AddSingleton<IOptionClientFactory, OptionClientFactory>((serviceProvider) =>
            {

                var configuration = serviceProvider.GetRequiredService<StartupConfiguration>();
                var service = new OptionClientFactory(serviceProvider);

                Dictionary<string, ClientOptionConfiguration> _configs = configuration.RestClient.Options
                    .ToDictionary(c => new Url(c.Name.ToLower()).Root);

                service.Configure(string.Empty, option =>
                {
                    if (option.BaseUrl != null && _configs.TryGetValue(option.BaseUrl.ToString(), out var c))
                        option.Timeout = TimeSpan.FromSeconds(c.Timeout);
                });

                return service;
            });

            services.AddSingleton<IRestClientFactory, RestClientFactory>((serviceProvider) =>
            {
                var factoryOption = serviceProvider.GetRequiredService<IOptionClientFactory>();
                var factoryClient = serviceProvider.GetService<IHttpClientFactory>();
                var factory = new RestClientFactory(factoryOption, factoryClient);
                return factory;
            });

            return services;

        }

        private const string Authorization = "Authorization";

    }

}
