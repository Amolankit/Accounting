using Accounting.Domain.Domain;

namespace Accounting.Domain.Repositories;

public interface IVendorRepository
{
    Task<Vendor> GetByIdAsync(int vendorId);
    Task<IEnumerable<Vendor>> GetAllAsync();
    Task AddAsync(Vendor vendor);
    Task UpdateAsync(Vendor vendor);
    Task DeleteAsync(int vendorId);
}