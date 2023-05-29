using Application.IServices;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
    public class UserService : IUserService
    {
        private readonly DatabaseContext _context;

        public UserService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserByIdAsync(Guid userId, CancellationToken cancellationToken)
        {
            return await _context.Users.SingleOrDefaultAsync(u => u.UserId == userId, cancellationToken);
        }

        public async Task<IEnumerable<User>> GetUsersAsync(CancellationToken cancellationToken)
        {
            return await _context.Users.ToListAsync(cancellationToken);
        }

        public async Task<User> CreateUserAsync(User user, CancellationToken cancellationToken)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync(cancellationToken);
            return user;
        }

        public async Task<User> UpdateUserAsync(User user, CancellationToken cancellationToken)
        {
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync(cancellationToken);
            return user;
        }

        public async Task DeleteUserAsync(Guid userId, CancellationToken cancellationToken)
        {
            User user = await _context.Users.SingleOrDefaultAsync(u => u.UserId == userId, cancellationToken);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
