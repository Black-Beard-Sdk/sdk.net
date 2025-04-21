
using RestSharp;
using System.Diagnostics;

namespace Bb.Curls
{


    // https://curlconverter.com/csharp/
    internal partial class CurlInterpreter
    {


        #region Register

        static CurlInterpreter()
        {
            _parameters = new Dictionary<string, Func<ArgumentSource, CurlInterpreterAction?>>();
            // https://reqbin.com/req/c-bjcj04uw/curl-send-cookies-example
            Append(Request, "--request", "-X");                             // <command> Specify request command to use
            Append(Header, "--header", "-H");                               // <header/@file> Pass custom header(s) to server
            Append(Form, "--form", "-F");                                   // <name=content> Specify multipart MIME data
            Append(Data, "--data", "-d");                                   // <data>   HTTP POST data
            Append(Cookie, "--cookie", "-b");                               // <data|filename> Send cookies from string/file
            Append(Cookie, "--cookie-jar", "-c");                           // <filename> Write cookies to <filename> after operation
            Append(OAuthBasic, "--basic", "--user", "-u");                  // Use HTTP Basic Authentication <user:password> Server user and password
            Append(Oauth2Bearer, "--oauth2-bearer");                        // <token> OAuth 2 Bearer Token
        }

        protected static void Append(Func<ArgumentSource, CurlInterpreterAction?> action, params string[] keys)
        {
            if (action != null)
                foreach (var item in keys)
                {
                    if (_parameters.ContainsKey(item))
                        _parameters[item] = action;
                    else
                        _parameters.Add(item, action);
                }
        }

        #endregion Register


        internal static CurlInterpreterAction? SetUrl(ArgumentSource arguments)
        {

            var arg = arguments.GetArgument();

            Action<CurlInterpreterAction, CurlContext> action = (sender, context) =>
            {                
                context.Url = sender.FirstValue;
                context.Request = new RestRequest(context.Url.Path);
                context.Headers.Add("Host", $"{context.Url.Host}:{context.Url.Port}");
            };

            return new CurlInterpreterAction(action, arg) { Priority = 0 };

        }

        internal static CurlInterpreterAction? Request(ArgumentSource arguments)
        {

            Action<CurlInterpreterAction, CurlContext>? action = null;

            if (arguments.ReadNext())
            {

                var argText = arguments.Current;
                switch (argText.ToUpper())
                {
                    case "POST":
                        action = (sender, context) => context.Request.Method = Method.Post;
                        break;

                    case "GET":
                        action = (sender, context) => context.Request.Method = Method.Get;
                        break;

                    case "HEAD":
                        action = (sender, context) => context.Request.Method = Method.Head;
                        break;

                    case "PUT":
                        action = (sender, context) => context.Request.Method = Method.Put;
                        break;

                    case "DELETE":
                        action = (sender, context) => context.Request.Method = Method.Delete;
                        break;                    

                    case "OPTIONS":
                        action = (sender, context) => context.Request.Method = Method.Options;
                        break;

                }

                if (action != null)
                    return new CurlInterpreterAction(action) { Priority = 1 };

                arguments.Failed($"Failed to read action {argText}");

            }
            else
                arguments.Failed($"Failed to read action");

            return null;
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

                static void action(CurlInterpreterAction sender, CurlContext context)
                {
                    var arg = sender.First;
                    if (!string.IsNullOrEmpty(arg.Name))
                    {
                        if (!context.Headers.Contains(arg.Name))
                            context.Headers.AddOrReplace(arg.Name, arg.Value);
                        else
                        {
                            Stop();
                        }
                    }
                }

                var r = new CurlInterpreterAction(action, a) { Priority = 2 };

                if (isMultipart)
                    r.Add("isMultipart", "1");

                return r;

            }

            arguments.Failed($"Failed to read header");

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

                Action<CurlInterpreterAction, CurlContext> actionForm = (sender, context) =>
                {

                    var args = sender.Arguments;
                    var type = args.FirstOrDefault(c => c.Name == "type")?.Value;
                    if (type == null)
                        Stop();

                    int countFile = 0;
                    int countParameter = 0;

                    var list = args.Where(c => c.Name != "type").ToList();
                    foreach (var item in list)
                        SetProperty(context, type, ref countFile, ref countParameter, item);

                    if (countFile > 0)
                        context.Request.AlwaysMultipartFormData = true;
                    
                    else if (countParameter > 1)
                        context.Request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

                };

                return new CurlInterpreterAction(actionForm, _args.ToArray()) { Priority = 3 };

            }

            return null;

        }

        private static void SetProperty(CurlContext context, string? type, ref int countFile, ref int countParameter, Argument item)
        {

            var name = item.Name;
            if (name == null)
            {
                Stop();
                throw new InvalidOperationException(nameof(name));
            }

            if (item.Value.StartsWith("@"))
            {
                var filePath = item.Value.Substring(1);
                if (!File.Exists(filePath))
                {
                    Trace.TraceError($"file not found : {filePath}");
                }
                else
                {
                    context.Request.AddFile(name, filePath, type);
                    countParameter++;
                    countFile++;
                }
            }
            else
            {
                context.Request.AddParameter(name, item.Value);
                countParameter++;
            }
        }

        internal static CurlInterpreterAction? Data(ArgumentSource arguments)
        {

            if (arguments.ReadNext())
            {
                Action<CurlInterpreterAction, CurlContext> action = (sender, context) =>
                {
                    var data = sender.Arguments.First().Value;
                    context.Request.AddParameter("application/x-www-form-urlencoded", data, ParameterType.RequestBody);
                };

                return new CurlInterpreterAction(action, new Argument(arguments.Current))
                {
                    Priority = 60
                };
            }

            return null;

        }

        internal static CurlInterpreterAction? Cookie(ArgumentSource arguments)
        {

            if (arguments.ReadNext())
            { 
                var arg = arguments.Current.Split(':');
                var a = new Argument(arg[1].Trim(), arg[0].Trim());

                static void action(CurlInterpreterAction sender, CurlContext context)
                {
                    if (context.Request.CookieContainer == null)
                        context.Request.CookieContainer = new System.Net.CookieContainer();
                    var uri = context.Url.ToUri();
                    var arg = sender.First;
                    if (!string.IsNullOrEmpty(arg.Name))
                        context.Request.CookieContainer.Add(uri, new System.Net.Cookie( arg.Name, arg.Value));
                }

                return new CurlInterpreterAction(action, a) { Priority = 2 };
            }

            arguments.Failed($"Failed to read cookie");
            return null;

        }

        internal static CurlInterpreterAction? OAuthBasic(ArgumentSource arguments)
        {

            if (arguments.ReadNext())
            {

                string security = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(arguments.Current));
                var headerValue = $"Authorization: Basic {security}";
                var a = new Argument(headerValue);

                static void action(CurlInterpreterAction sender, CurlContext context)
                {
                    string name = "Authorization";
                    context.Headers.AddOrReplace(name, sender.First.Value);
                }

                return new CurlInterpreterAction(action, a);

            }

            return null;

        }

        internal static CurlInterpreterAction? Oauth2Bearer(ArgumentSource arguments)
        {
            if (arguments.ReadNext())
            {
                var token = arguments.Current;
                var headerValue = $"Bearer {token}";
                var a = new Argument(headerValue);

                Action<CurlInterpreterAction, CurlContext> action = (sender, context) =>
                {
                    string name = "Authorization";
                    context.Headers.AddOrReplace(name, sender.First.Value);
                };

                return new CurlInterpreterAction(action, a);
            }

            arguments.Failed($"Failed to read OAuth2 Bearer token");
            return null;
        }


    }


}
