using System.Text;

namespace Bb.Curls
{
    /// <summary>
    /// Lexer that tokenize a cURL command line.
    /// </summary>
    public class CurlLexer
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CurlLexer"/> class.
        /// </summary>
        /// <param name="args">The cURL command line arguments to tokenize.</param>
        public CurlLexer(string args)
        {
            _args = args.Trim();
            _index = 0;
            _max = _args.Length;
            _sb = new StringBuilder(_max);
            _current = '\0';
        }

        /// <summary>
        /// Advances to the next token in the cURL command line.
        /// </summary>
        /// <returns><c>true</c> if a token is available; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// This method reads the next token from the command line, handling quoted strings and escaped characters.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var lexer = new CurlLexer("curl -X GET 'https://api.example.com'");
        /// while (lexer.Next())
        /// {
        ///     Console.WriteLine(lexer.Current);
        /// }
        /// </code>
        /// </example>
        public bool Next()
        {
            _sb.Clear();
            if (_index >= _max) return false;

            while (_index < _max)
            {
                _current = _args[_index++];
                if (!char.IsWhiteSpace(_current))
                {
                    if (_current == '\'')
                        ParseTextChain('\'');

                    else if (_current == '"')
                        ParseTextChain('"');

                    else
                        _sb.Append(_current);

                    _old = _current;
                }
                else
                    break;
            }


            if (_sb.ToString() == "\\" && _index <= _max)
            {
                _current = _args[_index++];
                if (_current == '\n')
                    _sb.Clear();
            }

            return true;
        }

        /// <summary>
        /// Parses a quoted text chain from the command line.
        /// </summary>
        /// <param name="charset">The character used to delimit the quoted text (e.g., single or double quotes).</param>
        /// <remarks>
        /// This method handles escaped characters within the quoted text.
        /// </remarks>
        private void ParseTextChain(char charset)
        {
            while (_index <= _max)
            {
                _current = _args[_index++];

                if (_current == charset)
                {
                    if (_old == '\\')
                    {
                        _sb.Append(_current);
                        _old = _current;
                    }
                    else
                        return;
                }
                else
                    _sb.Append(_current);

                _old = _current;
            }
        }

        /// <summary>
        /// Gets the current token from the command line.
        /// </summary>
        /// <value>The current token as a string.</value>
        public string Current => _sb.ToString();

        /// <summary>
        /// Gets the current position in the command line being tokenized.
        /// </summary>
        /// <value>The current position as an integer.</value>
        public int CurrentPosition => _index;

        private int _index;
        private char _current;
        private char _old;

        private readonly string _args;
        private readonly int _max;
        private readonly StringBuilder _sb;
        
    }
}
