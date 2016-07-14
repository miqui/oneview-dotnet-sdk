using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    public class OneViewException : SdkException
    {
        public OneViewException()
        {
        }

        public OneViewException(string message) : base(message)
        {
        }

        public OneViewException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
