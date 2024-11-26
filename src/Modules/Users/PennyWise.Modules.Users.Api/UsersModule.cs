using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PennyWise.Modules.Users.Core;
using PennyWise.Shared.Abstractions.Modules;

namespace PennyWise.Modules.Users.Api;

internal class UsersModule : IModule
{
    private const string BasePath = "users_module";
    
    public string Name { get; } = "users";
    public string Path => BasePath;
    
    public void Register(IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.AddCore(configuration);
        Console.WriteLine("Register User Module");
    }

    public void Use(IApplicationBuilder applicationBuilder)
    {
        throw new NotImplementedException();
    }
}