using System;
using static System.Collections.Specialized.BitVector32;
using System.Linq;
using Flurl;
using System.Net.Http;
using System.IO;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Bb.Curl.Commands
{

    // https://curlconverter.com/csharp/
    internal partial class CurlInterpreter
    {

        /// <summary>
        /// Sets the URL.
        /// </summary>
        /// <returns></returns>
        public CurlInterpreterAction SetUrl()
        {

            var arg = new Argument(_arguments[_index]);

            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 var url = new Url(sender.FirstValue);
                 client.BaseAddress = url.BaseAddress;
                 message.RequestUri = new Uri(url);
                 message.Headers.Host = $"{url.Host}:{url.Port}";

                 var productValue = new ProductInfoHeaderValue("black.beard.curl", "1.0");
                 this.Context.Client.DefaultRequestHeaders.UserAgent.Add(productValue);

                 return await sender.CallNext();

             };

            return new CurlInterpreterAction(action, arg) { Priority = 0 };

        }

        public CurlInterpreterAction Header()
        {

            var arg = _arguments[++_index].Split(':');

            var a = new Argument(arg[1].Trim(), arg[0].Trim());
            if (a.Name == "Content-Type" && a.Value.ToLower().Trim().StartsWith("multipart"))
                this.Context.IsMultipart = true;

            static async Task<HttpResponseMessage> action(CurlInterpreterAction sender, HttpClient client, HttpRequestMessage message)
            {

                var arg = sender.First;
                if (message.Content != null)
                {
                    switch (arg.Name.ToLower())
                    {

                        case "accept":
                            message.Headers.Add("Accept", arg.Value);
                            break;

                        default:
                            message.Content.Headers.TryAddWithoutValidation(arg.Name, arg.Value);
                            break;
                    }

                    message.Content.Headers.TryAddWithoutValidation(arg.Name, arg.Value);
                }
                else
                {
                    message.Headers.TryAddWithoutValidation(arg.Name, arg.Value);
                }

                return await sender.CallNext();

            }

            return new CurlInterpreterAction(action, a) { Priority = 100 };

        }

        /// <summary>
        /// <command> Specify request command to use
        /// </summary>
        /// <param name="argument">The argument.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public CurlInterpreterAction Request()
        {

            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = null;

            var arg = _arguments[++_index];
            switch (arg.ToUpper())
            {
                case "POST":
                    action = async (sender, client, message) =>
                    {
                        message.Method = HttpMethod.Post;
                        return await sender.CallNext();
                    };
                    break;

                case "GET":
                    action = async (sender, client, message) =>
                    {
                        message.Method = HttpMethod.Get;
                        return await sender.CallNext();
                    };
                    break;

                case "HEAD":
                    action = async (sender, client, message) =>
                    {
                        message.Method = HttpMethod.Head;
                        return await sender.CallNext();
                    };
                    break;
                case "PUT":
                    action = async (sender, client, message) =>
                    {
                        message.Method = HttpMethod.Put;
                        return await sender.CallNext();
                    };
                    break;

                case "DELETE":
                    action = async (sender, client, message) =>
                    {
                        message.Method = HttpMethod.Delete;
                        return await sender.CallNext();
                    };
                    break;

                case "CONNECT":
                    action = async (sender, client, message) =>
                    {
                        Stop();
                        return await sender.CallNext();
                    };
                    break;
                case "OPTIONS":
                    action = async (sender, client, message) =>
                    {
                        message.Method = HttpMethod.Options;
                        return await sender.CallNext();
                    };
                    break;

                case "TRACE":
                    action = async (sender, client, message) =>
                    {
                        message.Method = HttpMethod.Trace;
                        return await sender.CallNext();
                    };
                    break;

                case "PATCH":
                    action = async (sender, client, message) =>
                    {
                        Stop();
                        return await sender.CallNext();
                    };
                    break;
            }

            return new CurlInterpreterAction(action) { Priority = 10 };

        }

        public CurlInterpreterAction Form()
        {

            var arg = _arguments[++_index].Split(';');
            List<Argument> _args = new List<Argument>(arg.Length);

            foreach (var item in arg)
            {
                var i = item.Split('=');
                _args.Add(new Argument(i[1], i[0].Trim()));
            }

            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
            {

                var args = sender.Arguments;

                if (sender.Context.IsMultipart)
                {

                    MultipartFormDataContent content = new MultipartFormDataContent();

                    var f = sender.Get(c => c.Value.StartsWith("@"));
                    if (f != null)
                        UploadFile(content, f, sender);
                    else
                    {
                        Stop();
                    }

                    message.Content = content;
                    return await sender.CallNext();

                }
                else
                {

                    var formVariables = new List<KeyValuePair<string, string>>();

                    foreach (var item in args)
                    {
                        if (item.Value.StartsWith("@"))
                        {
                            Stop();
                        }
                        else
                            formVariables.Add(new KeyValuePair<string, string>(item.Name.Trim(), item.Value.Trim()));
                    }

                    using (var formContent = new FormUrlEncodedContent(formVariables))
                    {
                        message.Content = formContent;

                        return await sender.CallNext();

                    }

                }

            };

            return new CurlInterpreterAction(action, _args.ToArray());

        }

        private static void UploadFile(MultipartFormDataContent content, Argument f, CurlInterpreterAction sender)
        {

            var file = new FileInfo(f.Value.Substring(1));

            var c = new ByteArrayContent(File.ReadAllBytes(file.FullName));
            c.Headers.ContentDisposition = new ContentDispositionHeaderValue($"form-data")
            {
                Name = "\"" + f.Name + "\"",
                FileName = "\"" + file.Name + "\"",
                FileNameStar = string.Empty
            };

            foreach (var item in sender.Arguments)
            {
                switch (item.Name)
                {

                    case "type":
                        c.Headers.ContentType = new MediaTypeHeaderValue(item.Value);
                        break;

                    case "upfile":
                    default:
                        break;
                }
            }

            content.Add(c, "\"" + f.Name + "\"", "\"" + file.Name + "\"");

        }

        public CurlInterpreterAction Head()
        {
            Stop();

            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };

        }

        public CurlInterpreterAction HaproxyProtocol()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction HappyEyeballsTimeoutMs()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();

             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Globoff()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Get()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction FtpSslControl()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction FtpSslCccMode()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction FtpSslCcc()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction FtpSkipPasvIp()
        {
            Stop();

            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction FtpPret()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction FtpPort()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction FtpPasv()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction FtpMethod()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction FtpCreateDirs()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction FtpAlternativeToUser()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction FtpAccount()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction FormString()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction FalseStart()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction FailEarly()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Fail()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Expect100Timeout()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Engine()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction EgdFile()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction DumpHeader()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction DohUrl()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction DnsServers()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction DnsIpv6Addr()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction DnsIpv4Addr()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction DnsInterface()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction DisallowUsernameInUrl()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction DisableEpsv()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction DisableEprt()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Disable()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Digest()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Delegation()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction DataUrlencode()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction DataRaw()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction DataBinary()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction DataAscii()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Data()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Crlfile()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Crlf()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction CreateDirs()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction CookieJar()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Cookie()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ContinueAt()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ConnectTo()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ConnectTimeout()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Config()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction CompressedSsh()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Compressed()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Ciphers()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction CertType()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction CertStatus()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Cert()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Capath()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction CaCert()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Basic()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Append()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyNegotiate()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyKeyType()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyKey()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyInsecure()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyHeader()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyDigest()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyCrlfile()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyCiphers()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyCertType()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyCert()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyCapath()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyCacert()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyBasic()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyAnyauth()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Proxy()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProtoRedir()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProtoDefault()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Proto()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProgressBar()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Preproxy()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Post303()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Post302()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Post301()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Pinnedpubkey()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction PathAsIs()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Pass()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Output()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Oauth2Bearer()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction NtlmWb()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Ntlm()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Noproxy()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction NoSessionid()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction NoNpn()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction NoKeepalive()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction NoBuffer()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction NoAlpn()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Next()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction NetrcOptional()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction NetrcFile()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Netrc()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Negotiate()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Metalink()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction MaxTime()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction MaxRedirs()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction MaxFilesize()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Manual()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction MailRcpt()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction MailFrom()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction MailAuth()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction LoginOptions()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction LocationTrusted()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Location()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction LocalPort()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ListOnly()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction LimitRate()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Libcurl()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Krb()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction KeyType()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Key()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction KeepaliveTime()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction JunkSessionCookies()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Ipv6()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Ipv4()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Interface
        {
            get
            {
                Stop();
                Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
                 {
                     Stop();
                     return await sender.CallNext();
                 };

                return new CurlInterpreterAction(action) { Priority = 20 };
            }
        }

        public CurlInterpreterAction Insecure()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Include()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction IgnoreContentLength()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Http2PriorKnowledge()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Http2()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Http11()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Http10()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Http09()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Hostpubmd5()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Help()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction RemoteHeaderName()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Referer()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Raw()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Range()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction RandomFile()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Quote()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Pubkey()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Proxytunnel()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Proxy10()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyUser()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyTlsv1()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyTlsuser()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyTlspassword()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyTlsauthtype()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyTls13Ciphers()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxySslAllowBeast()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyServiceName()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyPinnedpubkey()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyPass()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ProxyNtlm()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }


        public CurlInterpreterAction Anyauth()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction AltSvc()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction AbstractUnixSocket()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Xattr()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction WriteOut()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Version()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Verbose()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction UserAgent()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction User()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction UseAscii()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Url()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction UploadFile()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction UnixSocket()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction TraceTime()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction TraceAscii()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Trace()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction TrEncoding()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Tlsv13()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Tlsv12()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Tlsv11()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Tlsv10()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Tlsv1()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Tlsuser()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Tlspassword()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Tlsauthtype()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Tls13Ciphers()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction TlsMax()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction TimeCond()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction TftpNoOptions()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction TftpBlksize()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction TelnetOption()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction TcpNodelay()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction TcpFastopen()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction SuppressConnectHeaders()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction StyledOutput()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Stderr()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Sslv3()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Sslv2()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction SslReqd()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction SslNoRevoke()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction SslAllowBeast()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Ssl()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction SpeedTime()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction SpeedLimit()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Socks5Hostname()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Socks5GssapiService()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Socks5GssapiNec()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Socks5Gssapi()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Socks5Basic()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Socks5()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Socks4a()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Socks4()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Silent()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ShowError()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction ServiceName()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction SaslIr()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction RetryMaxTime()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction RetryRelay()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction RetryConnrefused()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Retry()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction Resolve()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction RequestTarget()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction RemoteTime()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction RemoteNameAll()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        public CurlInterpreterAction RemoteName()
        {
            Stop();
            Func<CurlInterpreterAction, HttpClient, HttpRequestMessage, Task<HttpResponseMessage>> action = async (sender, client, message) =>
             {
                 Stop();
                 return await sender.CallNext();
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

    }


}
