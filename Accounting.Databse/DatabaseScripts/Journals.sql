CREATE TABLE Journals (
                          JournalId INT PRIMARY KEY IDENTITY(1,1),
                          JournalDate DATETIME DEFAULT GETDATE(),
                          Description NVARCHAR(256),
                          CreatedAt DATETIME DEFAULT GETDATE(),
                          UpdatedAt DATETIME
);