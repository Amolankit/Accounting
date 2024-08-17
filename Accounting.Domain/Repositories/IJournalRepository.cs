using Accounting.Domain.Domain;

namespace Accounting.Domain.Repositories;

public interface IJournalRepository
{
    Task<Journal> GetByIdAsync(int journalId);
    Task<IEnumerable<Journal>> GetAllAsync();
    Task AddAsync(Journal journal);
    Task UpdateAsync(Journal journal);
    Task DeleteAsync(int journalId);
}