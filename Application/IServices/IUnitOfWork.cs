namespace Application.IServices
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        Task<int> CompleteAsync(CancellationToken cancellationToken);
    }
}
