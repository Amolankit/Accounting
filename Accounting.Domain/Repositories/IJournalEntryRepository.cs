using Accounting.Domain.Domain;

namespace Accounting.Domain.Repositories;

public interface IJournalEntryRepository
{
    Task<JournalEntry> GetByIdAsync(int journalEntryId);
    Task<IEnumerable<JournalEntry>> GetAllAsync();
    Task AddAsync(JournalEntry journalEntry);
    Task UpdateAsync(JournalEntry journalEntry);
    Task DeleteAsync(int journalEntryId);
}