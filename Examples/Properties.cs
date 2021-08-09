//C# implements setter and getter function natively
public class Student
{
    private string name;
    public string Name
    {
        get { return name; } //name getter method
        set { name = vale; } //name setter method
    }
}

//automatic properties

public class Student
{
    public string Name { get; set; }
}

class Program 
{
    static void Main()
    {
        Student std = new Student();
        std.Name = "John";
    }
}