using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Ch07_PacktLibrary
{
    //change to static to extend system.string
    public static class MyExtensions
    {
        //change to this to extend system.string
        public static bool IsValidEmail(this string input)
        {
            return Regex.IsMatch(input, @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+"); //email validation regex
        }
    }
}
