using System.Web.Mvc;

namespace Tutort.Web.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var view = View();
            return view;
        }
    }
}