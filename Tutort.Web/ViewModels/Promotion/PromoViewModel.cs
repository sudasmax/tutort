using System.Collections.Generic;
using Tutort.Web.ViewModels.Shared;

namespace Tutort.Web.Models.ViewModels.Promotion
{
	public class PromoViewModel : PageViewModel
	{
		public PromoViewModel()
		{
			this.PageTitle = "Розыгрыш - Зефирное Ассорти";
			//this.PageHeader.PageTitle = "Розыгрыш - Зефирное Ассорти";
		}

		public Dictionary<string, List<Comment>> CommentsByAuthor { get; set; }

		public PromoWinnerViewModel Winner { get; set; }
	}
}