using Microsoft.Extensions.Logging;

namespace NgpVan.Broadcast.Email.Service.Service
{
    public interface IUserService
    {
        bool ValidateCredentials(string username, string password);
    }

    public class UserService : IUserService
    {
        private readonly ILogger<UserService> _logger;
                
        // inject your database here for user validation
        public UserService(ILogger<UserService> logger)
        {
            _logger = logger;
        }

        public bool ValidateCredentials(string username, string password)
        {
            return username.Equals("admin") && password.Equals("Pa$$WoRd");
        }
    }
}
