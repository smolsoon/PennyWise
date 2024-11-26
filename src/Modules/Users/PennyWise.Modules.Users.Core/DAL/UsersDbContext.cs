using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using PennyWise.Modules.Users.Core.Entities;

[assembly: InternalsVisibleTo("PennyWise.Bootstrapper")]
namespace PennyWise.Modules.Users.Core.DAL;

internal class UsersDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
        
    public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("users");
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}