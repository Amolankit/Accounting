namespace Accounting.Domain.Domain;

public class Vendor
{
    public int VendorId { get; set; }
    public string VendorName { get; set; }
    public string ContactInfo { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
        
    // Navigation Properties
    public ICollection<Invoice> Invoices { get; set; }
}