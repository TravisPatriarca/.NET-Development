class Person
{
    public string Name;
    public string Address;

    public void Show()
    {
        System.WriteLine("Name: {0}, address: {1}", Name, Address);
    }
}

class Student : Person
{
    public int StudentNo;
}