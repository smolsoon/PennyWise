using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PennyWise.Shared.Abstractions.Modules;
using PennyWise.Shared.Infrastructure.Modules;
using PennyWise.Shared.Infrastructure.Postgres;

[assembly: InternalsVisibleTo("PennyWise.Bootstrapper")]
namespace PennyWise.Shared.Infrastructure
{
    internal static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IEnumerable<Assembly> assemblies, 
            IEnumerable<IModule> modules, IConfiguration configuration)
        {
            services.AddModuleInfo(modules);
            //services.AddPostgres(configuration);
            
            return services;
        }

        public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
        {
            //app.UseRouting();
            
            return app;
        }
    }
}
