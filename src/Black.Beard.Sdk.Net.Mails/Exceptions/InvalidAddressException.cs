﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bb.Sdk.Exceptions
{

    /// <summary>
    /// Invalid eamil address exception
    /// </summary>
    [Serializable]
    public class InvalidAddressException : Exception
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidAddressException"/> class.
        /// </summary>
        public InvalidAddressException() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidAddressException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public InvalidAddressException(string message) : base(message) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidAddressException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public InvalidAddressException(string message, Exception inner) : base(message, inner) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidAddressException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected InvalidAddressException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
    
}
