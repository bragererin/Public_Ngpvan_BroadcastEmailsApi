using Microsoft.Extensions.Logging;
using NgpVan.Broadcast.Email.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NgpVan.Broadcast.Email.Service.DataAccess
{
    public class BroadcastEmailDataAccess : IBroadcastEmailDataAccess
    {
        private readonly ILogger<BroadcastEmailDataAccess> _logger;

        public BroadcastEmailDataAccess(ILogger<BroadcastEmailDataAccess> logger)
        {
            _logger = logger;
        }
        
    }
 }
