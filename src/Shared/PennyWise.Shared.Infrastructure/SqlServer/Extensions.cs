using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace PennyWise.Shared.Infrastructure.SqlServer;

public static class Extensions
{
    public static IServiceCollection AddSqlServer<T>(this IServiceCollection services) where T : DbContext
    {
        return services;
    }
    
    public static IServiceCollection AddSqlServer(this IServiceCollection services)
    {
        return services;
    }
}