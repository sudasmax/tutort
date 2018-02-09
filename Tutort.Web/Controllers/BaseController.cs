using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Tutort.Web.Helpers;

namespace Tutort.Web.Controllers
{
    public class ControllerBase : Controller
    {
        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);

            this.InitializeCulture();
        }

        private void InitializeCulture()
        {
            string cultureName;

            // Attempt to read the culture cookie from Request
            HttpCookie cultureCookie = Request.Cookies["_culture"];

            if (cultureCookie != null)
            {
                cultureName = cultureCookie.Value;
            }
            else
            {
                cultureName = Request.UserLanguages != null && Request.UserLanguages.Length > 0
                    ? Request.UserLanguages[0]
                    : // obtain it from HTTP header AcceptLanguages
                    null;
            }

            // Validate culture name
            cultureName = CultureExtensions.GetImplementedCulture(cultureName); // This is safe

            // Modify current thread's cultures
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cultureName);
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
        }
    }
}