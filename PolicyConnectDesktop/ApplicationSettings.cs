using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyConnectDesktop
{
    /// <summary>
    /// Global application settings.
    /// </summary>
    public static class ApplicationSettings
    {
        /// <summary>
        /// The root folder of the Pdf files. Could be a network share.
        /// </summary>
        public static readonly string RootPdfPath = ConfigurationManager.AppSettings["PdfRootPath"];

        /// <summary>
        /// If set to true, IServiceCalls references are instantiated as WebApiCalls. Otherwise, WcfCalls.
        /// </summary>
        public static bool UseWebApi
        {
            get
            {
                var value = false;
                bool.TryParse(ConfigurationManager.AppSettings["UseWebApi"], out value);
                return value;
            }
        }

        /// <summary>
        /// Enter the root Web API path, once published to Azure.
        /// </summary>
        public static readonly string RootWebApiPath = ConfigurationManager.AppSettings["RootWebApiPath"];

        /// <summary>
        /// Retrieve below from the Client Id AAD application setting for this desktop client.
        /// </summary>
        public static readonly string DesktopClientId = ConfigurationManager.AppSettings["DesktopClientId"];

        /// <summary>
        /// Retrieve below from the Redirect URI AAD application setting for this desktop client.
        /// </summary>
        public static readonly string DesktopRedirectUri = ConfigurationManager.AppSettings["DesktopRedirectUri"];

        /// <summary>
        /// Retrieve WebApiAppId value from the AAD application settings for the Web API, under single sign-on.
        /// </summary>
        public static readonly string WebApiAppId = ConfigurationManager.AppSettings["WebApiAppId"];

        /// <summary>
        /// The URL of your Azure Active Directory tenant (AzureADLoginUrl) should be: https://login.windows.net/<tenantID> You can find
        /// your Tentant Id by going to the Azure AD Quick Start Page, selecting 'Develop Applications', then selecting
        /// View Authentication and Authorization Endpoints.The Tenant Id is a Guid value that follows 'login.microsoftonline.com/'
        /// </summary>
        public static readonly string AzureADLoginUrl = ConfigurationManager.AppSettings["AzureADLoginUrl"];

        /// <summary>
        /// You can find your Tentant Id by going to the Azure AD Quick Start Page, selecting 'Develop Applications', then selecting
        /// View Authentication and Authorization Endpoints.The Tenant Id is a Guid value that follows 'login.microsoftonline.com/'
        /// </summary>
        public static readonly string AzureADTenantId = ConfigurationManager.AppSettings["AzureADTenantId"];
    }
}
