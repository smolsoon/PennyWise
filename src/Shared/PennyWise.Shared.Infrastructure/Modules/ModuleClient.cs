using PennyWise.Shared.Abstractions.Modules;

namespace PennyWise.Shared.Infrastructure.Modules;

internal class ModuleClient : IModuleClient
{
    private readonly IModuleRegistry _moduleRegistry;
    private readonly IModuleSerializer _moduleSerializer;

    public ModuleClient(IModuleRegistry moduleRegistry, IModuleSerializer moduleSerializer)
    {
        _moduleRegistry = moduleRegistry;
        _moduleSerializer = moduleSerializer;
    }
    
    public Task SendAsync(string path, object request)
    {
        throw new NotImplementedException();
    }

    public Task<TResult> SendAsync<TResult>(string path, object request) where TResult : class
    {
        throw new NotImplementedException();
    }

    public Task PublishAsync(object message)
    {
        throw new NotImplementedException();
    }
}