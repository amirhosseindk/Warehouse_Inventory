namespace Application.IServices
{
    public interface ILoggerService
    {
        void LogInformation(string message);
        void LogDebug(string message);
    }
}
