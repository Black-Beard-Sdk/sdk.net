namespace Bb.Curl.Commands
{


    internal partial class CurlInterpreterAction
    {

        public CurlInterpreterAction(Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> configureAction, params Argument[] arguments)
        {
            Arguments = arguments;
            this._configureAction = configureAction;
        }

        public async Task<HttpResponseMessage> CallAsync(Context ctx)
        {
            this.Context = ctx;
            return await _configureAction(this, ctx.Client, ctx.Message);
        }

        public async Task<HttpResponseMessage> CallNext()
        {

            if (_next != null)
            {
                _next.Context = this.Context;
                return await _next._configureAction(_next, _next.Context.Client, _next.Context.Message);
            }

            return await this.Context.CallAsync();

        }

        internal void Append(CurlInterpreterAction child)
        {

            if (_next == null)
                _next = child;
            else
                _next.Append(child);

        }

        public int Priority { get; internal set; }

        public ArgumentList Arguments { get; }

        public Argument First => Arguments.First();

        public string FirstValue => Arguments.First().Value;

        public Argument Get(string name) => Arguments.First(c => c.Name.Trim() == name);
        
        public Argument Get(Func<Argument, bool> test) => Arguments.First(test);

        public bool Exists(string name) => Arguments.Any(c => c.Name.Trim() == name);

        public Context Context { get; private set; }


        private Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> _configureAction;

        internal CurlInterpreterAction _next;

    }

}
