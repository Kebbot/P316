using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P316.ClassPath
{
    [System.Serializable]
    internal class MyExceptionBase : Exception
    {
        public MyExceptionBase() { }
        public MyExceptionBase(string message) : base(message) { }
        public MyExceptionBase(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionBase(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) 
            : base(info, context) { }
    }
}
