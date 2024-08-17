using Accounting.Domain.Domain;
using Accounting.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Accounting.Infrastructure.Repositories;

public class JournalEntryRepository(AccountingDbContext context) : IJournalEntryRepository
{
    public async Task<JournalEntry> GetByIdAsync(int journalEntryId)
    {
        return await context.JournalEntries.FindAsync(journalEntryId);
    }

    public async Task<IEnumerable<JournalEntry>> GetAllAsync()
    {
        return await context.JournalEntries.ToListAsync();
    }

    public async Task AddAsync(JournalEntry journalEntry)
    {
        await context.JournalEntries.AddAsync(journalEntry);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(JournalEntry journalEntry)
    {
        context.JournalEntries.Update(journalEntry);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int journalEntryId)
    {
        var journalEntry = await context.JournalEntries.FindAsync(journalEntryId);
        if (journalEntry != null)
        {
            context.JournalEntries.Remove(journalEntry);
            await context.SaveChangesAsync();
        }
    }
}
