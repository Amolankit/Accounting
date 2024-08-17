CREATE TABLE Customers (
                           CustomerId INT PRIMARY KEY IDENTITY(1,1),
                           CustomerName NVARCHAR(100) NOT NULL,
                           ContactInfo NVARCHAR(256),
                           CreatedAt DATETIME DEFAULT GETDATE(),
                           UpdatedAt DATETIME
);