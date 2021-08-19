using System;
using System.Collections.Generic;
using static System.Console;

namespace Ch07_PacktLibrary
{
    public partial class Person
    {
        //event
        public event EventHandler Shout;

        //fields
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();
        public int AngerLevel;
        
        //methods
        public void WriteToConsole()
        {
            //$ = interpolated string
            //http://redspa.uk/blog/post/1029/interpolated-strings-c-sharp#:~:text=In%20Interpolated%20Strings%2C%20the%20dollar,to%20include%20in%20the%20text.
            WriteLine($"{Name} was born on {DateOfBirth:dddd, d MMMM yyyy}");
        }

        //method to "multiply"
        public Person Procreate(Person partner)
        {
            var baby = new Person
            {
                Name = $"Baby of {this.Name} and {partner.Name}"
            };

            this.Children.Add(baby);
            partner.Children.Add(baby);

            return baby;
        }

        //alternative method to multiply (overriding * operator)
        //BEST PRACTICE: it is best practice to have both a method and operator that perform the same function
        public static Person operator * (Person p1, Person p2)
        {
            return p1.Procreate(p2);
        }

        //method with a local function
        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException($"{nameof(number)} cannot be less than zero.");
            }

            int localFactorial(int localNumber)
            {
                if (localNumber < 1) return 1;
                return localNumber * localFactorial(localNumber - 1);
            }

            return localFactorial(number);
        }

        public void Poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                // if something is listening
                if (Shout != null)
                {
                    Shout(this, EventArgs.Empty);
                }
            }
        }

        public override string ToString()
        {
            return $"{Name} is a {base.ToString()}";
        }

        public void TimeTravel(DateTime when)
        {
            if (when <= DateOfBirth)
            {
                throw new PersonException("If you travel back in time to a date earlier than your own birth then the universe will explode!");
            }
            else
            {
                WriteLine($"Welcome to {when:yyyy}!");
            }
        }
    }

    public partial class Person : IComparable<Person>
    {
        int IComparable<Person>.CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }
    }

    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int temp = x.Name.Length.CompareTo(y.Name.Length);
            if (temp == 0)
            {
                return x.Name.CompareTo(y.Name);
            }
            else
            {
                return temp;
            }
        }
    }
}
