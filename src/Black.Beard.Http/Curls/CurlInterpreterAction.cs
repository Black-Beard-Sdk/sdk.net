using Bb.Http.Configuration;

namespace Bb.Curls
{


    public partial class CurlInterpreterAction
    {

        /// <summary>
        /// create a new instance of <see cref="CurlInterpreterAction"/>
        /// </summary>
        /// <param name="configureAction"></param>
        /// <param name="arguments"></param>
        public CurlInterpreterAction(Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> configureAction, params Argument[] arguments)
        {
            _parameters = new List<KeyValuePair<string, string>>();
            Arguments = arguments;
            _configureAction = configureAction;
        }

        public int Priority { get; internal set; }

        public ArgumentList Arguments { get; }

        public Argument First => Arguments.First();

        public string FirstValue => Arguments.First().Value;


        /// <summary>
        /// Gets or sets the client factory.
        /// </summary>
        public IUrlClientFactory Factory { get; internal set; }

        /// <summary>
        /// Get or set arguments
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Argument Get(string name) => Arguments.First(c => c.Name.Trim() == name);

        /// <summary>
        /// Get or set arguments
        /// </summary>
        /// <param name="test"></param>
        /// <returns></returns>
        public Argument Get(Func<Argument, bool> test) => Arguments.First(test);

        /// <summary>
        /// Get argument by specified name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool Exists(string name) => Arguments.Any(c => c.Name.Trim() == name);


        internal async Task<HttpResponseMessage> CallAsync(Context context)
        {
            return await _configureAction(this, context);
        }

        internal Context CollectParameters(Context context)
        {

            if (_parameters.Count > 0)
                foreach (var item in _parameters)
                    context.Add(item);

            if (_next != null)
                _next.CollectParameters(context);

            return context;

        }

        internal async Task<HttpResponseMessage> CallNext(Context context)
        {

            if (_next != null)
                return await _next._configureAction(_next, context);

            return await context.CallAsync();

        }

        internal void Append(List<CurlInterpreterAction> list, int index)
        {
            _next = list[index++];

            if (index < list.Count)
                _next.Append(list, index);

        }

        internal CurlInterpreterAction Add(string key, string value)
        {
            _parameters.Add(new KeyValuePair<string, string>(key, value));
            return this;
        }

        internal CurlInterpreterAction _next;

        private Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> _configureAction;
        private List<KeyValuePair<string, string>> _parameters = new List<KeyValuePair<string, string>>();

    }

}
