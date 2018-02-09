using System.Web.Mvc;
using Tutort.Web.Models.ViewModels.Catalog;

namespace Tutort.Web.Controllers
{
	public class CatalogController : Controller
	{
		// GET: Catalog
		public ActionResult Index()
		{
			var viewModel = new CatalogViewModel();

			return View(viewModel);
		}
	}
}