using Accounting.Domain.Domain;
using Accounting.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Accounting.Infrastructure.Repositories;


public class TransactionRepository(AccountingDbContext context) : ITransactionRepository
{
    public async Task<Transaction> GetByIdAsync(int transactionId)
    {
        return await context.Transactions.FindAsync(transactionId);
    }

    public async Task<IEnumerable<Transaction>> GetAllAsync()
    {
        return await context.Transactions.ToListAsync();
    }

    public async Task AddAsync(Transaction transaction)
    {
        await context.Transactions.AddAsync(transaction);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Transaction transaction)
    {
        context.Transactions.Update(transaction);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int transactionId)
    {
        var transaction = await context.Transactions.FindAsync(transactionId);
        if (transaction != null)
        {
            context.Transactions.Remove(transaction);
            await context.SaveChangesAsync();
        }
    }
}
