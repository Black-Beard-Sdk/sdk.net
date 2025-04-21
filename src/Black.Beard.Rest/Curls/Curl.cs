using Bb.Interfaces;
using RestSharp;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Bb.Curls
{

    /// <summary>
    /// Convert curl syntax in rest call
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="Curl"/> class with an optional factory.
    /// </remarks>
    /// <param name="factory"></param>
    public class Curl(IRestClientFactory? factory = null)
    {



        /// <summary>
        /// Executes a REST call based on the cURL command represented by the string.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains the <see cref="RestResponse"/>.</returns>
        /// <remarks>
        /// This method interprets the string as a cURL command and executes it using the default REST client.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// string curlCommand = "curl -X GET https://api.example.com/resource".AsCurl();
        /// var response = await curlCommand.CallRestAsync();
        /// Console.WriteLine(response?.Content);
        /// </code>
        /// </example>
        public async Task<RestResponse?> CallAsync()
        {

            var args = GetArgument();
            if (args != null)
                return await args.Value.Item1.ExecuteAsync(args.Value.Item2, args.Value.Item3);

            return default;

        }


        /// <summary>
        /// Executes a REST call based on the cURL command and returns a typed response.
        /// </summary>
        /// <typeparam name="T">The type of the response content.</typeparam>
        /// <returns>A task that represents the asynchronous operation. The task result contains the <see cref="RestResponse{T}"/>.</returns>
        /// <remarks>
        /// This method interprets the string as a cURL command and executes it using the default REST client.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// string curlCommand = "curl -X GET https://api.example.com/resource".AsCurl();
        /// var response = await curlCommand.CallAsync&lt;MyResponseType>();
        /// Console.WriteLine(response?.Data);
        /// </code>
        /// </example>
        public async Task<RestResponse<T>?> CallAsync<T>()
        {

            var args = GetArgument();
            if (args != null)
                return await args.Value.Item1.ExecuteAsync<T>(args.Value.Item2, args.Value.Item3);

            return default;

        }


        /// <summary>
        /// Executes the cURL command asynchronously and returns the response as a stream.
        /// </summary>
        /// <returns>A task representing the asynchronous operation, with a result of <see cref="Stream"/>.</returns>
        /// <remarks>
        /// This method interprets the string as a cURL command and executes it using the default REST client, returning the response as a stream.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// string curlCommand = "curl -X GET https://api.example.com/resource".AsCurl();
        /// using var stream = await curlCommand.CallStreamAsync();
        /// </code>
        /// </example>
        public async Task<Stream?> CallStreamAsync()
        {

            var args = GetArgument();
            if (args != null)
                return await args.Value.Item1.DownloadStreamAsync(args.Value.Item2, args.Value.Item3);

            return default;

        }


        /// <summary>
        /// Prepares the arguments required to execute the cURL command.
        /// </summary>
        /// <returns>
        /// A tuple containing the <see cref="RestClient"/>, <see cref="RestRequest"/>, and <see cref="CancellationToken"/>, or <c>null</c> if the request could not be prepared.
        /// </returns>
        /// <remarks>
        /// This method resolves the cURL command, maps variables, and prepares the HTTP client and request for execution.
        /// </remarks>
        /// <exception cref="Exceptions.MissingVariableException">Thrown if required variables are missing in the command.</exception>
        private (RestClient, RestRequest, CancellationToken)? GetArgument()
        {

            CurlInterpreter interpreter = GetInterpreter();
            var request = interpreter.GetRequest();
            if (request != null)
            {

                var f = _factory ?? GlobalSettings.UrlClientFactory;
                var client = f.Create(request.Value.Item2.ToUri());
                var source = _tokenSource ?? new CancellationTokenSource();
                var _token = source.Token;

                return (client, request.Value.Item1, _token);

            }

            return default;

        }


        #region Methods for configuration

        /// <summary>
        /// Sets the cURL command to be executed.
        /// </summary>
        /// <param name="command">command to set</param>
        /// <returns>Fluent syntax</returns>
        public Curl WithCommand(string command)
        {
            this._command = command;
            return this;
        }

        /// <summary>
        /// Sets the function to resolve variables for the cURL command if the variable is not yet known.
        /// </summary>
        /// <param name="resolveVariables">function to resolve the value for replace</param>
        /// <returns>fluent syntax</returns>
        public Curl LastChance(Func<string, object?> resolveVariables)
        {
            _ResolveVariables = resolveVariables;
            return this;
        }

        /// <summary>
        /// Adds or updates a mapping for variable substitution in the command.
        /// </summary>
        /// <param name="name">The name of the variable.</param>
        /// <param name="value">The value to substitute for the variable.</param>
        /// <returns>The current <see cref="Curl"/> instance.</returns>
        /// <exception cref="ArgumentNullException">Thrown if the value is null.</exception>
        /// <exception cref="ArgumentException">Thrown if the value is empty.</exception>
        public Curl WithMap(string name, object value)
        {

            if (value == null)
                throw new ArgumentNullException(nameof(value), "The value cannot be null.");

            string? txt = value.ToString();
            if (string.IsNullOrEmpty(txt))
                throw new ArgumentException("The value cannot be empty.", nameof(value));

            name = name.TrimStart('{').TrimEnd('}').Trim();
            if (_maps.ContainsKey(name))
                _maps[name] = txt;
            else
                _maps.Add(name, txt);

            return this;
        }

        /// <summary>
        /// Sets the function to configure the request before executing it.
        /// </summary>
        /// <param name="configureRequest">is an action of <see cref="RestRequest" /></param>
        /// <returns>Fluent syntax</returns>
        /// <exception cref="ArgumentNullException">throw an exception if the configuration action is null.</exception>
        public Curl WithConfig(Action<RestRequest> configureRequest)
        {
            if (configureRequest == null)
                throw new ArgumentNullException(nameof(configureRequest), "The configure request action cannot be null.");

            _configureRequest = configureRequest;
            return this;
        }

        /// <summary>
        /// Sets the cancellation token source for the cURL command.
        /// </summary>
        /// <param name="cancellationTokenSource">The cancellation token source to use.</param>
        /// <returns>The current <see cref="Curl"/> instance.</returns>
        /// <exception cref="ArgumentNullException">Thrown if the cancellation token source is null.</exception>
        public Curl WithCancellation(CancellationTokenSource cancellationTokenSource)
        {
            if (cancellationTokenSource == null)
                throw new ArgumentNullException(nameof(cancellationTokenSource), "The cancellation token source cannot be null.");
            _tokenSource = cancellationTokenSource;
            return this;
        }

        #endregion Methods for configuration


        #region private

        private CurlInterpreter GetInterpreter()
        {
            string c = GetMappedCommand();
            var interpreter = new CurlInterpreter(c.ParseCurlLine()) { ConfigureRequest = _configureRequest };
            return interpreter;
        }

        private string GetMappedCommand()
        {

            var c = _command;

            List<string> list = new();
            var matches = _reg.Matches(c);

            if (matches != null && matches.Any())
                foreach (string match in matches.Select(c => c.Value))
                {
                    var name = match.TrimStart('{').TrimEnd('}').Trim();
                    if (Resolve(name, out string? value))
                        c = c.Replace(match, value);
                    else
                        list.Add(match);
                }

            if (list.Any())
                throw new Exceptions.MissingVariableException(string.Join(", ", list));

            return c;

        }

        private bool Resolve(string name, out string? value)
        {

            bool found = !_maps.TryGetValue(name, out value);
            if (!found && _ResolveVariables != null)
            {
                var valueResult = _ResolveVariables(name);
                if (valueResult != null)
                {
                    WithMap(name, valueResult);
                    found = _maps.TryGetValue(name, out value);
                }
            }

            return found;

        }

        private string _command;
        private CancellationTokenSource _tokenSource;
        private Func<string, object?> _ResolveVariables;
        private Action<RestRequest> _configureRequest;

        private readonly IRestClientFactory _factory = factory ?? GlobalSettings.UrlClientFactory;
        private readonly Regex _reg = new Regex("{\\s*\\w+\\s*}", RegexOptions.IgnoreCase | RegexOptions.Multiline);
        private readonly Dictionary<string, string> _maps = new Dictionary<string, string>();

        #endregion private


    }




}
