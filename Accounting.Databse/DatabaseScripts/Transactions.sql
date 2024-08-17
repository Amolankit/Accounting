CREATE TABLE Transactions (
                              TransactionId INT PRIMARY KEY IDENTITY(1,1),
                              TransactionDate DATETIME DEFAULT GETDATE(),
                              Description NVARCHAR(256),
                              TransactionTypeId INT FOREIGN KEY REFERENCES TransactionTypes(TransactionTypeId),
                              Amount DECIMAL(18, 2) NOT NULL,
                              AccountId INT FOREIGN KEY REFERENCES Accounts(AccountId),
                              CreatedAt DATETIME DEFAULT GETDATE(),
                              UpdatedAt DATETIME
);