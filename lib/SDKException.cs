﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{

    public class SdkException : Exception
    {
        public SdkException()
        {
        }

        public SdkException(string message)
            : base(message)
        {
        }

        public SdkException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
