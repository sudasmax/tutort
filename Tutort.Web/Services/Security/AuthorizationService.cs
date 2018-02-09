using Tutort.Web.Models.Security;

namespace Tutort.Web.Services.Security
{
    public class AuthorizationService : IAuthorizationService
    {
        public bool Authorize(User user, Roles requiredRoles)
        {
            if (user.IsAdministrator)
            {
                return true;
            }
            else
            {
                // Check if the roles enum has the specific role bit set.
                return (requiredRoles & user.Permissions) == requiredRoles;
            }
        }
    }
}