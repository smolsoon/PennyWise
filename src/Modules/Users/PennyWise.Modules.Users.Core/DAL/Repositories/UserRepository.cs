using Microsoft.EntityFrameworkCore;
using PennyWise.Modules.Users.Core.Entities;
using PennyWise.Modules.Users.Core.Repositories;

namespace PennyWise.Modules.Users.Core.DAL.Repositories;

internal class UserRepository(UsersDbContext context) : IUserRepository
{
    private readonly DbSet<User> _users = context.Users;

    public Task<User?> GetAsync(Guid id) => 
        _users.SingleOrDefaultAsync(x => x.Id == id);

    public Task<User?> GetAsync(string email) =>
        _users.SingleOrDefaultAsync(x => x.Email == email);

    public Task<IEnumerable<User>> BrowseAsync()
    {
        throw new NotImplementedException();
    }

    public async Task AddAsync(User user)
    {
        await _users.AddAsync(user);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(User user)
    {
        _users.Update(user);
        await context.SaveChangesAsync();
    }

    public Task RemoveAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}