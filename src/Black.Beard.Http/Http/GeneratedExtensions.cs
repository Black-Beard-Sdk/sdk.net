using System.Net;
using Bb.Http.Configuration;
using Bb.Http.Content;

namespace Bb.Http
{

    /// <summary>
    /// Fluent extension methods on String, Url, Uri, and IUrlRequest.
    /// </summary>
    public static class GeneratedExtensions
    {

        /// <summary>
        /// Sends an asynchronous request.
        /// </summary>
        /// <param name="request">This IUrlRequest</param>
        /// <param name="verb">The HTTP verb used to make the request.</param>
        /// <param name="body">An object representing the request body, which will be serialized to object.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> SendObjectAsync(this IUrlRequest request, HttpMethod verb, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            var content = request.Serialize(body);
            return request.SendAsync(verb, content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Sends an asynchronous request.
        /// </summary>
        /// <param name="request">This IUrlRequest</param>
        /// <param name="verb">The HTTP verb used to make the request.</param>
        /// <param name="body">The request body.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> SendStringAsync(this IUrlRequest request, HttpMethod verb, string body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            var content = new CapturedStringContent(body);
            return request.SendAsync(verb, content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Sends an asynchronous request.
        /// </summary>
        /// <param name="request">This IUrlRequest</param>
        /// <param name="verb">The HTTP verb used to make the request.</param>
        /// <param name="body">An object representing the request body, which will be serialized to a URL-encoded string.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> SendUrlEncodedAsync(this IUrlRequest request, HttpMethod verb, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            var content = new CapturedUrlEncodedContent(request.Settings.UrlEncodedSerializer.Serialize(body));
            return request.SendAsync(verb, content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Sends an asynchronous GET request.
        /// </summary>
        /// <param name="request">This IUrlRequest</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> GetAsync(this IUrlRequest request, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return request.SendAsync(HttpMethod.Get, null, completionOption, cancellationToken);
        }

        /// <summary>
        /// Sends an asynchronous GET request.
        /// </summary>
        /// <param name="request">This IUrlRequest</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the object response body deserialized to an object of type T.</returns>
        public static Task<T?> GetObjectAsync<T>(this IUrlRequest request, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return request.SendAsync(HttpMethod.Get, null, completionOption, cancellationToken).ReceiveJson<T>();
        }

        /// <summary>
        /// Sends an asynchronous GET request.
        /// </summary>
        /// <param name="request">This IUrlRequest</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the response body as a string.</returns>
        public static Task<string?> GetStringAsync(this IUrlRequest request, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return request.SendAsync(HttpMethod.Get, null, completionOption, cancellationToken).ReceiveString();
        }

        /// <summary>
        /// Sends an asynchronous GET request.
        /// </summary>
        /// <param name="request">This IUrlRequest</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the response body as a Stream.</returns>
        public static Task<Stream?> GetStreamAsync(this IUrlRequest request, HttpCompletionOption completionOption = HttpCompletionOption.ResponseHeadersRead, CancellationToken cancellationToken = default)
        {
            return request.SendAsync(HttpMethod.Get, null, completionOption, cancellationToken).ReceiveStream();
        }

        /// <summary>
        /// Sends an asynchronous GET request.
        /// </summary>
        /// <param name="request">This IUrlRequest</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the response body as a byte array.</returns>
        public static Task<byte[]?> GetBytesAsync(this IUrlRequest request, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return request.SendAsync(HttpMethod.Get, null, completionOption, cancellationToken).ReceiveBytes();
        }

        /// <summary>
        /// Sends an asynchronous POST request.
        /// </summary>
        /// <param name="request">This IUrlRequest</param>
        /// <param name="content">The request body content.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PostAsync(this IUrlRequest request, HttpContent content = null, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return request.SendAsync(HttpMethod.Post, content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Sends an asynchronous POST request.
        /// </summary>
        /// <param name="request">This IUrlRequest</param>
        /// <param name="body">An object representing the request body, which will be serialized to object.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PostObjectAsync(this IUrlRequest request, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            var content = request.Serialize(body);
            return request.SendAsync(HttpMethod.Post, content, completionOption, cancellationToken);
        }
                        
        /// <summary>
        /// Sends an asynchronous POST request.
        /// </summary>
        /// <param name="request">This IUrlRequest</param>
        /// <param name="body">The request body.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PostStringAsync(this IUrlRequest request, string body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            var content = new CapturedStringContent(body);
            return request.SendAsync(HttpMethod.Post, content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Sends an asynchronous POST request.
        /// </summary>
        /// <param name="request">This IUrlRequest</param>
        /// <param name="body">An object representing the request body, which will be serialized to a URL-encoded string.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PostUrlEncodedAsync(this IUrlRequest request, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            var content = new CapturedUrlEncodedContent(request.Settings.UrlEncodedSerializer.Serialize(body));
            return request.SendAsync(HttpMethod.Post, content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Sends an asynchronous HEAD request.
        /// </summary>
        /// <param name="request">This IUrlRequest</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> HeadAsync(this IUrlRequest request, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return request.SendAsync(HttpMethod.Head, null, completionOption, cancellationToken);
        }

        /// <summary>
        /// Sends an asynchronous PUT request.
        /// </summary>
        /// <param name="request">This IUrlRequest</param>
        /// <param name="content">The request body content.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PutAsync(this IUrlRequest request, HttpContent content = null, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return request.SendAsync(HttpMethod.Put, content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Sends an asynchronous PUT request.
        /// </summary>
        /// <param name="request">This IUrlRequest</param>
        /// <param name="body">An object representing the request body, which will be serialized to JSON.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PutObjectAsync(this IUrlRequest request, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            var content = request.Serialize(body);
            return request.SendAsync(HttpMethod.Put, content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Sends an asynchronous PUT request.
        /// </summary>
        /// <param name="request">This IUrlRequest</param>
        /// <param name="body">The request body.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PutStringAsync(this IUrlRequest request, string body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            var content = new CapturedStringContent(body);
            return request.SendAsync(HttpMethod.Put, content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Sends an asynchronous DELETE request.
        /// </summary>
        /// <param name="request">This IUrlRequest</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> DeleteAsync(this IUrlRequest request, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return request.SendAsync(HttpMethod.Delete, null, completionOption, cancellationToken);
        }

        /// <summary>
        /// Sends an asynchronous PATCH request.
        /// </summary>
        /// <param name="request">This IUrlRequest</param>
        /// <param name="content">The request body content.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PatchAsync(this IUrlRequest request, HttpContent content = null, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return request.SendAsync(new HttpMethod("PATCH"), content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Sends an asynchronous PATCH request.
        /// </summary>
        /// <param name="request">This IUrlRequest</param>
        /// <param name="body">An object representing the request body, which will be serialized to JSON.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PatchObjectAsync(this IUrlRequest request, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            var content = request.Serialize(body);
            return request.SendAsync(new HttpMethod("PATCH"), content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Sends an asynchronous PATCH request.
        /// </summary>
        /// <param name="request">This IUrlRequest</param>
        /// <param name="body">The request body.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PatchStringAsync(this IUrlRequest request, string body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            var content = new CapturedStringContent(body);
            return request.SendAsync(new HttpMethod("PATCH"), content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Sends an asynchronous OPTIONS request.
        /// </summary>
        /// <param name="request">This IUrlRequest</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> OptionsAsync(this IUrlRequest request, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return request.SendAsync(HttpMethod.Options, null, completionOption, cancellationToken);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlRequest"/> class.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns><see cref="UrlRequest"/></returns>
        public static UrlRequest Request(this Url url)
        {
            return new UrlRequest(url);
        }
     
        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous request.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="verb">The HTTP verb used to make the request.</param>
        /// <param name="content">The request body content.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> SendAsync(this Url url, HttpMethod verb, HttpContent content = null, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).SendAsync(verb, content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous request.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="verb">The HTTP verb used to make the request.</param>
        /// <param name="body">An object representing the request body, which will be serialized to JSON.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> SendObjectAsync(this Url url, HttpMethod verb, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).SendObjectAsync(verb, body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous request.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="verb">The HTTP verb used to make the request.</param>
        /// <param name="body">The request body.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> SendStringAsync(this Url url, HttpMethod verb, string body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).SendStringAsync(verb, body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous request.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="verb">The HTTP verb used to make the request.</param>
        /// <param name="body">An object representing the request body, which will be serialized to a URL-encoded string.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> SendUrlEncodedAsync(this Url url, HttpMethod verb, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).SendUrlEncodedAsync(verb, body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous GET request.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> GetAsync(this Url url, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).GetAsync(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous GET request.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the JSON response body deserialized to an object of type T.</returns>
        public static Task<T?> GetObjectAsync<T>(this Url url, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).GetObjectAsync<T>(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous GET request.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the response body as a string.</returns>
        public static Task<string?> GetStringAsync(this Url url, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).GetStringAsync(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous GET request.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the response body as a Stream.</returns>
        public static Task<Stream?> GetStreamAsync(this Url url, HttpCompletionOption completionOption = HttpCompletionOption.ResponseHeadersRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).GetStreamAsync(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous GET request.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the response body as a byte array.</returns>
        public static Task<byte[]?> GetBytesAsync(this Url url, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).GetBytesAsync(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous POST request.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="content">The request body content.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PostAsync(this Url url, HttpContent content = null, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).PostAsync(content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous POST request.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="body">An object representing the request body, which will be serialized to JSON.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PostObjectAsync(this Url url, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).PostObjectAsync(body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous POST request.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="body">The request body.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PostStringAsync(this Url url, string body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).PostStringAsync(body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous POST request.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="body">An object representing the request body, which will be serialized to a URL-encoded string.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PostUrlEncodedAsync(this Url url, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).PostUrlEncodedAsync(body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous HEAD request.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> HeadAsync(this Url url, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).HeadAsync(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous PUT request.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="content">The request body content.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PutAsync(this Url url, HttpContent content = null, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).PutAsync(content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous PUT request.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="body">An object representing the request body, which will be serialized to JSON.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PutJsonAsync(this Url url, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).PutObjectAsync(body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous PUT request.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="body">The request body.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PutStringAsync(this Url url, string body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).PutStringAsync(body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous DELETE request.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> DeleteAsync(this Url url, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).DeleteAsync(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous PATCH request.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="content">The request body content.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PatchAsync(this Url url, HttpContent content = null, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).PatchAsync(content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous PATCH request.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="body">An object representing the request body, which will be serialized to JSON.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PatchObjectAsync(this Url url, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).PatchObjectAsync(body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous PATCH request.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="body">The request body.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PatchStringAsync(this Url url, string body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).PatchStringAsync(body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous OPTIONS request.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> OptionsAsync(this Url url, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).OptionsAsync(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a new UrlRequest and asynchronously downloads a file.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="localFolderPath">Path of local folder where file is to be downloaded.</param>
        /// <param name="localFileName">Name of local file. If not specified, the source filename (last segment of the URL) is used.</param>
        /// <param name="bufferSize">Buffer size in bytes. Default is 4096.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the local path of the downloaded file.</returns>
        public static Task<string> DownloadFileAsync(this Url url, string localFolderPath, string localFileName = null, int bufferSize = 4096, HttpCompletionOption completionOption = HttpCompletionOption.ResponseHeadersRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).DownloadFileAsync(localFolderPath, localFileName, bufferSize, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous multipart/form-data POST request.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="buildContent">A delegate for building the content parts.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PostMultipartAsync(this Url url, Action<CapturedMultipartContent> buildContent, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).PostMultipartAsync(buildContent, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a new UrlRequest and sets a request header.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="name">The header name.</param>
        /// <param name="value">The header value.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithHeader(this Url url, string name, object value)
        {
            return new UrlRequest(url).WithHeader(name, value);
        }

        /// <summary>
        /// Creates a new UrlRequest and sets request headers based on property names/values of the provided object, or keys/values if object is a dictionary, to be sent.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="headers">Names/values of HTTP headers to set. Typically an anonymous object or IDictionary.</param>
        /// <param name="replaceUnderscoreWithHyphen">If true, underscores in property names will be replaced by hyphens. Default is true.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithHeaders(this Url url, object headers, bool replaceUnderscoreWithHyphen = true)
        {
            return new UrlRequest(url).WithHeaders(headers, replaceUnderscoreWithHyphen);
        }

        /// <summary>
        /// Creates a new UrlRequest and sets the Authorization header according to Basic Authentication protocol.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="userName">User name of authenticating user.</param>
        /// <param name="password">Password of authenticating user.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithBasicAuth(this Url url, string userName, string password)
        {
            return new UrlRequest(url).WithBasicAuth(userName, password);
        }

        /// <summary>
        /// Creates a new UrlRequest and sets the Authorization header with a bearer token according to OAuth 2.0 specification.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="token">The acquired oAuth bearer token.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithOAuthBearerToken(this Url url, string token)
        {
            return new UrlRequest(url).WithOAuthBearerToken(token);
        }

        /// <summary>
        /// Creates a new UrlRequest and adds a name-value pair to its Cookie header. To automatically maintain a cookie "session", consider using a CookieJar or CookieSession instead.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="name">The cookie name.</param>
        /// <param name="value">The cookie value.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithCookie(this Url url, string name, object value)
        {
            return new UrlRequest(url).WithCookie(name, value);
        }

        /// <summary>
        /// Creates a new UrlRequest and adds name-value pairs to its Cookie header based on property names/values of the provided object, or keys/values if object is a dictionary. To automatically maintain a cookie "session", consider using a CookieJar or CookieSession instead.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="values">Names/values of HTTP cookies to set. Typically an anonymous object or IDictionary.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithCookies(this Url url, object values)
        {
            return new UrlRequest(url).WithCookies(values);
        }

        /// <summary>
        /// Creates a new UrlRequest and sets the CookieJar associated with this request, which will be updated with any Set-Cookie headers present in the response and is suitable for reuse in subsequent requests.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="cookieJar">The CookieJar.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithCookies(this Url url, CookieJar cookieJar)
        {
            return new UrlRequest(url).WithCookies(cookieJar);
        }

        /// <summary>
        /// Creates a new UrlRequest and associates it with a new CookieJar, which will be updated with any Set-Cookie headers present in the response and is suitable for reuse in subsequent requests.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="cookieJar">The created CookieJar, which can be reused in subsequent requests.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithCookies(this Url url, out CookieJar cookieJar)
        {
            return new UrlRequest(url).WithCookies(out cookieJar);
        }

        /// <summary>
        /// Creates a new UrlRequest and allows changing its Settings inline.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="action">A delegate defining the Settings changes.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest ConfigureRequest(this Url url, Action<UrlHttpSettings> action)
        {
            return new UrlRequest(url).ConfigureRequest(action);
        }

        /// <summary>
        /// Creates a new UrlRequest and sets the request timeout.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="timespan">Time to wait before the request times out.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithTimeout(this Url url, TimeSpan timespan)
        {
            return new UrlRequest(url).WithTimeout(timespan);
        }

        /// <summary>
        /// Creates a new UrlRequest and sets the request timeout.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="seconds">Seconds to wait before the request times out.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithTimeout(this Url url, int seconds)
        {
            return new UrlRequest(url).WithTimeout(seconds);
        }

        /// <summary>
        /// Creates a new UrlRequest and adds a pattern representing an HTTP status code or range of codes which (in addition to 2xx) will NOT result in a UrlHttpException being thrown.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="pattern">Examples: "3xx", "100,300,600", "100-299,6xx"</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest AllowHttpStatus(this Url url, string pattern)
        {
            return new UrlRequest(url).AllowHttpStatus(pattern);
        }

        /// <summary>
        /// Creates a new UrlRequest and adds an HttpStatusCode which (in addition to 2xx) will NOT result in a UrlHttpException being thrown.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="statusCodes">The HttpStatusCode(s) to allow.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest AllowHttpStatus(this Url url, params HttpStatusCode[] statusCodes)
        {
            return new UrlRequest(url).AllowHttpStatus(statusCodes);
        }

        /// <summary>
        /// Creates a new UrlRequest and configures it to allow any returned HTTP status without throwing a UrlHttpException.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest AllowAnyHttpStatus(this Url url)
        {
            return new UrlRequest(url).AllowAnyHttpStatus();
        }

        /// <summary>
        /// Creates a new UrlRequest and configures whether redirects are automatically followed.
        /// </summary>
        /// <param name="url">This Url.</param>
        /// <param name="enabled">true if url should automatically send a new request to the redirect URL, false if it should not.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithAutoRedirect(this Url url, bool enabled)
        {
            return new UrlRequest(url).WithAutoRedirect(enabled);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous request.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="verb">The HTTP verb used to make the request.</param>
        /// <param name="content">The request body content.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> SendAsync(this string url, HttpMethod verb, HttpContent content = null, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).SendAsync(verb, content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous request.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="verb">The HTTP verb used to make the request.</param>
        /// <param name="body">An object representing the request body, which will be serialized to JSON.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> SendJsonAsync(this string url, HttpMethod verb, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).SendObjectAsync(verb, body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous request.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="verb">The HTTP verb used to make the request.</param>
        /// <param name="body">The request body.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> SendStringAsync(this string url, HttpMethod verb, string body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).SendStringAsync(verb, body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous request.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="verb">The HTTP verb used to make the request.</param>
        /// <param name="body">An object representing the request body, which will be serialized to a URL-encoded string.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> SendUrlEncodedAsync(this string url, HttpMethod verb, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).SendUrlEncodedAsync(verb, body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous GET request.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> GetAsync(this string url, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).GetAsync(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous GET request.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the JSON response body deserialized to an object of type T.</returns>
        public static Task<T?> GetObjectAsync<T>(this string url, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).GetObjectAsync<T>(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous GET request.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the response body as a string.</returns>
        public static Task<string?> GetStringAsync(this string url, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).GetStringAsync(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous GET request.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the response body as a Stream.</returns>
        public static Task<Stream?> GetStreamAsync(this string url, HttpCompletionOption completionOption = HttpCompletionOption.ResponseHeadersRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).GetStreamAsync(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous GET request.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the response body as a byte array.</returns>
        public static Task<byte[]?> GetBytesAsync(this string url, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).GetBytesAsync(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous POST request.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="content">The request body content.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PostAsync(this string url, HttpContent content = null, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).PostAsync(content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous POST request.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="body">An object representing the request body, which will be serialized to JSON.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PostJsonAsync(this string url, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).PostObjectAsync(body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous POST request.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="body">The request body.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PostStringAsync(this string url, string body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).PostStringAsync(body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous POST request.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="body">An object representing the request body, which will be serialized to a URL-encoded string.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PostUrlEncodedAsync(this string url, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).PostUrlEncodedAsync(body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous HEAD request.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> HeadAsync(this string url, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).HeadAsync(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous PUT request.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="content">The request body content.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PutAsync(this string url, HttpContent content = null, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).PutAsync(content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous PUT request.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="body">An object representing the request body, which will be serialized to JSON.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PutJsonAsync(this string url, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).PutObjectAsync(body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous PUT request.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="body">The request body.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PutStringAsync(this string url, string body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).PutStringAsync(body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous DELETE request.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> DeleteAsync(this string url, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).DeleteAsync(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous PATCH request.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="content">The request body content.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PatchAsync(this string url, HttpContent content = null, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).PatchAsync(content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous PATCH request.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="body">An object representing the request body, which will be serialized to JSON.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PatchJsonAsync(this string url, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).PatchObjectAsync(body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous PATCH request.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="body">The request body.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PatchStringAsync(this string url, string body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).PatchStringAsync(body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous OPTIONS request.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> OptionsAsync(this string url, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).OptionsAsync(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a new UrlRequest and asynchronously downloads a file.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="localFolderPath">Path of local folder where file is to be downloaded.</param>
        /// <param name="localFileName">Name of local file. If not specified, the source filename (last segment of the URL) is used.</param>
        /// <param name="bufferSize">Buffer size in bytes. Default is 4096.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the local path of the downloaded file.</returns>
        public static Task<string> DownloadFileAsync(this string url, string localFolderPath, string localFileName = null, int bufferSize = 4096, HttpCompletionOption completionOption = HttpCompletionOption.ResponseHeadersRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).DownloadFileAsync(localFolderPath, localFileName, bufferSize, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous multipart/form-data POST request.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="buildContent">A delegate for building the content parts.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PostMultipartAsync(this string url, Action<CapturedMultipartContent> buildContent, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(url).PostMultipartAsync(buildContent, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a new UrlRequest and sets a request header.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="name">The header name.</param>
        /// <param name="value">The header value.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithHeader(this string url, string name, object value)
        {
            return new UrlRequest(url).WithHeader(name, value);
        }

        /// <summary>
        /// Creates a new UrlRequest and sets request headers based on property names/values of the provided object, or keys/values if object is a dictionary, to be sent.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="headers">Names/values of HTTP headers to set. Typically an anonymous object or IDictionary.</param>
        /// <param name="replaceUnderscoreWithHyphen">If true, underscores in property names will be replaced by hyphens. Default is true.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithHeaders(this string url, object headers, bool replaceUnderscoreWithHyphen = true)
        {
            return new UrlRequest(url).WithHeaders(headers, replaceUnderscoreWithHyphen);
        }

        /// <summary>
        /// Creates a new UrlRequest and sets the Authorization header according to Basic Authentication protocol.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="userName">User name of authenticating user.</param>
        /// <param name="password">Password of authenticating user.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithBasicAuth(this string url, string userName, string password)
        {
            return new UrlRequest(url).WithBasicAuth(userName, password);
        }

        /// <summary>
        /// Creates a new UrlRequest and sets the Authorization header with a bearer token according to OAuth 2.0 specification.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="token">The acquired oAuth bearer token.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithOAuthBearerToken(this string url, string token)
        {
            return new UrlRequest(url).WithOAuthBearerToken(token);
        }

        /// <summary>
        /// Creates a new UrlRequest and adds a name-value pair to its Cookie header. To automatically maintain a cookie "session", consider using a CookieJar or CookieSession instead.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="name">The cookie name.</param>
        /// <param name="value">The cookie value.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithCookie(this string url, string name, object value)
        {
            return new UrlRequest(url).WithCookie(name, value);
        }

        /// <summary>
        /// Creates a new UrlRequest and adds name-value pairs to its Cookie header based on property names/values of the provided object, or keys/values if object is a dictionary. To automatically maintain a cookie "session", consider using a CookieJar or CookieSession instead.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="values">Names/values of HTTP cookies to set. Typically an anonymous object or IDictionary.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithCookies(this string url, object values)
        {
            return new UrlRequest(url).WithCookies(values);
        }

        /// <summary>
        /// Creates a new UrlRequest and sets the CookieJar associated with this request, which will be updated with any Set-Cookie headers present in the response and is suitable for reuse in subsequent requests.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="cookieJar">The CookieJar.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithCookies(this string url, CookieJar cookieJar)
        {
            return new UrlRequest(url).WithCookies(cookieJar);
        }

        /// <summary>
        /// Creates a new UrlRequest and associates it with a new CookieJar, which will be updated with any Set-Cookie headers present in the response and is suitable for reuse in subsequent requests.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="cookieJar">The created CookieJar, which can be reused in subsequent requests.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithCookies(this string url, out CookieJar cookieJar)
        {
            return new UrlRequest(url).WithCookies(out cookieJar);
        }

        /// <summary>
        /// Creates a new UrlRequest and allows changing its Settings inline.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="action">A delegate defining the Settings changes.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest ConfigureRequest(this string url, Action<UrlHttpSettings> action)
        {
            return new UrlRequest(url).ConfigureRequest(action);
        }

        /// <summary>
        /// Creates a new UrlRequest and sets the request timeout.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="timespan">Time to wait before the request times out.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithTimeout(this string url, TimeSpan timespan)
        {
            return new UrlRequest(url).WithTimeout(timespan);
        }

        /// <summary>
        /// Creates a new UrlRequest and sets the request timeout.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="seconds">Seconds to wait before the request times out.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithTimeout(this string url, int seconds)
        {
            return new UrlRequest(url).WithTimeout(seconds);
        }

        /// <summary>
        /// Creates a new UrlRequest and adds a pattern representing an HTTP status code or range of codes which (in addition to 2xx) will NOT result in a UrlHttpException being thrown.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="pattern">Examples: "3xx", "100,300,600", "100-299,6xx"</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest AllowHttpStatus(this string url, string pattern)
        {
            return new UrlRequest(url).AllowHttpStatus(pattern);
        }

        /// <summary>
        /// Creates a new UrlRequest and adds an HttpStatusCode which (in addition to 2xx) will NOT result in a UrlHttpException being thrown.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="statusCodes">The HttpStatusCode(s) to allow.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest AllowHttpStatus(this string url, params HttpStatusCode[] statusCodes)
        {
            return new UrlRequest(url).AllowHttpStatus(statusCodes);
        }

        /// <summary>
        /// Creates a new UrlRequest and configures it to allow any returned HTTP status without throwing a UrlHttpException.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest AllowAnyHttpStatus(this string url)
        {
            return new UrlRequest(url).AllowAnyHttpStatus();
        }

        /// <summary>
        /// Creates a new UrlRequest and configures whether redirects are automatically followed.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="enabled">true if url should automatically send a new request to the redirect URL, false if it should not.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithAutoRedirect(this string url, bool enabled)
        {
            return new UrlRequest(url).WithAutoRedirect(enabled);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous request.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="verb">The HTTP verb used to make the request.</param>
        /// <param name="content">The request body content.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> SendAsync(this Uri uri, HttpMethod verb, HttpContent content = null, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).SendAsync(verb, content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous request.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="verb">The HTTP verb used to make the request.</param>
        /// <param name="body">An object representing the request body, which will be serialized to JSON.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> SendObjectAsync(this Uri uri, HttpMethod verb, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).SendObjectAsync(verb, body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous request.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="verb">The HTTP verb used to make the request.</param>
        /// <param name="body">The request body.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> SendStringAsync(this Uri uri, HttpMethod verb, string body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).SendStringAsync(verb, body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous request.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="verb">The HTTP verb used to make the request.</param>
        /// <param name="body">An object representing the request body, which will be serialized to a URL-encoded string.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> SendUrlEncodedAsync(this Uri uri, HttpMethod verb, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).SendUrlEncodedAsync(verb, body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous GET request.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> GetAsync(this Uri uri, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).GetAsync(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous GET request.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the JSON response body deserialized to an object of type T.</returns>
        public static Task<T?> GetJsonAsync<T>(this Uri uri, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).GetObjectAsync<T>(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous GET request.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the response body as a string.</returns>
        public static Task<string?> GetStringAsync(this Uri uri, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).GetStringAsync(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous GET request.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the response body as a Stream.</returns>
        public static Task<Stream?> GetStreamAsync(this Uri uri, HttpCompletionOption completionOption = HttpCompletionOption.ResponseHeadersRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).GetStreamAsync(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous GET request.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the response body as a byte array.</returns>
        public static Task<byte[]?> GetBytesAsync(this Uri uri, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).GetBytesAsync(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous POST request.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="content">The request body content.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PostAsync(this Uri uri, HttpContent content = null, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).PostAsync(content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous POST request.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="body">An object representing the request body, which will be serialized to JSON.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PostObjectAsync(this Uri uri, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).PostObjectAsync(body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous POST request.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="body">The request body.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PostStringAsync(this Uri uri, string body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).PostStringAsync(body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous POST request.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="body">An object representing the request body, which will be serialized to a URL-encoded string.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PostUrlEncodedAsync(this Uri uri, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).PostUrlEncodedAsync(body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous HEAD request.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> HeadAsync(this Uri uri, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).HeadAsync(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous PUT request.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="content">The request body content.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PutAsync(this Uri uri, HttpContent? content = null, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).PutAsync(content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous PUT request.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="body">An object representing the request body, which will be serialized to JSON.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PutObjectAsync(this Uri uri, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).PutObjectAsync(body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous PUT request.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="body">The request body.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PutStringAsync(this Uri uri, string body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).PutStringAsync(body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous DELETE request.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> DeleteAsync(this Uri uri, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).DeleteAsync(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous PATCH request.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="content">The request body content.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PatchAsync(this Uri uri, HttpContent? content = null, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).PatchAsync(content, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous PATCH request.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="body">An object representing the request body, which will be serialized to JSON.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PatchObjectAsync(this Uri uri, object body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).PatchObjectAsync(body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous PATCH request.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="body">The request body.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PatchStringAsync(this Uri uri, string body, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).PatchStringAsync(body, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous OPTIONS request.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> OptionsAsync(this Uri uri, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).OptionsAsync(completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a new UrlRequest and asynchronously downloads a file.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="localFolderPath">Path of local folder where file is to be downloaded.</param>
        /// <param name="localFileName">Name of local file. If not specified, the source filename (last segment of the URL) is used.</param>
        /// <param name="bufferSize">Buffer size in bytes. Default is 4096.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the local path of the downloaded file.</returns>
        public static Task<string> DownloadFileAsync(this Uri uri, string localFolderPath, string? localFileName = null, int bufferSize = 4096, HttpCompletionOption completionOption = HttpCompletionOption.ResponseHeadersRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).DownloadFileAsync(localFolderPath, localFileName, bufferSize, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a UrlRequest and sends an asynchronous multipart/form-data POST request.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="buildContent">A delegate for building the content parts.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PostMultipartAsync(this Uri uri, Action<CapturedMultipartContent> buildContent, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            return new UrlRequest(uri).PostMultipartAsync(buildContent, completionOption, cancellationToken);
        }

        /// <summary>
        /// Creates a new UrlRequest and sets a request header.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="name">The header name.</param>
        /// <param name="value">The header value.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithHeader(this Uri uri, string name, object value)
        {
            return new UrlRequest(uri).WithHeader(name, value);
        }

        /// <summary>
        /// Creates a new UrlRequest and sets request headers based on property names/values of the provided object, or keys/values if object is a dictionary, to be sent.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="headers">Names/values of HTTP headers to set. Typically an anonymous object or IDictionary.</param>
        /// <param name="replaceUnderscoreWithHyphen">If true, underscores in property names will be replaced by hyphens. Default is true.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithHeaders(this Uri uri, object headers, bool replaceUnderscoreWithHyphen = true)
        {
            return new UrlRequest(uri).WithHeaders(headers, replaceUnderscoreWithHyphen);
        }

        /// <summary>
        /// Creates a new UrlRequest and sets the Authorization header according to Basic Authentication protocol.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="userName">User name of authenticating user.</param>
        /// <param name="password">Password of authenticating user.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithBasicAuth(this Uri uri, string userName, string password)
        {
            return new UrlRequest(uri).WithBasicAuth(userName, password);
        }

        /// <summary>
        /// Creates a new UrlRequest and sets the Authorization header with a bearer token according to OAuth 2.0 specification.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="token">The acquired oAuth bearer token.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithOAuthBearerToken(this Uri uri, string token)
        {
            return new UrlRequest(uri).WithOAuthBearerToken(token);
        }

        /// <summary>
        /// Creates a new UrlRequest and adds a name-value pair to its Cookie header. To automatically maintain a cookie "session", consider using a CookieJar or CookieSession instead.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="name">The cookie name.</param>
        /// <param name="value">The cookie value.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithCookie(this Uri uri, string name, object value)
        {
            return new UrlRequest(uri).WithCookie(name, value);
        }

        /// <summary>
        /// Creates a new UrlRequest and adds name-value pairs to its Cookie header based on property names/values of the provided object, or keys/values if object is a dictionary. To automatically maintain a cookie "session", consider using a CookieJar or CookieSession instead.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="values">Names/values of HTTP cookies to set. Typically an anonymous object or IDictionary.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithCookies(this Uri uri, object values)
        {
            return new UrlRequest(uri).WithCookies(values);
        }

        /// <summary>
        /// Creates a new UrlRequest and sets the CookieJar associated with this request, which will be updated with any Set-Cookie headers present in the response and is suitable for reuse in subsequent requests.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="cookieJar">The CookieJar.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithCookies(this Uri uri, CookieJar cookieJar)
        {
            return new UrlRequest(uri).WithCookies(cookieJar);
        }

        /// <summary>
        /// Creates a new UrlRequest and associates it with a new CookieJar, which will be updated with any Set-Cookie headers present in the response and is suitable for reuse in subsequent requests.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="cookieJar">The created CookieJar, which can be reused in subsequent requests.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithCookies(this Uri uri, out CookieJar cookieJar)
        {
            return new UrlRequest(uri).WithCookies(out cookieJar);
        }

        /// <summary>
        /// Creates a new UrlRequest and allows changing its Settings inline.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="action">A delegate defining the Settings changes.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest ConfigureRequest(this Uri uri, Action<UrlHttpSettings> action)
        {
            return new UrlRequest(uri).ConfigureRequest(action);
        }

        /// <summary>
        /// Creates a new UrlRequest and sets the request timeout.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="timespan">Time to wait before the request times out.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithTimeout(this Uri uri, TimeSpan timespan)
        {
            return new UrlRequest(uri).WithTimeout(timespan);
        }

        /// <summary>
        /// Creates a new UrlRequest and sets the request timeout.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="seconds">Seconds to wait before the request times out.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithTimeout(this Uri uri, int seconds)
        {
            return new UrlRequest(uri).WithTimeout(seconds);
        }

        /// <summary>
        /// Creates a new UrlRequest and adds a pattern representing an HTTP status code or range of codes which (in addition to 2xx) will NOT result in a UrlHttpException being thrown.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="pattern">Examples: "3xx", "100,300,600", "100-299,6xx"</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest AllowHttpStatus(this Uri uri, string pattern)
        {
            return new UrlRequest(uri).AllowHttpStatus(pattern);
        }

        /// <summary>
        /// Creates a new UrlRequest and adds an HttpStatusCode which (in addition to 2xx) will NOT result in a UrlHttpException being thrown.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="statusCodes">The HttpStatusCode(s) to allow.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest AllowHttpStatus(this Uri uri, params HttpStatusCode[] statusCodes)
        {
            return new UrlRequest(uri).AllowHttpStatus(statusCodes);
        }

        /// <summary>
        /// Creates a new UrlRequest and configures it to allow any returned HTTP status without throwing a UrlHttpException.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest AllowAnyHttpStatus(this Uri uri)
        {
            return new UrlRequest(uri).AllowAnyHttpStatus();
        }

        /// <summary>
        /// Creates a new UrlRequest and configures whether redirects are automatically followed.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="enabled">true if Url should automatically send a new request to the redirect URL, false if it should not.</param>
        /// <returns>A new IUrlRequest.</returns>
        public static IUrlRequest WithAutoRedirect(this Uri uri, bool enabled)
        {
            return new UrlRequest(uri).WithAutoRedirect(enabled);
        }


        /// <summary>
        /// Convert object in a <see cref="CapturedObjectContent"/>
        /// </summary>
        /// <param name="self">Request</param>
        /// <param name="body">object to serialize</param>
        /// <returns></returns>
        public static CapturedObjectContent Serialize(this IUrlRequest self, object body)
        {
            return new CapturedObjectContent(self.Settings.JsonSerializer.Serialize(body));
        }


    }
}