namespace Bb.Curl.Commands
{
    public class Context
    {

        public HttpClient Client { get; internal set; }

        public HttpRequestMessage Message { get; internal set; }

        internal bool IsMultipart { get; set; }

        public async Task<HttpResponseMessage> CallAsync()
        {
            var result = await Client.SendAsync(Message, HttpCompletionOption.ResponseHeadersRead);
            return result;
        }

        public HttpResponseMessage Call()
        {
            return Client.Send(Message, HttpCompletionOption.ResponseHeadersRead);
        }


    }

}
