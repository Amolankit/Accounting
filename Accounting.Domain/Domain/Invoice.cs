namespace Accounting.Domain.Domain;

public class Invoice
{
    public int InvoiceId { get; set; }
    public string InvoiceNumber { get; set; }
    public int CustomerId { get; set; }
    public int VendorId { get; set; }
    public DateTime InvoiceDate { get; set; }
    public DateTime? DueDate { get; set; }
    public decimal TotalAmount { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
        
    // Navigation Properties
    public Customer Customer { get; set; }
    public Vendor Vendor { get; set; }
    public ICollection<InvoiceItem> InvoiceItems { get; set; }
}