namespace Accounting.Domain.Repositories;

public interface IRoleRepository
{
    Task<Role> GetByIdAsync(int roleId);
    Task<IEnumerable<Role>> GetAllAsync();
    Task AddAsync(Role role);
    Task UpdateAsync(Role role);
    Task DeleteAsync(int roleId);
}