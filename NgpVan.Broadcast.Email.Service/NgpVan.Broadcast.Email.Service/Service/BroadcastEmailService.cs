using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace NgpVan.Broadcast.Email.Service.Service
{
    public class BroadcastEmailService : IHostedService
    {
        private readonly ILogger<BroadcastEmailService> _logger;

        public BroadcastEmailService(ILogger<BroadcastEmailService> logger)
        {
            _logger = logger;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Application has started.");
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Failed to start application.");
            }
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Application has stopped.");
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Failed to stop application.");
            }
        }
    }
}
