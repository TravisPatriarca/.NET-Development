using System;

namespace StudentAdmin 
{
    public class Student
    {
        //field variables
        private string myName;
        private uint myNumber;

        // instance constructor
        public Student(string name, uint number)
        {
            myName = name;
            myNumber = number;
        }

        public void PrintDetails() 
        {
            Console.WriteLine("Student name: {0}", myName);
            Console.WriteLine("Student number: {0}", myNumber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Joe Blow", 12345678);
            s.PrintDetails();
            Console.Read(); //pause before window closes
        }
    }
}