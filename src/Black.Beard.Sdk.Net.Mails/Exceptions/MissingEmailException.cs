using System;
using System.Runtime.Serialization;

namespace Bb.Sdk.Exceptions
{
    [Serializable]
    public class MissingEmailException : Exception
    {
        public MissingEmailException() { }
        public MissingEmailException(string message) : base($"missing email {message}") { }
        public MissingEmailException(string message, Exception inner) : base(message, inner) { }
        protected MissingEmailException(
          SerializationInfo info,
          StreamingContext context) : base(info, context) { }
    }


}
