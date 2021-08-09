/*
*   A static field is shared by all object of the class.
*   Example: 
*   Assume all students are from the same university. We can represent's a students univerty by using a static field.
*   We can declare a static method that will set the university value to the static field.
*/

public class Student
{
    private string myName;
    private uint myNumber;
    private static string university;

    public Student(string name, uint number)
    {
        myName = name;
        myNumber = number;
    }

    public static void SetUniversity(string uni) 
    {
        university = uni;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Student name: {0}", myName);
        Console.WriteLine("Student number: {0}", myNumber);
        Console.WriteLine("University: {0}", university);
    }
}

class Program 
{
    static void Main(string[] args) 
    {
        Student s = new Student("Joe Blow", 12345678);
        Student.SetUniversity("Murdoch University"); //We access the static method SetUniversity directly using the class name, not object reference
        s.PrintDetails();

        Console.Read(); // to pause before close window
    }
}