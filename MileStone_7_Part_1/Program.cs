using System.Collections.Generic;
using Microsoft.SharePoint.Client;
using System.Security;
namespace MileStone_7_Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string siteUrl = "https://elvin.sharepoint.com/sites/yoursite";
            string username = "elvin@domain.com";
            string password = "123456"; // for example purposes, get it securely

            // Convert password to SecureString
            SecureString securePassword = new SecureString();
            foreach (char c in password.ToCharArray())
            {
                securePassword.AppendChar(c);
            }
            securePassword.MakeReadOnly();

            try
            {
                using (ClientContext context = new ClientContext(siteUrl))
                {
                    // Use SharePointOnlineCredentials
                    context.Credentials = new SharePointOnlineCredentials(username, securePassword);

                    // Load web and execute query
                    Web web = context.Web;
                    context.Load(web);
                    context.ExecuteQuery();

                    Console.WriteLine("Connected to site: " + web.Title);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}