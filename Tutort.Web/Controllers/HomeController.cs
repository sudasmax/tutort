using System.Web.Mvc;
using Tutort.SocialNetworks.Social.Interfaces;
using Tutort.Web.ViewModels.Home;
using Tutort.Web.ViewModels.Page;

namespace Tutort.Web.Controllers
{
    public class HomeController : PageController
    {
        public HomeController(ISocialIntegrationService socialIntegrationService)
            : base(socialIntegrationService)
        {
        }

        public ActionResult Index()
        {
            var model = new HomePageViewModel();
            return View(model);
        }

        public ActionResult About()
        {
            var model = new AboutPageViewModel();
            return View(model);
        }

        public ActionResult Contact()
        {
            var model = new ContactPageViewModel();
            return View(model);
        }
	}
}