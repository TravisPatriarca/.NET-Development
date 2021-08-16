using MySql.Data.MySqlClient;

static void Main(string[] args) 
{
    string cs = @"server=100.222.99.999; uid=gil; pwd=ICT365; database=Session3";
    MySqlConnection conn = null;
    try {
        conn = new MySqlConnection(cs);
        conn.Open();

        Console.WriteLine("MySQL version: {0}", conn.ServerVersion);
        MySqlCommand cmd = new MySqlCommand("select * from employee", conn); //query db
        MySqlDataReader reader = cmd.ExcuteReader();
        reader.Read();
        Console.WriteLine(reader.GetString(1)); //print contents of the 2nd field
    }
    catch (MySqlException ex) {
        Console.WriteLine("Error: {0}", ex.ToString());
    }
    finally {
        if (conn != null) conn.Close(); // close db connection
    }
}