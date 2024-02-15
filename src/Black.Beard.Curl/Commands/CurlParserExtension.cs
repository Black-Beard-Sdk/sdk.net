using Flurl.Util;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Bb.Curl.Commands
{

    /// <summary>
    /// Specialized curl command parser
    /// </summary>
    public static class CurlParserExtension
    {

        /// <summary>
        /// Initializes the <see cref="CurlParserExtension"/> class.
        /// </summary>
        static CurlParserExtension()
        {

            string pattern = @"(https?|ftp|ssh|mailto):\/\/([a-z]+[a-z0-9.-]+|(\d{1,3}\.){3,3}\d{1,3})(:\d{0,5})?(\/[a-z]+[a-z0-9.-]+)*(\?([a-z]+[a-z0-9%&=+#]*)+)?";
            RegexOptions options = RegexOptions.IgnoreCase;
            _regIsUrl = new Regex(pattern, options);

        }

        /// <summary>
        /// Parses the curl line.
        /// </summary>
        /// <param name="lineArg">The line argument.</param>
        /// <returns></returns>
        public static String[] ParseCurlLine(this string lineArg)
        {

            var _lexer = new CurlLexer(lineArg);

            List<string> result = new List<string>();
            while (_lexer.Next())
            {
                var c = _lexer.Current;
                if (!string.IsNullOrEmpty(c))
                    result.Add(_lexer.Current);
            }
            return result.ToArray();

        }

        public static async Task<HttpResponseMessage> CallAsync(this String[] arguments)
        {
            var interpreter = new CurlInterpreter(arguments);
            return await interpreter.CallAsync();
        }

        /// <summary>
        /// Determines whether this instance is URL.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <returns>
        ///   <c>true</c> if the specified self is URL; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsUrl(this string self)
        {
            return _regIsUrl.IsMatch(self);
        }

        private static readonly Regex _regIsUrl;

    }


}
