using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PolicyConnectDesktop.Authentication
{
    public static class AuthenticationMethods
    {
        public static string Username { get; set; } = "contoso";
        public static string Password { get; set; } = "P@ss4now";

        /// <summary>
        /// Indicates whether the user is current authenticated.
        /// </summary>
        public static bool IsAuthenticated { get; set; }
        
    }
}
