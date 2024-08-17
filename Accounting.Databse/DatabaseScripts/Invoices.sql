CREATE TABLE Invoices (
                          InvoiceId INT PRIMARY KEY IDENTITY(1,1),
                          InvoiceNumber NVARCHAR(50) NOT NULL UNIQUE,
                          CustomerId INT FOREIGN KEY REFERENCES Customers(CustomerId),
                          VendorId INT FOREIGN KEY REFERENCES Vendors(VendorId),
                          InvoiceDate DATETIME DEFAULT GETDATE(),
                          DueDate DATETIME,
                          TotalAmount DECIMAL(18, 2) NOT NULL,
                          CreatedAt DATETIME DEFAULT GETDATE(),
                          UpdatedAt DATETIME
);