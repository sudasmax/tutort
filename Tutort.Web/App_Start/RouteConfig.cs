using System.Web.Mvc;
using System.Web.Routing;

namespace Tutort.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Base pages
            routes.MapRoute("Page#Header", "page/header", new { controller = "Page", action = "Header" });
            routes.MapRoute("Page#Footer", "page/footer", new { controller = "Page", action = "Footer" });

            routes.MapRoute("Home#Index", "", new { controller = "Home", action = "Index" }, new string[] { "Tutort.Web.Controllers" });
            //routes.MapRoute("Home#About", "about", new { controller = "Home", action = "About" });
            //routes.MapRoute("Home#Contact", "contact", new { controller = "Home", action = "Contact" });

            //routes.MapRoute("Page#PageHeader", "page/header", new { controller = "Page", action = "PageHeader" });

            //routes.MapRoute("Catalog#Index", "catalog", new { controller = "Catalog", action = "Index" });

            routes.MapRoute("Giveaway#ShowList", "giveaway", new { controller = "Giveaway", action = "ShowList" });
            routes.MapRoute("Giveaway#Show", "giveaway/{key}", new { controller = "Giveaway", action = "Show" });
            routes.MapRoute("Giveaway#SelectWinner", "giveaway/{key}/select", new { controller = "Giveaway", action = "SelectWinner" });
            //routes.MapRoute("Promotion#Index", "promo", new { controller = "Promotion", action = "Index" });
            //routes.MapRoute("Promotion#GetWinner", "promo/select", new { controller = "Promotion", action = "GetWinner" }, new { httpMethod = new HttpMethodConstraint("POST") });
            //routes.MapRoute("Page.Promo", "promo/{promoId}", new { controller = "Promotion", action = "ShowPromo"});

            // Authentication and registration
            //routes.MapRoute("Auth#Auth", "auth", new { controller = "Auth", action = "Auth" });
            //routes.MapRoute("Auth#Login", "login", new { controller = "Auth", action = "Login" });

            //routes.MapRoute("GenericRoute", "{controller}/{action}");
        }
    }
}
