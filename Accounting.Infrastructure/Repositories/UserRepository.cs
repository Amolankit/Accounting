using Accounting.Domain;
using Accounting.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Accounting.Infrastructure.Repositories
{
    public class UserRepository(AccountingDbContext context) : IUserRepository
    {
        public async Task<User> GetByIdAsync(int userId)
        {
            return await context.Users.FindAsync(userId);
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await context.Users.ToListAsync();
        }

        public async Task AddAsync(User user)
        {
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(User user)
        {
            context.Users.Update(user);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int userId)
        {
            var user = await context.Users.FindAsync(userId);
            if (user != null)
            {
                context.Users.Remove(user);
                await context.SaveChangesAsync();
            }
        }
    }
}
