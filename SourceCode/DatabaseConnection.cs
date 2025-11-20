using System.Data.SqlClient;

public class DatabaseConnection
{
    public static SqlConnection GetConnection()
    {
        return new SqlConnection("Data Source=.;Initial Catalog=MovieDB;Integrated Security=True");
    }
}
