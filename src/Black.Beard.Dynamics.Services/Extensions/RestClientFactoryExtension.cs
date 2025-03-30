using Bb.Services;
using RestSharp;

namespace Bb.Extensions
{

    public static class RestClientFactoryExtension
    {

        public static IServiceCollection AddRestClientFactory(this IServiceCollection services)
        {
            services.AddSingleton<IOptionClientFactory, OptionClientFactory>();
            services.AddSingleton<IRestClientFactory, RestClientFactory>();
            return services;
        }

    }


}
