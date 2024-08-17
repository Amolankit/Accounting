namespace Accounting.Domain.Domain;

public class Customer
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
        
    // Navigation Properties
    public ICollection<Invoice> Invoices { get; set; }
}