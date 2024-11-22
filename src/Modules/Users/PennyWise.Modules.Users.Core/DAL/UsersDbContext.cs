using Microsoft.EntityFrameworkCore;
using PennyWise.Modules.Users.Core.Entities;

namespace PennyWise.Modules.Users.Core.DAL;

internal class UsersDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}