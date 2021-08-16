using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Console_Connect;
{
    public class EmployeesContext : DbContext
    {
        public EmployeesContext() : base("MySqlConnect") {}
        public DbSet<Employee> Employees { get; set; }
    }

    [Table ("employee")] //The table in MySQL is name 'employee'
    public class Employee
    {
        //define properties of class with names matched to table fields in My SQL
        [Key] public int id { get; set; } //[key] identifies 'id' as the primary key as set in MySQL
        public string Surname { get; set; }
        public string GivenNames { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}

public static void Main(string[] args) 
{
    /*
     * using explained: https://www.c-sharpcorner.com/article/the-using-statement-in-C-Sharp/
     * using defines a boundary for an object. (e.g EmployeesContext())
     * when the using block is finished the object is destroyed. Optimises garbage collection 
     */

    using (EmployeesContext db = new EmployeesContext())
    {
        Console.WriteLine(String.Format("Connection string: {0}", db.Database.Connect.ConnectionString));

        int j = db.Employees.Count();
        Console.WriteLine(String.Format("We have {0} records.", j));

        var x2 = db.Database.SqlQuery<Employee>("select * from employee");

        foreach (Employee emp in x2)
        {
            Console.WriteLine(String.Format("Employee: {0}, DoB: {1:d}", emp.Surname, emp.DateOfBirth));
        }

        foreach (var x in db.Employees.Where(a => a.Surname == "Good"))
        {
            Console.WriteLine(String.Format("Employee {0}; date of birth: {1:d}", x.GivenNames + " " + x.Surname, x.DateOfBirth));
        }
    }
}