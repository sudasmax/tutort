using Tutort.Web.Models.Security;

namespace Tutort.Web.Services.Security
{
    public interface IAuthenticationService
    {
        bool Login(string username, string password);
        void Logout(User user);
    }
}
