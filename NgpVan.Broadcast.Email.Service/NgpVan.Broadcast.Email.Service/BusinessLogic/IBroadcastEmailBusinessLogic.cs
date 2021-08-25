using NgpVan.Broadcast.Email.Service.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NgpVan.Broadcast.Email.Service.BusinessLogic
{
    public interface IBroadcastEmailBusinessLogic
    {
        /// <summary>
        /// Retrieves a list of all emails.
        /// </summary>
        /// <returns></returns>
        Task<List<EmailContract>> GetAllEmailsAsync();
    }
}
