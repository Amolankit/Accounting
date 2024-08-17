namespace Accounting.Domain.Domain;

public class Transaction
{
    public int TransactionId { get; set; }
    public DateTime TransactionDate { get; set; }
    public string Description { get; set; }
    public int TransactionTypeId { get; set; }
    public decimal Amount { get; set; }
    public int AccountId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
        
    // Navigation Properties
    public TransactionType TransactionType { get; set; }
    public Account Account { get; set; }
}