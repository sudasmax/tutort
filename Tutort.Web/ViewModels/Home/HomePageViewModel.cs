using Tutort.Web.ViewModels.Shared;

namespace Tutort.Web.ViewModels.Home
{
	public class HomePageViewModel : PageViewModel
	{
		public HomePageViewModel()
		{
			this.PageTitle = Localization.PageHome.PageTitle;
		}
	}
}