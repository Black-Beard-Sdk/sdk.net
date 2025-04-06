namespace Bb.Interceptors
{
    public class RequestMessageInterceptor : RestSharp.Interceptors.Interceptor
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestMessageInterceptor"/> class.
        /// </summary>
        /// <param name="action">The action to execute before sending the HTTP request. Must not be null.</param>
        /// <remarks>
        /// This constructor sets up the interceptor with the specified action to be executed before the HTTP request is sent.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="action"/> is null.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var interceptor = new RequestMessageInterceptor(request =>
        /// {
        ///     Console.WriteLine($"Request URI: {request.RequestUri}");
        /// });
        /// </code>
        /// </example>
        public RequestMessageInterceptor(Action<HttpRequestMessage> action)
        {
            this._action = action ?? throw new ArgumentNullException(nameof(action));
        }

        /// <summary>
        /// Executes the configured action before the HTTP request is sent.
        /// </summary>
        /// <param name="requestMessage">The HTTP request message to process. Must not be null.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while processing the request.</param>
        /// <returns>A <see cref="ValueTask"/> representing the asynchronous operation.</returns>
        /// <remarks>
        /// This method invokes the configured action on the HTTP request message before it is sent.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="requestMessage"/> is null.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var interceptor = new RequestMessageInterceptor(request =>
        /// {
        ///     Console.WriteLine($"Request Method: {request.Method}");
        /// });
        /// await interceptor.BeforeHttpRequest(requestMessage, CancellationToken.None);
        /// </code>
        /// </example>
        public override ValueTask BeforeHttpRequest(HttpRequestMessage requestMessage, CancellationToken cancellationToken)
        {
            if (requestMessage == null)
                throw new ArgumentNullException(nameof(requestMessage));

            _action(requestMessage);
            return base.BeforeHttpRequest(requestMessage, cancellationToken);
        }

        /// <summary>
        /// Executes after the HTTP request is completed.
        /// </summary>
        /// <param name="responseMessage">The HTTP response message to process. Must not be null.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while processing the response.</param>
        /// <returns>A <see cref="ValueTask"/> representing the asynchronous operation.</returns>
        /// <remarks>
        /// This method is called after the HTTP request is completed. By default, it invokes the base implementation.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="responseMessage"/> is null.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var interceptor = new RequestMessageInterceptor(request => { });
        /// await interceptor.AfterHttpRequest(responseMessage, CancellationToken.None);
        /// </code>
        /// </example>
        public override async ValueTask AfterHttpRequest(HttpResponseMessage responseMessage, CancellationToken cancellationToken)
        {
            if (responseMessage == null)
                throw new ArgumentNullException(nameof(responseMessage));

            await base.AfterHttpRequest(responseMessage, cancellationToken);
        }

        /// <summary>
        /// The action to execute before sending the HTTP request.
        /// </summary>
        private readonly Action<HttpRequestMessage> _action;

    }

}
