using System;
using System.Collections.Generic;
using System.Text;

namespace Smirnov
{
    public class SmirnovException : Exception
    {
        public SmirnovException(string message) : base(message) { }
    }
}
