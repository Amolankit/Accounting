namespace Accounting.Domain.Domain;

public class AccountCategory
{
    public int AccountCategoryId { get; set; }
    public string CategoryName { get; set; }
        
    // Navigation Properties
    public ICollection<Account> Accounts { get; set; }
}