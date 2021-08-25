using Microsoft.Extensions.Configuration;
using System;

namespace NgpVan.Broadcast.Email.Service.Client
{
    public class BroadcastEmailApiClientConfiguration
    {
        public BroadcastEmailApiClientConfiguration()
        {
        }

        public BroadcastEmailApiClientConfiguration(IConfiguration configuration) : base()
        {
        }

        public const string BroadcastEmailApiClient = "BroadcastEmailApi";

        public bool Log { get; set; }

        public Uri BaseUri { get; set; }
    }
}
