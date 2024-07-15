using Bb.Util;

namespace Bb
{
    /// <summary>
    /// Represents a query parameter value with the ability to track whether it was already encoded when created.
    /// </summary>
    internal readonly struct QueryParamValue
    {
        private readonly string _encodedValue;

        public QueryParamValue(object value, bool isEncoded)
        {
            if (isEncoded && value is string s)
            {
                _encodedValue = s;
                Value = Url.Decode(s, true);
            }
            else
            {
                Value = value;
                _encodedValue = null;
            }
        }

        public object Value { get; }

        public string Encode(bool encodeSpaceAsPlus) =>
            (Value == null) 
                ? null 
                : (_encodedValue != null) 
                    ? _encodedValue.ReplaceVariables()
                    : (Value is string s) 
                        ? Url.Encode(s.ReplaceVariables(), encodeSpaceAsPlus) 
                        : Url.Encode(Value.ToInvariantString().ReplaceVariables(), encodeSpaceAsPlus);
    }
}