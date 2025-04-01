using RestSharp;

namespace Bb.Interfaces
{
    public interface IOptionClientFactory
        : INamedFactory<string, RestClientOptions>
    {


    }


}
