﻿using System;
using System.Runtime.Serialization;

namespace Shibari.Sub.Source.FireShock.Exceptions
{
    public class FireShockGetHostBdAddrFailedException : Exception
    {
        public FireShockGetHostBdAddrFailedException()
        {
        }

        public FireShockGetHostBdAddrFailedException(string message) : base(message)
        {
        }

        public FireShockGetHostBdAddrFailedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FireShockGetHostBdAddrFailedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}