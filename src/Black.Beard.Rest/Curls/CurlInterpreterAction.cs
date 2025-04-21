
using Bb.Http;
using System.Collections.Generic;

namespace Bb.Curls
{

    /// <summary>
    /// Represents an action to be executed in the cURL interpreter context.
    /// </summary>
    public partial class CurlInterpreterAction
    {

        /// <summary>
        /// create a new instance of <see cref="CurlInterpreterAction"/>
        /// </summary>
        /// <param name="configureAction"></param>
        /// <param name="arguments"></param>
        public CurlInterpreterAction(
            Action<CurlInterpreterAction,
            CurlContext> configureAction,
            params Argument[] arguments)
        {
            _parameters = new List<KeyValuePair<string, string>>();
            Arguments = arguments;
            _configureAction = configureAction;
        }

        /// <summary>
        /// Get or set the next action to be executed
        /// </summary>
        public int Priority { get; internal set; } = 10;

        /// <summary>
        /// return the list of arguments
        /// </summary>
        public ArgumentList Arguments { get; }

        /// <summary>
        /// Get the first argument in the list
        /// </summary>
        public Argument First => Arguments.First();

        /// <summary>
        /// Get the first value in the list of arguments
        /// </summary>
        public string FirstValue => Arguments.First().Value;

        /// <summary>
        /// Get or set arguments
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Argument Get(string name) => Arguments.First(c => c.Name?.Trim() == name);

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
        public bool Exists(string name) => Arguments.Any(c => c.Name?.Trim() == name);

        internal void Configure(CurlContext context)
        {
            _configureAction(this, context);
        }

        internal void CollectParameters(CurlContext context)
        {
            if (_parameters.Count > 0)
                foreach (var item in _parameters)
                    context.Add(item);
        }

        internal CurlInterpreterAction Add(string key, string value)
        {
            _parameters.Add(new KeyValuePair<string, string>(key, value));
            return this;
        }

        private readonly Action<CurlInterpreterAction, CurlContext> _configureAction;
        private readonly List<KeyValuePair<string, string>> _parameters = new List<KeyValuePair<string, string>>();

    }

}
