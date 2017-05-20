using System.Web.Services.Protocols;

namespace WebService
{
    public class CustomAuthentication : SoapHeader
    {
        public string Username;
        public string Password;
    }
}