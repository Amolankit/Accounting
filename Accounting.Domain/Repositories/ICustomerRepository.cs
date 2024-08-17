using Accounting.Domain.Domain;

namespace Accounting.Domain.Repositories;

public interface ICustomerRepository
{
    Task<Customer> GetByIdAsync(int customerId);
    Task<IEnumerable<Customer>> GetAllAsync();
    Task AddAsync(Customer customer);
    Task UpdateAsync(Customer customer);
    Task DeleteAsync(int customerId);
}