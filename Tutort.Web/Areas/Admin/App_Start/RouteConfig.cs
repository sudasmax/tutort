using System.Web.Mvc;

namespace Tutort.Web.Areas.Admin
{
	public class RouteConfig
	{
		public static void RegisterRoutes(AreaRegistrationContext context)
		{
			context.MapRoute("Admin#Home#Index", "admin", new { controller = "Home", action = "Index" });
		}
	}
}