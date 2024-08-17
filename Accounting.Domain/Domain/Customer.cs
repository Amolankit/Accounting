namespace Accounting.Domain.Domain;

public class Customer
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public string ContactInfo { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
        
    // Navigation Properties
    public ICollection<Invoice> Invoices { get; set; }
}