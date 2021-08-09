class Person
{
    string myName; // note this is private
    string myAddress;
    public Person(string name, string address) { //constructor
        myName=name; myAddress=address;
    }

    public virtual void Show()
    {
        Console.WriteLine("Name: {0}, address: {1}", myName, myAddress);
    }
}

class Student: Person
{
    int myStudentNo;
    //base constructor is called with following parameters
    public Student(string name, string address, int studentNo) 
    : base(name, address) 
    { 
        myStudentNo = studentNo;
    }

    public override void Show()
    {
        base.Show();
        // invoke the method in the base class
        Console.WriteLine("Student No.: {0}", myStudentNo);
    }
}