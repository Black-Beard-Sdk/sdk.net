using RestSharp;

namespace Bb.Services
{

    public interface IRestClientFactory 
        : IFactory<Uri, RestClient>
        , IFactory<string, RestClient>
        , IFactory<Url, RestClient>
    {


    }

    public interface IOptionClientFactory
        : IFactory<string, RestClientOptions>
    {


    }



    public interface IFactory<TName, T>
    {

        T Create(TName name);

    }

}
