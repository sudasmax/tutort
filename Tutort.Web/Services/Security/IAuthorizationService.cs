using Tutort.Web.Models.Security;

namespace Tutort.Web.Services.Security
{
    public interface IAuthorizationService
    {
        bool Authorize(User user, Roles requiredRoles);
    }
}
