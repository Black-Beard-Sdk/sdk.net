using Bb.Interfaces;
using Bb.Urls;
using RestSharp;
using System.Runtime.CompilerServices;

namespace Bb.Curls
{

    /// <summary>
    /// Convert curl syntax to http request
    /// </summary>
    internal partial class CurlInterpreter
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="CurlInterpreter"/> class.
        /// </summary>
        /// <param name="arguments">The arguments.</param>
        public CurlInterpreter(string[] arguments)
        {
            _arguments = new ArgumentSource(arguments);
            _handlers = new List<CurlInterpreterAction>();
        }


        #region properties

        /// <summary>
        /// Gets a value indicating whether the parsing or execution of the curl command has failed.
        /// </summary>
        /// <value><c>true</c> if the operation failed; otherwise, <c>false</c>.</value>
        public bool IsFailed { get; private set; }

        /// <summary>
        /// Gets the result message if the parsing or execution has failed.
        /// </summary>
        /// <value>A string containing the failure message, or <c>null</c> if no failure occurred.</value>
        public string? ResultMessage { get; private set; }


        /// <summary>
        /// Gets or sets the action to configure the <see cref="RestRequest"/>.
        /// </summary>
        /// <value>An <see cref="Action{T}"/> to configure the <see cref="RestRequest"/> before execution.</value>
        public Action<RestRequest> ConfigureRequest { get; set; }

        #endregion properties


        #region parser

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal bool BuildActions()
        {

            if (_list == null && _arguments.CanRead)
                lock (_lock)
                    if (_list == null)
                    {

                        ParseArguments();

                        if (_arguments.IsFailed)
                        {
                            this.IsFailed = true;
                            this.ResultMessage = _arguments.FailMessage;
                        }
                        else
                            this._list = _handlers.OrderBy(c => c.Priority).ToList();
                    }

            return _list != null && !IsFailed;

        }

        private void ParseArguments()
        {

            bool uri = false;
            while (_arguments.ReadNext())
            {

                string current = this._arguments.Current;

                if (_parameters.TryGetValue(current, out var parameters))
                    Append(parameters(this._arguments));

                else if (!uri && current.IsUrl())
                {
                    Append(SetUrl(this._arguments));
                    uri = true;
                }

            }

        }

        private void Append(CurlInterpreterAction? curlInterpreterAction)
        {
            if (curlInterpreterAction != null && !_arguments.IsFailed)
                _handlers.Add(curlInterpreterAction);
        }

        #endregion parser


        public CurlContext? CurlContext()
        {

            if (BuildActions())
            {

                var _context = new CurlContext()
                    .Apply(_list);

                return _context;

            }

            return default;

        }


        internal (RestRequest, Url)? GetRequest()
        {

            var context = CurlContext();
            if (context != null)
            {

                if (ConfigureRequest != null)
                    ConfigureRequest(context.Request);

                return (context.Request, context.Url);

            }

            return default;

        }


        [System.Diagnostics.DebuggerStepThrough]
        [System.Diagnostics.DebuggerNonUserCode]
        protected static void Stop()
        {
            if (System.Diagnostics.Debugger.IsAttached)
                System.Diagnostics.Debugger.Break();
        }


        private readonly List<CurlInterpreterAction> _handlers;
        private volatile object _lock = new object();
        private static Dictionary<string, Func<ArgumentSource, CurlInterpreterAction?>> _parameters;
        private List<CurlInterpreterAction> _list;
        private readonly ArgumentSource _arguments;

    }

}
