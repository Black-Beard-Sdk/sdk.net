using Bb.Http;
using Bb.Http.Configuration;

namespace Bb.Curls
{
 
    public class CurlContext
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CurlContext"/> class.
        /// </summary>
        /// <param name="cancellationTokenSource">The cancellation token to cancel operation.</param>
        public CurlContext(CancellationTokenSource? cancellationTokenSource)
        {
            _tokenSource = cancellationTokenSource ?? new CancellationTokenSource();
            _token = _tokenSource.Token;
            _parameters = new Dictionary<string, string>();
        }


        //public HttpClient HttpClient { get; internal set; }

        // public HttpRequestMessage RequestMessage { get; internal set; }

        public UrlRequest Request { get; internal set; }

        public IUrlResponse Result { get; private set; }

        /// <summary>
        /// Send an HTTP request as an asynchronous operation.
        /// </summary>
        /// <returns></returns>
        internal async Task<IUrlResponse> CallAsync(IUrlClientFactory factory)
        {
            var client = factory.Get(Request.Url);
            Result = await client.SendAsync(Request, HttpCompletionOption.ResponseContentRead, _token);
            return Result;
        }

        internal void Add(KeyValuePair<string, string> item)
        {
            if (_parameters.ContainsKey(item.Key))
                _parameters[item.Key] = item.Value;
            else
                _parameters.Add(item.Key, item.Value);
        }

        internal bool Has(string key, string value)
        {

            if (_parameters.TryGetValue(key, out var result))
                return result == value;

            return false;

        }

        internal CurlContext Apply(List<CurlInterpreterAction> list)
        {

            for (int i = 0; i < list.Count; i++)
                list[i].CollectParameters(this);

            for (int i = 0; i < list.Count; i++)
                list[i].Configure(this);

            return this;
        }

        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private readonly CancellationTokenSource _tokenSource;
        private readonly CancellationToken _token;

    }

}
