namespace Accounting.Domain.Domain;

public class JournalEntry
{
    public int JournalEntryId { get; set; }
    public int JournalId { get; set; }
    public int AccountId { get; set; }
    public decimal Debit { get; set; }
    public decimal Credit { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
        
    // Navigation Properties
    public Journal Journal { get; set; }
    public Account Account { get; set; }
}