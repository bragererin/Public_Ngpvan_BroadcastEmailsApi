using Microsoft.Extensions.Logging;
using NgpVan.Broadcast.Email.Service.Client;
using NgpVan.Broadcast.Email.Service.Contracts;
using NgpVan.Broadcast.Email.Service.DataAccess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NgpVan.Broadcast.Email.Service.BusinessLogic
{
    public class BroadcastEmailBusinessLogic :  IBroadcastEmailBusinessLogic

    {
        private readonly ILogger<BroadcastEmailBusinessLogic> _logger;
        private readonly IBroadcastEmailDataAccess _dataAccess;
        private readonly IBroadcastEmailApiClient _broadcastEmailApiClient;


        public BroadcastEmailBusinessLogic(ILogger<BroadcastEmailBusinessLogic> logger, IBroadcastEmailApiClient broadcastEmailApiClient, IBroadcastEmailDataAccess dataAccess)
        {
            _logger = logger;
            _broadcastEmailApiClient = broadcastEmailApiClient;
            _dataAccess = dataAccess;
        }

        public async Task<List<EmailContract>> GetAllEmailsAsync()
        {
            var emails =
                await _broadcastEmailApiClient.GetAllEmailsAsync();
            return (List<EmailContract>)emails;
        }
    }
}
