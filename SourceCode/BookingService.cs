using System;
using System.Data.SqlClient;

public class BookingService
{
    public void ShowMovies()
    {
        using(var con = DatabaseConnection.GetConnection())
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Movies", con);
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\nAvailable Movies:\n");

            while(reader.Read())
            {
                Console.WriteLine($"{reader["MovieID"]}. {reader["Title"]} - Rs.{reader["Price"]}");
            }
        }
    }

    public void BookTicket(int userID, int movieID, int seats)
    {
        using(var con = DatabaseConnection.GetConnection())
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("BookTicket", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UserID", userID);
            cmd.Parameters.AddWithValue("@MovieID", movieID);
            cmd.Parameters.AddWithValue("@Seats", seats);

            cmd.ExecuteNonQuery();
        }
    }
}
