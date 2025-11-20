using System;

class Program
{
    static void Main(string[] args)
    {
        BookingService service = new BookingService();

        Console.WriteLine("🎬 Welcome to Movie Ticket Booking System");

        service.ShowMovies();
        service.BookTicket(1, 1, 2);

        Console.WriteLine("Booking Completed Successfully!");
    }
}
