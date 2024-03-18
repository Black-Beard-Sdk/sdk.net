using System.Net.Http.Headers;
using Bb.Http;

namespace Bb.Curls
{

    // https://curlconverter.com/csharp/
    public partial class CurlInterpreter
    {

        /// <summary>
        /// Sets the URL.
        /// </summary>
        /// <returns></returns>
        internal static CurlInterpreterAction? SetUrl(ArgumentSource arguments)
        {

            var arg = arguments.GetArgument();

            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {

                 var client = context.HttpClient;
                 var message = context.RequestMessage;

                 var productValue = new ProductInfoHeaderValue("black.beard.curl", "1.0");
                 var url = new Url(sender.FirstValue);

                 client.DefaultRequestHeaders.UserAgent.Add(productValue);
                 message.RequestUri = new Uri(url);
                 message.Headers.Host = $"{url.Host}:{url.Port}";

                 context.Request = url.Request();

                 return await sender.CallNext(context);

             };

            return new CurlInterpreterAction(action, arg) { Priority = 0 };

        }

        internal static CurlInterpreterAction? Header(ArgumentSource arguments)
        {

            bool isMultipart = false;

            if (arguments.ReadNext())
            {

                var arg = arguments.Current.Split(':');
                var a = new Argument(arg[1].Trim(), arg[0].Trim());


                if (a.Name == "Content-Type" && a.Value.ToLower().Trim().StartsWith("multipart"))
                    isMultipart = true;

                static async Task<HttpResponseMessage> action(CurlInterpreterAction sender, Context context)
                {

                    var message = context.RequestMessage;

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
                        // context.Request.Headers.Add(arg.Name, arg.Name);
                        message.Headers.TryAddWithoutValidation(arg.Name, arg.Value);
                    }

                    return await sender.CallNext(context);

                }

                return new CurlInterpreterAction(action, a)
                {
                    Priority = 100
                }
                .Add("isMultipart", isMultipart ? "1" : "0");
            }

            arguments.Failed($"Failed to read header");

            return null;

        }

        /// <summary>
        /// <command> Specify request command to use
        /// </summary>
        /// <param name="argument">The argument.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        internal static CurlInterpreterAction? Request(ArgumentSource arguments)
        {

            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = null;

            if (arguments.ReadNext())
            {

                var argText = arguments.Current;
                switch (argText.ToUpper())
                {
                    case "POST":
                        action = async (sender, context) =>
                        {
                            var message = context.RequestMessage;
                            message.Method = HttpMethod.Post;
                            return await sender.CallNext(context);
                        };
                        break;

                    case "GET":
                        action = async (sender, context) =>
                        {
                            var message = context.RequestMessage;
                            message.Method = HttpMethod.Get;
                            context.Request.Verb = HttpMethod.Get;
                            return await sender.CallNext(context);
                        };
                        break;

                    case "HEAD":
                        action = async (sender, context) =>
                        {
                            var message = context.RequestMessage;
                            message.Method = HttpMethod.Head;
                            context.Request.Verb = HttpMethod.Head;
                            return await sender.CallNext(context);
                        };
                        break;
                    case "PUT":
                        action = async (sender, context) =>
                        {
                            var message = context.RequestMessage;
                            message.Method = HttpMethod.Put;
                            context.Request.Verb = HttpMethod.Put;
                            return await sender.CallNext(context);
                        };
                        break;

                    case "DELETE":
                        action = async (sender, context) =>
                        {
                            var message = context.RequestMessage;
                            message.Method = HttpMethod.Delete;
                            context.Request.Verb = HttpMethod.Delete;
                            return await sender.CallNext(context);
                        };
                        break;

                    case "CONNECT":
                        action = async (sender, context) =>
                        {
                            var message = context.RequestMessage;
                            message.Method = new HttpMethod("CONNECT");
                            context.Request.Verb = new  HttpMethod("CONNECT");
                            return await sender.CallNext(context);
                        };
                        break;
                    case "OPTIONS":
                        action = async (sender, context) =>
                        {
                            var message = context.RequestMessage;
                            message.Method = HttpMethod.Options;
                            context.Request.Verb = HttpMethod.Options;
                            return await sender.CallNext(context);
                        };
                        break;

                    case "TRACE":
                        action = async (sender, context) =>
                        {
                            var message = context.RequestMessage;
                            message.Method = HttpMethod.Trace;
                            context.Request.Verb = HttpMethod.Trace;
                            return await sender.CallNext(context);
                        };
                        break;

                    case "PATCH":
                        action = async (sender, context) =>
                        {
                            var message = context.RequestMessage;
                            message.Method = new HttpMethod("PATCH");
                            context.Request.Verb = new HttpMethod("PATCH");
                            return await sender.CallNext(context);
                        };
                        break;
                }

                if (action != null)
                    return new CurlInterpreterAction(action) { Priority = 10 };

                arguments.Failed($"Failed to read action {argText}");

            }
            else
                arguments.Failed($"Failed to read action");

            return null;
        }

        internal static CurlInterpreterAction? Form(ArgumentSource arguments)
        {


            if (arguments.ReadNext())
            {

                var arg = arguments.Current.Split(';');
                List<Argument> _args = new List<Argument>(arg.Length);

                foreach (var item in arg)
                {
                    var i = item.Split('=');
                    _args.Add(new Argument(i[1], i[0].Trim()));
                }

                Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
                {

                    var args = sender.Arguments;
                    var client = context.HttpClient;
                    var message = context.RequestMessage;

                    if (context.Has("IsMultipart", "1"))
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
                        return await sender.CallNext(context);

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

                            return await sender.CallNext(context);

                        }

                    }

                };

