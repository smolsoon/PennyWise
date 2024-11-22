using Microsoft.Extensions.DependencyInjection;
using PennyWise.Modules.Users.Core.DAL.Repositories;
using PennyWise.Modules.Users.Core.Repositories;

namespace PennyWise.Modules.Users.Core;

internal static class Extensions
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        return services.AddScoped<IUserRepository, UserRepository>();
    }
}