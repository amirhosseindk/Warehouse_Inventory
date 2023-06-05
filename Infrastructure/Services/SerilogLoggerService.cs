using Application.IServices;
using Serilog;

namespace Infrastructure.Services
{
    public class SerilogLoggerService : ILoggerService
    {
        private readonly ILogger logger;

        public SerilogLoggerService()
        {
            logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File("log/log.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }

        public void LogInformation(string message)
        {
            logger.Information(message);
        }

        public void LogDebug(string message)
        {
            logger.Debug(message);
        }
    }
}
