using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch07_PacktLibrary
{
    public class PersonException : Exception
    {
        public PersonException() : base() { }
        public PersonException(string message) : base (message) { }
        public PersonException(string message, Exception innerException) : base(message, innerException) { }
    }
}
