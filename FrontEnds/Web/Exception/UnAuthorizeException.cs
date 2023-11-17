using System;
using System.Runtime.Serialization;

namespace Web.Exception
{
    public class UnAuthorizeException : SystemException
    {
        public UnAuthorizeException()
        {
        }

        public UnAuthorizeException(string message) : base(message)
        {
        }

        public UnAuthorizeException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}
