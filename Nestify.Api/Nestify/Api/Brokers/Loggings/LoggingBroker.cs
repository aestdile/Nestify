//==================================================
// Welcome! I'm Mukhtor C#.Net Junior Developer
// Residental Training Software
//==================================================


using Microsoft.Extensions.Logging;

namespace Nestify.Api.Brokers.Loggings
{
    internal class LoggingBroker
    {
        private readonly ILogger logger;
        public LoggingBroker(ILogger logger) => this.logger = logger;
        public void LogInformation(string message) => this.logger.LogInformation(message);
        public void LogDebug(string message) => this.logger.LogDebug(message);
        public void LogTrace(string message) => this.logger.LogTrace(message);
        public void LogWarning(string message) => this.logger.LogWarning(message);
        public void LogError(string message) => this.logger.LogError(message);
        public void LogCritical(string message) => this.logger.LogCritical(message);
    }
}