
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PennyWise.Modules.Users.Core.DAL;
using PennyWise.Modules.Users.Core.DAL.Repositories;
using PennyWise.Modules.Users.Core.Repositories;
using PennyWise.Modules.Users.Core.Services;
using PennyWise.Shared.Infrastructure.Postgres;

[assembly: InternalsVisibleTo("PennyWise.Modules.Users.Api")]
namespace PennyWise.Modules.Users.Core;

internal static class Extensions
{
    internal static IServiceCollection AddCore(this IServiceCollection services, IConfiguration configuration)
    {
       services.AddTransient<IUserRepository, UserRepository>();
       services.AddTransient<IUserService, UserService>();
       services.AddPostgres<UsersDbContext>(configuration);
        
       return services;
    }
}