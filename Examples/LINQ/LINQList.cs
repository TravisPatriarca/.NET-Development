// 'let' clause can be used to create a new range variable to store a temporary result for later
var startsWithR = from item in items 
let uppercaseString = item.ToUpper()
where uppercaseString.StartsWith("R")
orderby uppercaseString
select uppercaseString;

using System;
using System.Linq;
using System.Collections.Generic;

// Example 1
class EXAMPLE 
{
    static public void Main()
    {
        int[] sequence = { 20, 30, 50, 78, 90, 79, 89, 99, 97, 29}

        Console.WriteLine("The sequence is: ");
        
        foreach(int s in sequence)
        {
            Console.WriteLine(s);
        }

        int results = sequence.Sum();
        Console.WriteLine("The sum of the given sequence is: {0}", result);
    }
}

// Example 2
public class Employee 
{
    public int emp_id { get; set; }
    public string emp_name { get; set; }
    public string emp_gender { get; set; }
    public string emp_hire_date { get; set; }
    public int emp_salary { get; set; }
}

class EMP 
{
    static public void Main() 
    {
        List<Employee> emp = new List<Employee>() {
            new Employee() { emp_id = 209, emp_name = "Anji", emp_gender = "Female", emp_hire_date = "12/3/2017", emp_salary = 20000 },
            new Employee() { emp_id = 210, emp_name = "Soni", emp_gender = "Female", emp_hire_date = "22/4/2018", emp_salary = 30000 },
            new Employee() { emp_id = 211, emp_name = "Robert", emp_gender = "Male", emp_hire_date = "3/5/2016", emp_salary = 40000 },
            new Employee() { emp_id = 212, emp_name = "Superwoman", emp_gender = "Female", emp_hire_date = "4/8/2017", emp_salary = 40000 },
            new Employee() { emp_id = 213, emp_name = "Rob", emp_gender = "Male", emp_hire_date = "12/1/2016", emp_salary = 40000 },
            new Employee() { emp_id = 214, emp_name = "Mary", emp_gender = "Female", emp_hire_date = "17/6/2015", emp_salary = 50000 },
        };

        var res = from e in emp select e.emp_id.Count();

        Console.WriteLine("Total number of Employees: {0}", res);
    }
}