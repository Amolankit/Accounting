using Accounting.Domain.Domain;

namespace Accounting.Domain.Repositories;

public interface IInvoiceItemRepository
{
    Task<InvoiceItem> GetByIdAsync(int invoiceItemId);
    Task<IEnumerable<InvoiceItem>> GetAllAsync();
    Task AddAsync(InvoiceItem invoiceItem);
    Task UpdateAsync(InvoiceItem invoiceItem);
    Task DeleteAsync(int invoiceItemId);
}