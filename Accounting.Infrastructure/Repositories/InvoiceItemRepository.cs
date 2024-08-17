using Accounting.Domain.Domain;
using Accounting.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Accounting.Infrastructure.Repositories;

public class InvoiceItemRepository : IInvoiceItemRepository
{
    private readonly AccountingDbContext _context;

    public InvoiceItemRepository(AccountingDbContext context)
    {
        _context = context;
    }

    public async Task<InvoiceItem> GetByIdAsync(int invoiceItemId)
    {
        return await _context.InvoiceItems.FindAsync(invoiceItemId);
    }

    public async Task<IEnumerable<InvoiceItem>> GetAllAsync()
    {
        return await _context.InvoiceItems.ToListAsync();
    }

    public async Task AddAsync(InvoiceItem invoiceItem)
    {
        await _context.InvoiceItems.AddAsync(invoiceItem);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(InvoiceItem invoiceItem)
    {
        _context.InvoiceItems.Update(invoiceItem);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int invoiceItemId)
    {
        var invoiceItem = await _context.InvoiceItems.FindAsync(invoiceItemId);
        if (invoiceItem != null)
        {
            _context.InvoiceItems.Remove(invoiceItem);
            await _context.SaveChangesAsync();
        }
    }
}