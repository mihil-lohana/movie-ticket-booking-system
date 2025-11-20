CREATE TABLE Movies (
    MovieID INT PRIMARY KEY IDENTITY(1,1),
    Title VARCHAR(100),
    Genre VARCHAR(50),
    Duration INT,
    Price DECIMAL(10,2)
);

CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    FullName VARCHAR(100),
    Email VARCHAR(100)
);

CREATE TABLE Bookings (
    BookingID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT,
    MovieID INT,
    Seats INT,
    BookingDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY(UserID) REFERENCES Users(UserID),
    FOREIGN KEY(MovieID) REFERENCES Movies(MovieID)
);
