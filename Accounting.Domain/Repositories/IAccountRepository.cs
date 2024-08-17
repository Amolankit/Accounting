using Accounting.Domain.Domain;

namespace Accounting.Domain.Repositories;

public interface IAccountRepository
{
    Task<Account> GetByIdAsync(int accountId);
    Task<IEnumerable<Account>> GetAllAsync();
    Task AddAsync(Account account);
    Task UpdateAsync(Account account);
    Task DeleteAsync(int accountId);
}