
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PennyWise.Shared.Abstractions.Modules;

public interface IModule
{
    string Name { get; }
    string Path { get; }
    IEnumerable<string> Policies => null;
    void Register(IServiceCollection serviceCollection, IConfiguration configuration);
   //void Use(IApplicationBuilder applicationBuilder);
}