using System.Web.Mvc;
using System.Web.Routing;

namespace Tutort.Web.Admin
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("AdminExternal#Home#Index", "adminext", new { area = "AdminExternal", controller = "Home", action = "Index" }, new string[] { "Tutort.Web.Admin.Controllers" });
        }
    }
}
