using PennyWise.Modules.Users.Core.Entities;

namespace PennyWise.Modules.Users.Core.Repositories;

internal interface IUserRepository
{
    Task<User?> GetAsync(Guid id);
    Task<User?> GetAsync(string email);
    Task<IEnumerable<User>> BrowseAsync();
    Task AddAsync(User user);
    Task UpdateAsync(User user);
    Task RemoveAsync(Guid id);
}