using System;
using System.Collections.Generic;
using System.Text;

namespace CIMobile
{
    public static class ApplicationSettings
    {
        /// <summary>
        /// Enter the root Web API path, once published to Azure.
        /// </summary>
        public static readonly string RootWebApiPath = "";

        /// <summary>
        /// Enter the blob container Url where the policy PDF files are kept. You can find this by navigating to your Storage account
        /// in Azure, clicking on Blobs on the Overview blade, then selecting the container (such as "policies") within the Blob service
        /// blade, and finally clicking Properties, then the copy button next to the URL.
        /// </summary>
        public static readonly string BlobContainerUrl = "https://<YOUR-STORAGE-ACCOUNT-NAME>.blob.core.windows.net/policies";

        /// <summary>
        /// Retrieve below from the Client Id AAD application setting for this mobile client.
        /// </summary>
        public static readonly string MobileClientId = "";

        /// <summary>
        /// Retrieve below from the Redirect URI AAD application setting for this mobile client.
        /// </summary>
        public static readonly string MobileRedirectUri = "http://contosoinsurance.mobile.client";

        /// <summary>
        /// Retrieve WebApiAppId value from the AAD application settings for the Web API, under single sign-on. It is the App ID URI.
        /// </summary>
        public static readonly string WebApiAppId = "";

        /// <summary>
        /// Retrieve WebApiReplyUrl value from the AAD application settings for the Web API, under single sign-on. It is the Reply URL.
        /// </summary>
        public static readonly string WebApiReplyUrl = "";

        /// <summary>
        /// The URL of your Azure Active Directory tenant (AzureADLoginUrl) should be: https://login.windows.net/<tenantID> You can find
        /// your Tentant Id by going to the Azure AD Quick Start Page, selecting 'Develop Applications', then selecting
        /// View Authentication and Authorization Endpoints.The Tenant Id is a Guid value that follows 'login.microsoftonline.com/'
        /// </summary>
        public static readonly string AzureADLoginUrl = "";

        public static readonly string GraphResourceUri = "https://graph.windows.net";

        /// <summary>
        /// You can find your Tentant Id by going to the Azure AD Quick Start Page, selecting 'Develop Applications', then selecting
        /// View Authentication and Authorization Endpoints.The Tenant Id is a Guid value that follows 'login.microsoftonline.com/'
        /// </summary>
        public static readonly string AzureADTenantId = "";

        /// <summary>
        /// In Azure, select your search service, then the "policies" index, then "Search explorer". Copy the full URL within the
        /// Request URL field. Make sure to include the entire path, even the "&search=*" at the end.
        /// </summary>
        public static readonly string AzureSearchServiceUrl = "";

        /// <summary>
        /// Enter the Azure Search query API key. This can be found by selecting your search service in Azure, then clicking on Keys,
        /// click on Manage query keys, then copy the displayed key (or create one if none exist).
        /// </summary>
        public static readonly string AzureSearchQueryApiKey = "<your search query api key>";
    }
}