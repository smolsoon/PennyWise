using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace PennyWise.Modules.Users.Core.DAL;

internal class UserContextFactory : IDesignTimeDbContextFactory<UsersDbContext>
{
    public UsersDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<UsersDbContext>();
        
        var appBasePath = Environment.GetEnvironmentVariable("APP_BASE_PATH");
        var basePath = Path.Combine(appBasePath, @"Bootstrapper\PennyWise.Bootstrapper");

        var configuration = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseSqlServer(connectionString);

        return new UsersDbContext(optionsBuilder.Options);
    }
}