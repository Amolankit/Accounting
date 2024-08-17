using Accounting.Domain.Domain;
using Accounting.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Accounting.Infrastructure.Repositories;


public class VendorRepository(AccountingDbContext context) : IVendorRepository
{
    public async Task<Vendor> GetByIdAsync(int vendorId)
    {
        return await context.Vendors.FindAsync(vendorId);
    }

    public async Task<IEnumerable<Vendor>> GetAllAsync()
    {
        return await context.Vendors.ToListAsync();
    }

    public async Task AddAsync(Vendor vendor)
    {
        await context.Vendors.AddAsync(vendor);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Vendor vendor)
    {
        context.Vendors.Update(vendor);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int vendorId)
    {
        var vendor = await context.Vendors.FindAsync(vendorId);
        if (vendor != null)
        {
            context.Vendors.Remove(vendor);
            await context.SaveChangesAsync();
        }
    }
}

