using Application.IServices;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext _context;

        public UserRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<User> GetByIdAsync(Guid userId, CancellationToken cancellationToken)
        {
            return await _context.Users.AsNoTracking().SingleOrDefaultAsync(u => u.UserId == userId && !u.IsDeleted, cancellationToken);
        }

        public async Task<User> GetByUsernameAsync(string username, CancellationToken cancellationToken)
        {
            return await _context.Users.Where(u=> !u.IsDeleted).SingleOrDefaultAsync(u => u.Username == username, cancellationToken);
        }

        public async Task CreateAsync(User user, CancellationToken cancellationToken)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateAsync(User user, CancellationToken cancellationToken)
        {
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(Guid userId, CancellationToken cancellationToken)
        {
            var user = await _context.Users.FindAsync(userId , cancellationToken);
            if (user != null)
            {
                user.IsDeleted = true;
                user.DeleteDateTime = DateTime.Now;
                await _context.SaveChangesAsync(cancellationToken);
            }
        }

        public async Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken)
        {
            var usersUR = await _context.Users.Where(u => !u.IsDeleted).ToListAsync(cancellationToken);
            return usersUR;
        }

        public async Task<bool> IsUsernameExistsAsync(string Username, CancellationToken cancellationToken)
        {
            var b = await _context.Users.AnyAsync(u => u.Username == Username, cancellationToken);
            return b;
        }
    }
}
