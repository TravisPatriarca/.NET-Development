var nameSorted = from e in employees 
orderby e.LastName, e.FirstName
select e;

// The query result's 'Any' method returns true if there is at least one element, and false if there are no elements
if (nameSorted.Any())
{
    // The query 'First' methods returns the first element in the result
    Console.WriteLine(nameSorted.First().ToString() + "\n");
}
else
{
    Console.WriteLine("not found\n");
}


// The 'Distinct' method removes duplicate elements
Display(lastNames.Distinct(), "Unique employee last names");

//The select clause can create a new object of anonymous type
var name = from e in employees
select new {first = e.FirstName, last = e.LastName};
