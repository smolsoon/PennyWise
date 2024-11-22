namespace PennyWise.Shared.Infrastructure.SqlServer;

public interface IUnitOfWork
{
    Task ExecuteAsync(Func<Task> action);
}