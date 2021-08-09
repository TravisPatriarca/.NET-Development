string grade = Console.ReadLine();
switch (grade.ToUpper()) 
{
    case "P":
        System.Console.Out.WriteLine("Pass");
        break;
    case "N":
        System.Console.Out.WriteLine("Fail");
        break;
    default:
        System.Console.Out.WriteLine("Supp!");
}