                return new CurlInterpreterAction(action, _args.ToArray());

            }

            return null;

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

        internal static CurlInterpreterAction? Head(ArgumentSource arguments)
        {
            Stop();

            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };

        }

        internal static CurlInterpreterAction? HaproxyProtocol(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? HappyEyeballsTimeoutMs(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);

             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Globoff(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Get(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? FtpSslControl(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? FtpSslCccMode(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? FtpSslCcc(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? FtpSkipPasvIp(ArgumentSource arguments)
        {
            Stop();

            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? FtpPret(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? FtpPort(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? FtpPasv(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? FtpMethod(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? FtpCreateDirs(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? FtpAlternativeToUser(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? FtpAccount(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? FormString(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? FalseStart(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? FailEarly(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Fail(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Expect100Timeout(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Engine(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? EgdFile(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? DumpHeader(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? DohUrl(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? DnsServers(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? DnsIpv6Addr(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? DnsIpv4Addr(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? DnsInterface(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? DisallowUsernameInUrl(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? DisableEpsv(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? DisableEprt(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Disable(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Digest(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Delegation(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? DataUrlencode(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? DataRaw(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? DataBinary(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? DataAscii(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Data(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Crlfile(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Crlf(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? CreateDirs(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? CookieJar(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Cookie(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ContinueAt(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ConnectTo(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ConnectTimeout(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Config(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? CompressedSsh(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Compressed(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Ciphers(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? CertType(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? CertStatus(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Cert(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Capath(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? CaCert(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Basic(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? AppendMethod(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyNegotiate(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyKeyType(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyKey(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyInsecure(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyHeader(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyDigest(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyCrlfile(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyCiphers(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyCertType(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyCert(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyCapath(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyCacert(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyBasic(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyAnyauth(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Proxy(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProtoRedir(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProtoDefault(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Proto(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProgressBar(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Preproxy(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Post303(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Post302(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Post301(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Pinnedpubkey(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? PathAsIs(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Pass(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Output(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Oauth2Bearer(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? NtlmWb(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Ntlm(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Noproxy(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? NoSessionid(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? NoNpn(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? NoKeepalive(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? NoBuffer(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? NoAlpn(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Next(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? NetrcOptional(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? NetrcFile(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Netrc(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Negotiate(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Metalink(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? MaxTime(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? MaxRedirs(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? MaxFilesize(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Manual(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? MailRcpt(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? MailFrom(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? MailAuth(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? LoginOptions(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? LocationTrusted(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Location(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? LocalPort(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ListOnly(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? LimitRate(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Libcurl(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Krb(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? KeyType(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Key(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? KeepaliveTime(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? JunkSessionCookies(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Ipv6(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Ipv4(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Interface
        {
            get
            {
                Stop();
                Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
                 {
                     Stop();
                     return await sender.CallNext(context);
                 };

                return new CurlInterpreterAction(action) { Priority = 20 };
            }
        }

        public HttpResponseMessage LastResponse { get; internal set; }

        internal static CurlInterpreterAction? Insecure(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Include(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? IgnoreContentLength(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Http2PriorKnowledge(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Http2(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Http11(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Http10(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Http09(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Hostpubmd5(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Help(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? RemoteHeaderName(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Referer(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Raw(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Range(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? RandomFile(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Quote(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Pubkey(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Proxytunnel(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Proxy10(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyUser(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyTlsv1(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyTlsuser(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyTlspassword(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyTlsauthtype(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyTls13Ciphers(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxySslAllowBeast(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyServiceName(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyPinnedpubkey(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyPass(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ProxyNtlm(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }


        internal static CurlInterpreterAction? Anyauth(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? AltSvc(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? AbstractUnixSocket(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Xattr(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? WriteOut(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Version(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Verbose(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? UserAgent(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? User(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? UseAscii(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Url(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? UploadFile(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? UnixSocket(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? TraceTime(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? TraceAscii(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Trace(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? TrEncoding(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Tlsv13(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Tlsv12(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Tlsv11(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Tlsv10(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Tlsv1(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Tlsuser(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Tlspassword(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Tlsauthtype(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Tls13Ciphers(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? TlsMax(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? TimeCond(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? TftpNoOptions(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? TftpBlksize(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? TelnetOption(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? TcpNodelay(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? TcpFastopen(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? SuppressConnectHeaders(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? StyledOutput(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Stderr(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Sslv3(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Sslv2(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? SslReqd(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? SslNoRevoke(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? SslAllowBeast(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Ssl(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? SpeedTime(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? SpeedLimit(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Socks5Hostname(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Socks5GssapiService(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Socks5GssapiNec(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Socks5Gssapi(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Socks5Basic(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Socks5(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Socks4a(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Socks4(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Silent(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ShowError(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? ServiceName(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? SaslIr(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? RetryMaxTime(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? RetryRelay(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? RetryConnrefused(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Retry(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? Resolve(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? RequestTarget(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? RemoteTime(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? RemoteNameAll(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

        internal static CurlInterpreterAction? RemoteName(ArgumentSource arguments)
        {
            Stop();
            Func<CurlInterpreterAction, Context, Task<HttpResponseMessage>> action = async (sender, context) =>
             {
                 Stop();
                 return await sender.CallNext(context);
             };

            return new CurlInterpreterAction(action) { Priority = 20 };
        }

    }


}
