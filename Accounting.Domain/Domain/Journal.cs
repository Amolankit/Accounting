namespace Accounting.Domain.Domain;

public class Journal
{
    public int JournalId { get; set; }
    public DateTime JournalDate { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
        
    // Navigation Properties
    public ICollection<JournalEntry> JournalEntries { get; set; }
}