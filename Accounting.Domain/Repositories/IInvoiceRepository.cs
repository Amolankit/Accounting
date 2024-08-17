using Accounting.Domain.Domain;

namespace Accounting.Domain.Repositories;

public interface IInvoiceRepository
{
    Task<Invoice> GetByIdAsync(int invoiceId);
    Task<IEnumerable<Invoice>> GetAllAsync();
    Task AddAsync(Invoice invoice);
    Task UpdateAsync(Invoice invoice);
    Task DeleteAsync(int invoiceId);
}