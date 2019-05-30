using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace PolicyConnectDesktop.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        string _AzureAuthenticationClientId;
        string _AzureGraphApiClientId;
        string _TenantAuthority;
        string _ReturnUri;
        string _ResourceUri;

        readonly Authenticator _Authenticator;

        public AuthenticationResult AuthenticationResult { get; private set; }

        public AuthenticationService()
        {
            _Authenticator = new Authenticator();
        }

        public async Task<bool> AuthenticateAsync()
        {
            GetConfigAsync();

            // prompts the user for authentication
            AuthenticationResult = await _Authenticator.Authenticate(_TenantAuthority, _ResourceUri, _AzureAuthenticationClientId, _ReturnUri);

            AuthenticationMethods.Username = AuthenticationResult.UserInfo.DisplayableId;

            return true;
        }

        public async Task<bool> LogoutAsync()
        {
            GetConfigAsync();

            await Task.Factory.StartNew(async () =>
            {
                var success = await _Authenticator.DeAuthenticate(_TenantAuthority);
                if (!success)
                {
                    throw new Exception("Failed to DeAuthenticate!");
                }
                AuthenticationResult = null;
            });
            return true;
        }

        public async Task<string> GetTokenAsync()
        {
            GetConfigAsync();

            return await _Authenticator.FetchToken(_TenantAuthority);
        }

        public bool IsAuthenticated
        {
            get
            {
                if (_AuthenticationBypassed)
                    return true;
                else
                    return AuthenticationResult != null;
            }
        }

        bool _AuthenticationBypassed;
        /// <summary>
        /// Used only for demo, to quickly bypass actual authentication
        /// </summary>
        /// <returns>Task</returns>
        public void BypassAuthentication()
        {
            _AuthenticationBypassed = true;
        }

        private void GetConfigAsync()
        {
            if (_AzureAuthenticationClientId == null)
                _AzureAuthenticationClientId = ApplicationSettings.DesktopClientId;

            if (_AzureGraphApiClientId == null)
                _AzureGraphApiClientId = ApplicationSettings.AzureADTenantId;

            if (_TenantAuthority == null)
                _TenantAuthority = ApplicationSettings.AzureADLoginUrl;

            if (_ReturnUri == null)
                _ReturnUri = ApplicationSettings.DesktopRedirectUri;

            //if (_ResourceUri == null)
            //    _ResourceUri = ApplicationSettings.GraphResourceUri;
            if (_ResourceUri == null)
                _ResourceUri = ApplicationSettings.WebApiAppId;
        }
    }
}
