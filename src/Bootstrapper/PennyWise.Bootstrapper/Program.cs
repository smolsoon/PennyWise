using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using PennyWise.Bootstrapper;
using PennyWise.Modules.Users.Core.DAL;
using PennyWise.Shared.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();

var assemblies = ModuleLoader.LoadAssemblies(builder.Configuration).ToList();
var modules = ModuleLoader.LoadModules(assemblies).ToList();

builder.Services.AddInfrastructure(assemblies, modules, builder.Configuration);

var connectionString = builder.Configuration.GetConnectionString("postgres");

builder.Services.AddDbContext<UsersDbContext>(options => options.UseNpgsql(connectionString));

foreach (var module in modules)
{
    module.Register(builder.Services, builder.Configuration);
}

var app = builder.Build();
app.UseInfrastructure();

app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers();
app.MapGet("/pennyWise", () => "Hello World!");

app.Run();
