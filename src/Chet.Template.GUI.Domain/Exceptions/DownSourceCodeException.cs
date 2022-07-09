using System;
using System.Runtime.Serialization;

namespace Chet.Template.GUI.Domain.Exceptions
{
    public class DownSourceCodeException : Exception
    {
        public DownSourceCodeException()
        {
        }

        public DownSourceCodeException(string message) : base(message)
        {
        }

        public DownSourceCodeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DownSourceCodeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
