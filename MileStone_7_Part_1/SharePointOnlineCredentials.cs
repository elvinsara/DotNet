using System.Net;
using System.Security;

namespace MileStone_7_Part_1
{
    internal class SharePointOnlineCredentials : ICredentials
    {
        private string username;
        private SecureString securePassword;

        public SharePointOnlineCredentials(string username, SecureString securePassword)
        {
            this.username = username;
            this.securePassword = securePassword;
        }
    }
}