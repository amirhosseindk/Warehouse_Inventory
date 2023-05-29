namespace Application.IServices
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        Task<int> CompleteAsync(CancellationToken cancellationToken);
    }
}
