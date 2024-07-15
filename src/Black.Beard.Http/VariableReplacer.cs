using System.Text.RegularExpressions;

namespace Bb
{


    /// <summary>
    /// Variable replacer
    /// </summary>
    public static class VariableReplacer
    {

        /// <summary>
        /// replace variables in a string with their values from the environment.
        /// </summary>
        /// <param name="input">Input text</param>
        /// <returns>the computed value</returns>       
		public static string ReplaceVariables(this string input)
        {

            if (string.IsNullOrEmpty(input))
                return input;

            var resultChain = input.ToString();

            HashSet<string> excludes = new HashSet<string>();
            bool to_change = input.Contains("@{");

            while (to_change)
            {

                to_change = false;
                var words = _envVarRegex.Matches(resultChain)
                    .Select(item => item.Groups[1].Value)
                    .ToList();

                for (int i = 0; i < words.Count; i++)
                {
                    var word = words[i];
                    if (!excludes.Contains(word))
                    {
                        if (Variables.Resolve(word, out var value))
                        {
                            resultChain = resultChain.Replace($"@{{{word}}}", value);
                            to_change = resultChain.Contains("@{");
                        }
                        else
                            excludes.Add(word);
                    }
                }

            }

            return resultChain;

        }

        private static readonly Regex _envVarRegex = new Regex(@"@\{(\w+)\}", RegexOptions.Compiled);

    }
}