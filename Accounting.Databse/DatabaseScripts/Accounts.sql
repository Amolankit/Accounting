CREATE TABLE Accounts (
                          AccountId INT PRIMARY KEY IDENTITY(1,1),
                          AccountName NVARCHAR(100) NOT NULL,
                          AccountNumber NVARCHAR(50) NOT NULL UNIQUE,
                          AccountCategoryId INT FOREIGN KEY REFERENCES AccountCategories(AccountCategoryId),
                          Balance DECIMAL(18, 2) DEFAULT 0,
                          CreatedAt DATETIME DEFAULT GETDATE(),
                          UpdatedAt DATETIME
);