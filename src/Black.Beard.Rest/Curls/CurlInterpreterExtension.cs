using Bb.Interfaces;
using RestSharp;

namespace Bb.Curls
{
    public static class CurlInterpreterExtension
    {
        

        public static async Task<RestResponse?> CallRestAsync(this string self, CancellationTokenSource? source = null)
        {
            CurlInterpreter curl = self;
            var response = await curl.CallAsync(source);
            return response;
        }

        public static async Task<RestResponse?> CallRestAsync(this string self, IRestClientFactory factory, CancellationTokenSource? source = null)
        {
            CurlInterpreter curl = self;
            var response = await curl.CallAsync(factory, source);
            return response;
        }


    }


}
