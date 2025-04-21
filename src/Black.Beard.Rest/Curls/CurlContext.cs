
using Bb.Urls;
using RestSharp;

namespace Bb.Curls
{

    /// <summary>
    /// Represents the context of a cURL request.
    /// </summary>
    public class CurlContext
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CurlContext"/> class.
        /// </summary>
        public CurlContext()
        {
            this.Headers = new Headers();
        }

        #region properties

        /// <summary>
        /// Gets or sets the HTTP request to be executed.
        /// </summary>
        public RestRequest Request { get; internal set; }

        /// <summary>
        /// return the list of headers
        /// </summary>
        public Headers Headers { get; }

        /// <summary>
        /// Gets or sets the URL to be used for the HTTP request.
        /// </summary>
        public Url Url { get; internal set; }

        #endregion properties
  


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

        private readonly Dictionary<string, string> _parameters = new Dictionary<string, string>();

    }

}
