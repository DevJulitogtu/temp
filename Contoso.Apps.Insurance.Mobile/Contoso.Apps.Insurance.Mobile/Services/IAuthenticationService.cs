
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace CIMobile.Services
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync();

        Task<bool> LogoutAsync();

        Task<string> GetTokenAsync();

        bool IsAuthenticated { get; }

        AuthenticationResult AuthenticationResult { get; }

        /// <summary>
        /// Used only for demo, to quickly bypass actual authentication
        /// </summary>
        /// <returns>Task</returns>
        void BypassAuthentication();
    }
}

