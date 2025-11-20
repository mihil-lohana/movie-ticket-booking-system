CREATE PROCEDURE BookTicket
    @UserID INT,
    @MovieID INT,
    @Seats INT
AS
BEGIN
    INSERT INTO Bookings (UserID, MovieID, Seats)
    VALUES (@UserID, @MovieID, @Seats);
END;
