CREATE TABLE InvoiceItems (
                              InvoiceItemId INT PRIMARY KEY IDENTITY(1,1),
                              InvoiceId INT FOREIGN KEY REFERENCES Invoices(InvoiceId),
                              Description NVARCHAR(256),
                              Quantity INT NOT NULL,
                              UnitPrice DECIMAL(18, 2) NOT NULL,
                              Total DECIMAL(18, 2) NOT NULL,
                              CreatedAt DATETIME DEFAULT GETDATE(),
                              UpdatedAt DATETIME
);