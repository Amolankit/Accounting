CREATE TABLE Users (
                       UserId INT PRIMARY KEY IDENTITY(1,1),
                       Username NVARCHAR(50) NOT NULL,
                       PasswordHash NVARCHAR(256) NOT NULL,
                       Email NVARCHAR(100),
                       CreatedAt DATETIME DEFAULT GETDATE(),
                       UpdatedAt DATETIME
);