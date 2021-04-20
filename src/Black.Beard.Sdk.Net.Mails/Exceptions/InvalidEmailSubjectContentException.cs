using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bb.Sdk.Exceptions
{

    /// <summary>
    /// Invalid email subject content exception
    /// </summary>
    [Serializable]
    public class InvalidEmailSubjectContentException : Exception, ISerializable
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidEmailSubjectContentException"/> class.
        /// </summary>
        public InvalidEmailSubjectContentException() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidEmailSubjectContentException"/> class.
        /// </summary>
        /// <param name="message">Message décrivant l'erreur.</param>
        public InvalidEmailSubjectContentException(string message) : base(message) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidEmailSubjectContentException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public InvalidEmailSubjectContentException(string message, Exception inner) : base(message, inner) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidEmailSubjectContentException"/> class.
        /// </summary>
        /// <param name="info"><see cref="T:System.Runtime.Serialization.SerializationInfo" /> qui contient les données d'objet sérialisées concernant l'exception levée.</param>
        /// <param name="context"><see cref="T:System.Runtime.Serialization.StreamingContext" /> qui contient des informations contextuelles sur la source ou la destination.</param>
        protected InvalidEmailSubjectContentException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }

        /// <summary>
        /// En cas de substitution dans une classe dérivée, définit <see cref="T:System.Runtime.Serialization.SerializationInfo" /> avec des informations sur l'exception.
        /// </summary>
        /// <param name="info"><see cref="T:System.Runtime.Serialization.SerializationInfo" /> qui contient les données d'objet sérialisées concernant l'exception levée.</param>
        /// <param name="context"><see cref="T:System.Runtime.Serialization.StreamingContext" /> qui contient des informations contextuelles sur la source ou la destination.</param>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" />
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="SerializationFormatter" />
        /// </PermissionSet>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }

    }

}
