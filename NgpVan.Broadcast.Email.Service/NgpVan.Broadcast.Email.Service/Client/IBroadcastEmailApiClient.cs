using NgpVan.Broadcast.Email.Service.Contracts;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NgpVan.Broadcast.Email.Service.Client
{
    [Headers("accept: application/json")]
    public interface IBroadcastEmailApiClient
    {
        /// <summary>
        /// Returns a list of emails.
        /// </summary>
        /// <returns>A list of the emails .</returns>
        [Get("/v2/broadcastsEmails")]
        Task<List<EmailContract>> GetAllEmailsAsync();
    }
}
