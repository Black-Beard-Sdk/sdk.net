using Bb.Models;
using Bb.Services;
using Microsoft.Extensions.Caching.Memory;

namespace Bb.Extensions
{


    public static class ApikeyExtension
    {

        public static WebApplication WithApiKeyAuthentication(this WebApplication app)
        {

            var apiName = app.Configuration.GetValue<string>("ApiKey") ?? "X-API-KEY";

            app.Use(async (context, next) =>
            {

                if (!context.Request.Headers.TryGetValue(apiName, out var extractedApiKey))
                {
                    context.Response.StatusCode = 401;
                    await context.Response.WriteAsync("API Key was not provided.");
                    return;
                }

                var tokenProvider = app.Services.GetRequiredService<TokenProvider>();

                try
                {
                    var token = await tokenProvider.GetTokenAsync(extractedApiKey);
                    context.Request.Headers.Add("Authorization", $"Bearer {token}");
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
                    await context.Response.WriteAsync($"Erreur lors de l'authentification: {ex.Message}");
                }
            });

            return app;

        }


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


        public static IServiceCollection AddRestClient(this IServiceCollection services)
        {

            services.AddSingleton<IOptionClientFactory, OptionClientFactory>( (serviceProvider) =>
            {

                var configuration = serviceProvider.GetRequiredService<StartupConfiguration>();
                var service = new OptionClientFactory(serviceProvider);

                Dictionary<string, ClientOptionConfiguration> _configs = configuration.RestClient.Options.ToDictionary(c => new Url(c.Name.ToLower()).Root);

                service.Configure(string.Empty, option =>
                {

                    if (_configs.TryGetValue(option.BaseUrl.ToString(), out var c))
                    {
                        option.Timeout = TimeSpan.FromSeconds(c.Timeout);
                    }


                });

                return service;
            });

            services.AddSingleton<IRestClientFactory, RestClientFactory>((serviceProvider) =>
            {
                var factoryOption = serviceProvider.GetRequiredService<IOptionClientFactory>();
                var factory = new RestClientFactory(factoryOption);
                return factory;
            });

            return services;

        }



    }


}
