using System;
using Ch07_PacktLibrary;
using static System.Console;

namespace Ch07_PeopleApp
{
    class Program
    {
        /*static void Main(string[] args)
        {
            var harry = new Person { Name = "Harry" };
            var mary = new Person { Name = "Mary" };
            var baby1 = harry.Procreate(mary);
            var baby2 = harry * mary;

            WriteLine($"{mary.Name} has {mary.Children.Count} children.");
            WriteLine($"{harry.Name} has {harry.Children.Count} children.");
            WriteLine($"{harry.Name}'s first child is named \"{harry.Children[0].Name}\".");
            WriteLine($"5! is {harry.Factorial(5)}");

            harry.Shout += Harry_Shout;
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();

            Person[] people =
            {
                new Person {Name = "Simon"},
                new Person {Name = "Jenny"},
                new Person {Name = "Adam"},
                new Person {Name = "Richard"}
            };

            WriteLine("Initial list of people:");
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            WriteLine("Use Person's sort implementaion:");
            Array.Sort(people);
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            WriteLine("Use PersonComparer's sort implementation:");
            Array.Sort(people, new PersonComparer());
            foreach(var person in people)
            {
                WriteLine($"{person.Name}");
            }
        }

        private static void Harry_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
        }*/

        /*static void Main(string[] args)
        {
            var dv1 = new DisplacementVector(3, 5);
            var dv2 = new DisplacementVector(-2, 7);
            var dv3 = dv1 + dv2;
            WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");
        }*/  
        
        static void Main(string[] args)
        {
            Employee e1 = new Employee
            {
                Name = "John Jones",
                DateOfBirth = new DateTime(1990, 7, 28)
            };
            e1.EmployeeCode = "JJ001";
            e1.HireDate = new DateTime(2014, 11, 23);
            e1.WriteToConsole();
            WriteLine(e1.ToString());

            Employee aliceInEmployee = new Employee
            {
                Name = "Alice",
                EmployeeCode = "AA123"
            };
            //implicit casting
            Person aliceInPerson = aliceInEmployee;

            aliceInEmployee.WriteToConsole();
            aliceInPerson.WriteToConsole();

            WriteLine(aliceInEmployee.ToString());
            WriteLine(aliceInPerson.ToString());

            //explicit casting
            Employee e2 = (Employee)aliceInPerson;
            if (aliceInPerson is Employee)
            {

            }
            //or
            Employee e3 = aliceInPerson as Employee;
            if (e3 != null)
            {

            }

            try
            {
                e1.TimeTravel(new DateTime(1999, 12, 31));
                e1.TimeTravel(new DateTime(1950, 12, 25));
            }
            catch (PersonException ex)
            {
                WriteLine(ex.Message);
            }

            string email1 = "pamela@test.com";
            string email2 = "ian&test.com";

            WriteLine($"{email1} is a valid emailAddress: {MyExtensions.IsValidEmail(email1)}");
            WriteLine($"{email2} is a valid emailAddress: {MyExtensions.IsValidEmail(email2)}");            
            WriteLine($"{email1} is a valid emailAddress: {email1.IsValidEmail()}");
            WriteLine($"{email2} is a valid emailAddress: {email2.IsValidEmail()}");

        }
    }
}
