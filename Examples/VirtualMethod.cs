class Person //base class
{
    public string Name;
    public string Address;
    
    public virtual void Show()
    {
        Console.WriteLine("Name: {0}, address: {1}", Name, Address);
    }
}

class Student : Person //derived class
{
    public int StudentNo;
    public override void Show()
    {
        base.Show();
        Console.WriteLine("Student No.: {0}", StudentNo);
    }
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