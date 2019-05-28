using System;
using System.Threading.Tasks;

namespace Contoso.Apps.Insurance.WebAPI
{
    public class EncryptionHelper
    {
        /// <summary>
        /// The database connection string extracted from a Key Vault secret.
        /// </summary>
        public static string SecretConnectionString { get; set; }

        // The method that will be provided to the KeyVaultClient
        public static async Task<string> GetToken(string authority, string resource, string scope)
        {
            return string.Empty;
            //var authContext = new AuthenticationContext(authority);
            //var clientCred = new ClientCredential(WebConfigurationManager.AppSettings["ClientId"],
            //    WebConfigurationManager.AppSettings["ClientSecret"]);
            //var result = await authContext.AcquireTokenAsync(resource, clientCred);

            //if (result == null)
            //    throw new InvalidOperationException("Failed to obtain the JWT token");

            //return result.AccessToken;
        }
    }
}