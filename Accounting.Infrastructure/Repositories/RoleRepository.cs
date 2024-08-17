using Accounting.Domain;
using Accounting.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Accounting.Infrastructure.Repositories;


public class RoleRepository(AccountingDbContext context) : IRoleRepository
{
    public async Task<Role> GetByIdAsync(int roleId)
    {
        return await context.Roles.FindAsync(roleId);
    }

    public async Task<IEnumerable<Role>> GetAllAsync()
    {
        return await context.Roles.ToListAsync();
    }

    public async Task AddAsync(Role role)
    {
        await context.Roles.AddAsync(role);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Role role)
    {
        context.Roles.Update(role);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int roleId)
    {
        var role = await context.Roles.FindAsync(roleId);
        if (role != null)
        {
            context.Roles.Remove(role);
            await context.SaveChangesAsync();
        }
    }
}

