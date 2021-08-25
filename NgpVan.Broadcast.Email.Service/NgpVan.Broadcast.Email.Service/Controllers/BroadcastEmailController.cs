using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NgpVan.Broadcast.Email.Service.BusinessLogic;
using NgpVan.Broadcast.Email.Service.Contracts;
using NgpVan.Broadcast.Email.Service.Infrastructure;
using NgpVan.Broadcast.Email.Service.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NgpVan.Broadcast.Email.Service.Controllers
{
    [Authorize]
    [Produces("application/json")]
    [ApiController, Route("api/v{version:apiVersion}/")]
    public class BroadcastEmailController : ControllerBase
    {
        private readonly ILogger<BroadcastEmailController> _logger;
        private readonly IBroadcastEmailBusinessLogic _businessLogic;
        private readonly IUserService _userService;
        private readonly IJwtAuthManager _jwtAuthManager;

        public BroadcastEmailController(IBroadcastEmailBusinessLogic businessLogic, ILogger<BroadcastEmailController> logger, IUserService userService, IJwtAuthManager jwtAuthManager)
        {
            _businessLogic = businessLogic;
            _logger = logger;
            _userService = userService;
            _jwtAuthManager = jwtAuthManager;
        }

        /// <summary>
        ///     Retrieves a list of sent email messages
        /// </summary>
        /// <returns>List of emails</returns>
        /// <response code="200">OK</response>
        [AllowAnonymous]
        [HttpGet("/broadcastEmails")]
        public async Task<IEnumerable<EmailContract>> GetAllEmailsAsync()
        {
            return await _businessLogic.GetAllEmailsAsync();
        }
    }
}
