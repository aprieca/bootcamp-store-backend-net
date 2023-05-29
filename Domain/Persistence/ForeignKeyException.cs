﻿using System.Runtime.Serialization;

namespace bootcamp_store_backend.Domain.Persistence
{
    [Serializable]
        internal class ForeignKeyException : Exception
        {
            public ForeignKeyException()
            {
            }

            public ForeignKeyException(string? message) : base(message)
            {
            }

            public ForeignKeyException(string? message, Exception? innerException) : base(message, innerException)
            {
            }

            protected ForeignKeyException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }

