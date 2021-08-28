public class Customers
{
    public int CustID { get; set; }
    public string Name { get; set; }
    public long MobileNo { get; set; }
    public string Location { get; set; }
    public string Address { get; set; }
    public static List<Customers> GetCustomerDetail()
    {
        List<Customers> lstcustomer = new list<Customers>()
        {
            new Customers{CustID=10001, Name="Rober", MobileNo=9820098200, Location="Balaga", Address="XYZ"},
            new Customers{CustID=10001, Name="Richard", MobileNo=9820098201, Location="Nedlands", Address="ABC"},
            new Customers{CustID=10001, Name="Kate", MobileNo=9820098202, Location="Murdoch", Address="CDE"},
            new Customers{CustID=10001, Name="Catherine", MobileNo=9820098203, Location="Wembley", Address="MNO"}
        };

        return lstcustomer;
    }
}

class Program
{
    static void Main(string[] args)
    {
        XDocument xmlDocument = new XDocument(
            new XDeclaration("1.0", "utf-8", "yes"),
            new XComment("LINQ To XML Demo"),
            new XElement("Customers"),
            from customers in Customers.getCustomerDetail()
            select new XElement("Customer", new XAttribte("ID", customers.CustID),
                new XElement("Name", customers.Name),
                new XElement("Mobile", customers.MobileNo),
                new XElement("Location", customers.MobileNo),
                new XElement("Address", customers.Address)
            );
        );

        xmlDocument.Save(@"C:\Dev\LINQ_Learning\CustomersDetail.xml");

        IEnumerable<string> names = from customers in XDocument.Load(@"C:\Dev\LINQ_Learning\CustomersDetail.xml").Descendants("Customer")
        select customers.Element("Name").Value;

        foreach(string strName in names)
        {
            Console.WriteLine(strName);
        }

        Console.ReadLine();
    }
}