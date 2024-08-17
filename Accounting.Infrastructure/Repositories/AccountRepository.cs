using Accounting.Domain.Domain;
using Accounting.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Accounting.Infrastructure.Repositories;

public class AccountRepository(AccountingDbContext context) : IAccountRepository
{
    public async Task<Account> GetByIdAsync(int accountId)
    {
        return await context.Accounts.FindAsync(accountId);
    }

    public async Task<IEnumerable<Account>> GetAllAsync()
    {
        return await context.Accounts.ToListAsync();
    }

    public async Task AddAsync(Account account)
    {
        await context.Accounts.AddAsync(account);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Account account)
    {
        context.Accounts.Update(account);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int accountId)
    {
        var account = await context.Accounts.FindAsync(accountId);
        if (account != null)
        {
            context.Accounts.Remove(account);
            await context.SaveChangesAsync();
        }
    }
}
