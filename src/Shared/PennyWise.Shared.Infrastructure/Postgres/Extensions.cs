using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PennyWise.Shared.Infrastructure.Postgres;

public static class Extensions
{
    public static IServiceCollection AddPostgres<T>(this IServiceCollection services, IConfiguration configuration) where T : DbContext
    {
        // var connectionString = configuration.GetSection("postgres").GetSection("connectionString").Value;
        // services.AddDbContext<T>(x => x.UseNpgsql(connectionString));

        return services;
    }
    
    internal static IServiceCollection AddPostgres(this IServiceCollection services, IConfiguration configuration)
    {
        // var options = configuration.GetSection("postgres");
        // services.AddSingleton(options);

        return services;
    }
}