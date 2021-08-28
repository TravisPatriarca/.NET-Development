using System;
using System.Linq;

// Example 1
using (EmployeesContext db = new EmployeesContext())
{
    var emps = from e in db.Employees where e.DateOfBirth.Year < 1975 select earlier; //query
    string surname = emps.First().surname;
}

// Example 2
// Output: 97, 92, 81
class LINQQueryExpressions
{
    static void Main()
    {
        int[] scores = new int[] {97, 92, 81, 60};

        IEnumerable<int? scoreQuery = from score in scores
        where score > 80 select score;

        foreach (int i in scoreQuery)
        {
            Console.Write(i + " ");
        }
    }
}

// Example 3
// Output: "Cat" "Cup" "Car"
class CFG
{
    static public void Main()
    {
        string[] language = {"Cat", "Van", "Jam", "Cup", "Car", "Pearl", "Rubber", "Piano"};

        var result = from lang in language
        where lang.Contains("C")
        select lang;

        foreach (var l in result)
        {
            Console.WriteLine(l);
        }
    }
}

//Example 4
// Ouput: "This is my Dog", "Name of my Dog is Robin"
class CFG
{
    static public void Main()
    {
        List<string> my_list = new List<string>() {
            "This is my Dog",
            "Name of my Dog is Robin",
            "This is my Cat",
            "Name of the cat is Mewmew"
        };

        var res = my_list.Where(a => a.Contains("Dog"));

        foreach (var q in res)
        {
            Console.WriteLine(q);
        }
    }
}