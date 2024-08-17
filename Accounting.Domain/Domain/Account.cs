namespace Accounting.Domain.Domain;

public class Account
{
    public int AccountId { get; set; }
    public string AccountName { get; set; }
    public string AccountNumber { get; set; }
    public int AccountCategoryId { get; set; }
    public decimal Balance { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
        
    // Navigation Properties
    public AccountCategory AccountCategory { get; set; }
    public ICollection<Transaction> Transactions { get; set; }
    public ICollection<JournalEntry> JournalEntries { get; set; }
}