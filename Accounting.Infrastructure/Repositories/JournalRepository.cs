using Accounting.Domain.Domain;
using Accounting.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Accounting.Infrastructure.Repositories;


public class JournalRepository(AccountingDbContext context) : IJournalRepository
{
    public async Task<Journal> GetByIdAsync(int journalId)
    {
        return await context.Journals.FindAsync(journalId);
    }

    public async Task<IEnumerable<Journal>> GetAllAsync()
    {
        return await context.Journals.ToListAsync();
    }

    public async Task AddAsync(Journal journal)
    {
        await context.Journals.AddAsync(journal);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Journal journal)
    {
        context.Journals.Update(journal);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int journalId)
    {
        var journal = await context.Journals.FindAsync(journalId);
        if (journal != null)
        {
            context.Journals.Remove(journal);
            await context.SaveChangesAsync();
        }
    }
}
