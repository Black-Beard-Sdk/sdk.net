using RestSharp;

namespace Bb.Interfaces
{

    public interface IRestClientFactory 
        : INamedFactory<Uri, RestClient>
        , INamedFactory<string, RestClient>
        , INamedFactory<Url, RestClient>
    {


    }


}
