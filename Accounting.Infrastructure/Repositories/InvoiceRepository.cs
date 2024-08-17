using Accounting.Domain.Domain;
using Accounting.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Accounting.Infrastructure.Repositories;


public class InvoiceRepository(AccountingDbContext context) : IInvoiceRepository
{
    public async Task<Invoice> GetByIdAsync(int invoiceId)
    {
        return await context.Invoices.FindAsync(invoiceId);
    }

    public async Task<IEnumerable<Invoice>> GetAllAsync()
    {
        return await context.Invoices.ToListAsync();
    }

    public async Task AddAsync(Invoice invoice)
    {
        await context.Invoices.AddAsync(invoice);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Invoice invoice)
    {
        context.Invoices.Update(invoice);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int invoiceId)
    {
        var invoice = await context.Invoices.FindAsync(invoiceId);
        if (invoice != null)
        {
            context.Invoices.Remove(invoice);
            await context.SaveChangesAsync();
        }
    }
}

