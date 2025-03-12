//==================================================
// Welcome! I'm Mukhtor C#.Net Junior Developer
// Residental Training Software
//==================================================



using System;
using Microsoft.Extensions.Logging;

namespace Nestify.Api.Brokers.Loggings
{
    public class LoggingBreaker : ILoggingBroker
    {
        private readonly ILogger<LoggingBreaker> logger;

        public LoggingBreaker(ILogger<LoggingBreaker> logger) => 
            this.logger = logger;
        
        public void LogError(Exception exception) => 
            this.logger.LogError(exception, exception.Message);
        
        public void LogCritical(Exception exception) => 
            this.logger.LogCritical(exception, exception.Message);

    }
}
