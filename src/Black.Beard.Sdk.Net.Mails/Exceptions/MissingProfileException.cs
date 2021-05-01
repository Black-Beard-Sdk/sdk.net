using System;
using System.Runtime.Serialization;

namespace Bb.Sdk.Exceptions
{
    [Serializable]
    public class MissingProfileException : Exception
    {
        public MissingProfileException() { }
        public MissingProfileException(string message) : base($"missing smtp profil '{message}' in the configuration") { }
        public MissingProfileException(string message, Exception inner) : base(message, inner) { }
        protected MissingProfileException(
          SerializationInfo info,
          StreamingContext context) : base(info, context) { }
    }


}
