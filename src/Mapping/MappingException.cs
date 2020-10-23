﻿using NoRealm.Phi.Shared;
using System;
using System.Runtime.Serialization;

namespace NoRealm.Phi.DataEngine.Mapping
{
    /// <summary>
    /// Exception thrown when mapping fails
    /// </summary>
    [Serializable]
    public class MappingException : PhiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MappingException"/> class.
        /// </summary>
        public MappingException() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MappingException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public MappingException(string message) : base(message) { }

        /// <summary>
        ///    Initializes a new instance of the <see cref="MappingException"/> class with a specified error
        ///    message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">
        ///     The exception that is the cause of the current exception, or a null reference
        ///     (Nothing in Visual Basic) if no inner exception is specified.
        /// </param>
        public MappingException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MappingException"/> class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
        protected MappingException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
