public class Foreach {
    public static void Main(string[] args) {
        string[] names = {"Peter", "Emily", "David", "Nik"};

        int i=0;
        foreach (string n in names) {
            System.Console.Out.WriteLine("Name{0}: {1}", ++i, n); //{0} represents first varible given, {1} second ect
        }
    }
}