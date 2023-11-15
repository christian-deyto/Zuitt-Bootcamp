using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{

    // In cases where the pre-built in exceptions of C# are inapplicable or inappropriate or whenever a customized exception is needed in an application we create a user defined exception which can be used in managing exceptions
    internal class MyException : Exception
    {
        // The ": base(message)" overwrites the parent classes' "message" field;
        public MyException(string message): base(message) { 
        }
    }
}
