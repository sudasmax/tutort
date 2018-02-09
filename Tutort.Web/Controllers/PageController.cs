using System.Web.Mvc;
using Tutort.SocialNetworks.Social.Interfaces;
using Tutort.Web.Models.Design;
using Tutort.Web.ViewModels.Page;

namespace Tutort.Web.Controllers
{
    public class PageController : ControllerBase
    {
        protected readonly ISocialIntegrationService socialIntegrationService;

        public PageController(ISocialIntegrationService socialIntegrationService)
        {
            this.socialIntegrationService = socialIntegrationService;
        }

        [ChildActionOnly]
        public ActionResult PageHeader(string title)
        {
            var viewModel = new HeadLineViewModel { Title = title };
            return PartialView(viewModel);
        }

        [ChildActionOnly]
        [OutputCache(Duration = 360, VaryByParam = "*")]
        public ActionResult Header()
        {
            var viewModel = new HeaderViewModel();
            return PartialView(viewModel);
        }

        [ChildActionOnly]
        [OutputCache(Duration = 360, VaryByParam = "*")]
        public ActionResult Footer()
        {
            var viewModel = new FooterViewModel();
            return PartialView(viewModel);
        }
    }
}