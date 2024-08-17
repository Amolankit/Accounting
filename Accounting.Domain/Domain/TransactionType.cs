namespace Accounting.Domain.Domain;

public class TransactionType
{
    public int TransactionTypeId { get; set; }
    public string TypeName { get; set; }
        
    // Navigation Properties
    public ICollection<Transaction> Transactions { get; set; }
}