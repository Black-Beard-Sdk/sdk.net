namespace Bb.Interceptors
{

    /// <summary>
    /// Interceptor for handling HTTP response messages in RestSharp.
    /// </summary>
    public class ResponseMessageInterceptor : RestSharp.Interceptors.Interceptor
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMessageInterceptor"/> class.
        /// </summary>
        /// <param name="action">The action to execute after receiving the HTTP response. Must not be null.</param>
        /// <remarks>
        /// This constructor sets up the interceptor with the specified action to be executed after the HTTP response is received.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="action"/> is null.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var interceptor = new ResponseMessageInterceptor(response =>
        /// {
        ///     Console.WriteLine($"Response Status: {response.StatusCode}");
        /// });
        /// </code>
        /// </example>
        public ResponseMessageInterceptor(Action<HttpResponseMessage> action)
        {
            this._action = action ?? throw new ArgumentNullException(nameof(action));
        }

        /// <summary>
        /// Executes the configured action after the HTTP request is completed.
        /// </summary>
        /// <param name="responseMessage">The HTTP response message to process. Must not be null.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while processing the response.</param>
        /// <returns>A <see cref="ValueTask"/> representing the asynchronous operation.</returns>
        /// <remarks>
        /// This method invokes the configured action on the HTTP response message after it is received.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="responseMessage"/> is null.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var interceptor = new ResponseMessageInterceptor(response =>
        /// {
        ///     Console.WriteLine($"Response Content: {response.Content.ReadAsStringAsync().Result}");
        /// });
        /// await interceptor.AfterHttpRequest(responseMessage, CancellationToken.None);
        /// </code>
        /// </example>
        public override async ValueTask AfterHttpRequest(HttpResponseMessage responseMessage, CancellationToken cancellationToken)
        {
            if (responseMessage == null)
                throw new ArgumentNullException(nameof(responseMessage));

            _action(responseMessage);
            await base.AfterHttpRequest(responseMessage, cancellationToken);
        }

        /// <summary>
        /// The action to execute after receiving the HTTP response.
        /// </summary>
        private readonly Action<HttpResponseMessage> _action;

    }

}
