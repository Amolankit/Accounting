using Accounting.Domain.Domain;
using Accounting.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Accounting.Infrastructure.Repositories;


public class CustomerRepository(AccountingDbContext context) : ICustomerRepository
{
    public async Task<Customer> GetByIdAsync(int customerId)
    {
        return await context.Customers.FindAsync(customerId);
    }

    public async Task<IEnumerable<Customer>> GetAllAsync()
    {
        return await context.Customers.ToListAsync();
    }

    public async Task AddAsync(Customer customer)
    {
        await context.Customers.AddAsync(customer);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Customer customer)
    {
        context.Customers.Update(customer);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int customerId)
    {
        var customer = await context.Customers.FindAsync(customerId);
        if (customer != null)
        {
            context.Customers.Remove(customer);
            await context.SaveChangesAsync();
        }
    }
}