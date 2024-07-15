namespace Bb
{
    public class VariablesDictionary : Variables
    {

        public VariablesDictionary()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public VariablesDictionary(IDictionary<string, string> dictionary)
        {
            _dictionary = dictionary;
        }

        /// <summary>
        /// Add a variable by name and value.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void Add(string name, string value)
        {
            _dictionary[name] = value;
        }

        /// <summary>
        /// Resolve a variable by name.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resultValue"></param>
        /// <returns></returns>
        public override bool TryGet(string name, out string? resultValue)
        {
            return _dictionary.TryGetValue(name, out resultValue);
        }

        private readonly IDictionary<string, string> _dictionary;

    }
}