using Bb.Http.Content;
using Bb.Util;
using System.Net.Http.Headers;

namespace Bb.Http
{
    /// <summary>
    /// Fluent extension methods for sending multipart/form-data requests.
    /// </summary>
    public static class MultipartExtensions
    {

        /// <summary>
        /// Sends an asynchronous multipart/form-data POST request.
        /// </summary>
        /// <param name="buildContent">A delegate for building the content parts.</param>
        /// <param name="request">The IUrlRequest.</param>
        /// <param name="completionOption">The HttpCompletionOption used in the request. Optional.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A Task whose result is the received IUrlResponse.</returns>
        public static Task<IUrlResponse> PostMultipartAsync(this IUrlRequest request, Action<MultipartFormDataContent> buildContent, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            var cmc = new MultipartFormDataContent();
            buildContent(cmc);
            return request.SendAsync(HttpMethod.Post, cmc, completionOption, cancellationToken);
        }


        public static MultipartFormDataContent AddStringParts(this MultipartFormDataContent self, string name, object data, string? contentType = null)
        {
            foreach (var kv in data.ToKeyValuePairs())
            {
                if (kv.Value == null)
                    continue;
                self.AddString(kv.Key, kv.Value.ToInvariantString(), contentType);
            }
            return self;
        }

        public static MultipartFormDataContent AddJson(this MultipartFormDataContent self, string name, string data)
        {

            var content = new StringContent(data);
            content.Headers.TryAddWithoutValidation("Content-Type", ContentType.ApplicationJsonCharsetUtf8.Constant);

            self.Add(content, name);
            return self;
        }

        public static MultipartFormDataContent AddString(this MultipartFormDataContent self, string name, string data, string? contentType = null)
        {
            var content = new StringContent(data);

            if (!string.IsNullOrEmpty(contentType))
                content.Headers.TryAddWithoutValidation("Content-Type", contentType);

            self.Add(content, name);
            return self;
        }

        public static MultipartFormDataContent AddUrlEncoded(this MultipartFormDataContent self, string name, List<KeyValuePair<string, string>> data)
        {
            var item = new FormUrlEncodedContent(data);
            self.Add(item, name);
            return self;
        }


        public static MultipartFormDataContent AddFile(this MultipartFormDataContent self, string name, string filename, string? contentType = null)
        {

            var filePath = filename;

            if (filePath.StartsWith("@"))
                filePath = filePath.Substring(1);

            HttpContent content = new StreamContent(new FileStream(filePath, FileMode.Open));

            if (!string.IsNullOrEmpty(contentType))
                content.Headers.TryAddWithoutValidation("Content-Type", contentType);

            content.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = name,
                FileName = Path.GetFileName(filePath)
            };
            self.Add(new StringContent(name), name);
            self.Add(content);

            return self;

        }

        public static T WithContentType<T>(this T self, ContentType contentType)
            where T : HttpContent
        {
            self.Headers.TryAddWithoutValidation("Content-Type", contentType.Constant);
            return self;
        }

    }

    public class ContentType
    {

        public ContentType(string contentType)
        {
            this.Constant = contentType;        
        }


        public static ContentType ApplicationxWwwFormUrlencoded = new ContentType( "application/x-www-form-urlencoded");
        public static ContentType ApplicationJsonCharsetUtf8 = new ContentType("application/json; charset=UTF-8");

        public string Constant { get; }

    }

}
