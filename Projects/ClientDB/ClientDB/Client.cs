using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ClientDB
{
    class Client
    {
        private string lastName;
        private string firstName;
        private string secondName;
        private int myAge;
        private void setNames(string name)
        {
            /*
             * String.Split()
             * Arg0 - Use string array as input for delimiinators
             * Arg1 - Remove empty entries from array
             */
            string[] names = name.Split(new string[] {" ", "."}, StringSplitOptions.RemoveEmptyEntries);
            int n = names.Length; //number of array elements

            if (n==1) {
                firstName = names[0];
            }
            else if (n==2) {
                firstName = names[0]; 
                lastName = names[1];
            }
            else 
            {
                firstName = names[0];
                secondName = names[1];
                lastName = names[n - 1];
            }
        }

        public string FullName
        {
            get { return firstName = " " + secondName + " " + lastName; }
            set { setNames(value); }
        }

        public int Age;
        
        public Client(string name, int age)
        {
            setNames(name);
            Age = age;
        }        
        public Client(string name)
        {
            setNames(name);
        }

        public bool IsSame(string name)
        {
            string[] names = name.Split(new string[] { " ", "." }, StringSplitOptions.RemoveEmptyEntries);
            int n = names.Length;
            //returns true if the specified object is equal to the current object.
            return lastName.Equals(names[n - 1]) && firstName.Equals(names[0]);
        }
    }
}
