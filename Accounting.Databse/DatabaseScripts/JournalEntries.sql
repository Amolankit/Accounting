CREATE TABLE JournalEntries (
                                JournalEntryId INT PRIMARY KEY IDENTITY(1,1),
                                JournalId INT FOREIGN KEY REFERENCES Journals(JournalId),
                                AccountId INT FOREIGN KEY REFERENCES Accounts(AccountId),
                                Debit DECIMAL(18, 2) DEFAULT 0,
                                Credit DECIMAL(18, 2) DEFAULT 0,
                                CreatedAt DATETIME DEFAULT GETDATE(),
                                UpdatedAt DATETIME
);