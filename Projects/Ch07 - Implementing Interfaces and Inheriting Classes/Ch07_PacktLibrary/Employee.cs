using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch07_PacktLibrary
{
    public class Employee : Person
    {
        public string EmployeeCode { get; set; }
        public DateTime HireDate { get; set; }

        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on {DateOfBirth:dddd, d MMMM yyyy} and hire date was {HireDate:dd/MM/yy}");
        }

        public override string ToString()
        {
            return $"{Name}'s code is {EmployeeCode}";
        }
    }
}
