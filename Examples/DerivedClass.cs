class Person 
{
    public string Name;
    public string Address;
    
    public void Show()
    {
        Console.WriteLine("Name: {0}, address: {1}", Name, Address);
    }
}

class Student : Person
{
    public int StudentNo;
}

class Program
{
    static void main(string[] Args) 
    {
        Student s = new Student();
        s.Name = "Joe";
        s.Address = "2 South St";
        s.StudentNo = 12345;
        s.Show();
    }
}