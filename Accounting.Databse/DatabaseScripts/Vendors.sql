CREATE TABLE Vendors (
                         VendorId INT PRIMARY KEY IDENTITY(1,1),
                         VendorName NVARCHAR(100) NOT NULL,
                         ContactInfo NVARCHAR(256),
                         CreatedAt DATETIME DEFAULT GETDATE(),
                         UpdatedAt DATETIME
);