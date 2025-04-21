

using Bb.Interfaces;
using System.Text.RegularExpressions;

namespace Bb.Curls
{

    /// <summary>
    /// Specialized curl command parser
    /// </summary>
    public static partial class CurlParserExtension
    {

        /// <summary>
        /// Initializes the <see cref="CurlParserExtension"/> class.
        /// </summary>
        static CurlParserExtension()
        {
            _regIsUrl = new Regex(pattern, options);
        }

        /// <summary>
        /// Parses the curl line.
        /// </summary>
        /// <param name="lineArg">The line argument.</param>
        /// <returns></returns>
        public static string[] ParseCurlLine(this string lineArg)
        {

            var _lexer = new CurlLexer(lineArg);

            List<string> result = new List<string>();
            while (_lexer.Next())
            {

                var c = _lexer.Current;

                if (!string.IsNullOrEmpty(c))
                {
                    if ((c.StartsWith("-") && c.Length == 1) || (c.StartsWith("--") && c.Length == 2))
                        throw new ArgumentException($"Invalid argument {c} at position {_lexer.CurrentPosition}");

                    result.Add(c);

                }
            }

            return result.ToArray();

        }


        /// <summary>
        /// Determines whether this instance is an URL.
        /// </summary>
        /// <param name="self">The self text to test.</param>
        /// <returns>
        ///   <c>true</c> if the specified self is URL; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsUrl(this string self)
        {
            return _regIsUrl.IsMatch(self);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="factory"></param>
        /// <returns></returns>
        public static Curl AsCurl(this string self, IRestClientFactory? factory = null)
        {
            return new Curl(factory)
                .WithCommand(self)
                ;
        }

        private const string pattern = @"(https?|ftp|ssh|mailto):\/\/([a-z]+[a-z0-9.-]+|(\d{1,3}\.){3,3}\d{1,3})(:\d{0,5})?(\/[a-z]+[a-z0-9.-]+)*(\?([a-z]+[a-z0-9%&=+#]*)+)?";
        private const RegexOptions options = RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Singleline | RegexOptions.ExplicitCapture;

        //[GeneratedRegex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Singleline | RegexOptions.ExplicitCapture)]
        //private static partial Regex _regIsUrl();
        private static readonly Regex _regIsUrl;


    }

}
